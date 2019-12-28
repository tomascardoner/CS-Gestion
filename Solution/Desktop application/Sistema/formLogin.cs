using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class formLogin : Form
    {
        private int intentos = 0;
        private CSGestionContext context;

        public formLogin()
        {
            InitializeComponent();

            context = new CSGestionContext(true);

            if (Properties.Settings.Default.LastUserLoggedInShow && Properties.Settings.Default.LastUserLoggedIn.Length > 0)
            {
                textboxNombre.Text = Properties.Settings.Default.LastUserLoggedIn;
                labelPassword.TabIndex = 0;
                textboxPassword.TabIndex = 1;
                labelNombre.TabIndex = 6;
                textboxNombre.TabIndex = 7;
            }
        }

        private void this_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                buttonAceptar.PerformClick();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                buttonCancelar.PerformClick();
            }
        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
        }

        private void TextBoxs_Enter(object sender, System.EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();
        }

        private void Aceptar_Click(object sender, System.EventArgs e)
        {
            textboxNombre.Text = textboxNombre.Text.Trim();

            if (textboxNombre.TextLength == 0)
            {
                MessageBox.Show("Debe ingresar el Nombre del Usuario.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxNombre.Focus();
                return;
            }

            if (textboxNombre.TextLength < 4)
            {
                MessageBox.Show("El Nombre del Usuario debe contener al menos 4 caracteres.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxNombre.Focus();
                return;
            }

            if (textboxPassword.TextLength == 0)
            {
                MessageBox.Show("Debe ingresar la Contraseña.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxPassword.Focus();
                return;
            }

            byte UserPasswordMinimumLenght;
            if (Parametros.GetBoolean(Parametros.UserPasswordSecureRequired, true))
            {
                UserPasswordMinimumLenght = Parametros.GetIntegerAsByte(Parametros.UserPasswordMinimumLenght, 8);
            }
            else
            {
                UserPasswordMinimumLenght = 4;
            }

            if (textboxPassword.TextLength < UserPasswordMinimumLenght)
            {
                MessageBox.Show(string.Format("La Contraseña debe contener al menos {0} caracteres.", UserPasswordMinimumLenght), CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxPassword.Focus();
                return;
            }

            // Está todo OK, busco el Usuario en la Base de Datos
            this.Cursor = Cursors.WaitCursor;

            Usuario usuario = context.Usuario.Where(usr => usr.Nombre == textboxNombre.Text).FirstOrDefault();
            if (usuario == null)
            {
                Program.EventLog.WriteEntry(string.Format("Se intentó iniciar sesión con el Usuario '{0}', pero es inexistente.", textboxNombre.Text.Trim()), System.Diagnostics.EventLogEntryType.FailureAudit, Constantes.EventUserLoginFailure);
                MessageBox.Show("El Nombre de Usuario ingresado no existe.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textboxNombre.SelectAll();
                textboxNombre.Focus();
                usuario = null;
                this.Cursor = Cursors.Default;
                intentos++;
                if (intentos > 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                return;
            }

            if (string.Compare(textboxPassword.Text, usuario.Password, false) != 0)
            {
                Program.EventLog.WriteEntry(string.Format("Se intentó iniciar sesión con el Usuario '{0}', pero la Contraseña es incorrecta.", textboxNombre.Text.Trim()), System.Diagnostics.EventLogEntryType.FailureAudit, Constantes.EventUserLoginFailure);
                MessageBox.Show("La contraseña ingresada es incorrecta.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textboxPassword.SelectAll();
                textboxPassword.Focus();
                usuario = null;
                this.Cursor = Cursors.Default;
                intentos++;
                if (intentos > 3)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                return;
            }

            if (!usuario.Login())
            {
                this.DialogResult = DialogResult.Cancel;
                return;
            }

            Program.Usuario = usuario;
            usuario = null;

            // Guardo el Nombre de Usuario para mostrarlo la próxima vez
            Properties.Settings.Default.LastUserLoggedIn = Program.Usuario.Nombre;
            Properties.Settings.Default.Save();

            this.Cursor = Cursors.Default;

            this.DialogResult = DialogResult.OK;
        }

        private void Cancelar_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
