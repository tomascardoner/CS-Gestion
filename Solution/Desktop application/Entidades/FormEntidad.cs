using System;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidad : Form
    {

        #region Declarations

        private CSGestionContext context = new CSGestionContext(true);
        private Entidad entidad;

        private bool isLoading = false;
        private bool isNew = false;
        private bool isEditMode = false;

        #endregion

        #region Form stuff

        public FormEntidad()
        {
            InitializeComponent();
        }

        internal void LoadAndShow(bool editMode, Form parentForm, int idEntidad)
        {
            isLoading = true;
            isNew = (idEntidad == 0);
            isEditMode = editMode;

            if (isNew)
            {
                entidad = new Entidad();
                entidad.EsActivo = true;
                entidad.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                entidad.FechaHoraCreacion = DateTime.Now;
                entidad.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidad.FechaHoraModificacion = DateTime.Now;
                context.Entidad.Add(entidad);
            }
            else
            {
                entidad = context.Entidad.Find(idEntidad);
            }

            this.MdiParent = Program.FormMdi;
            CardonerSistemas.Forms.CenterToParent(parentForm, this);
            InitializeFormAndControls();
            SetDataFromObjectToControls();
            this.Show();
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Focus();

            isLoading = false;

            ChangeEditMode();
        }

        private void ChangeEditMode()
        {
            if (isLoading)
            {
                return;

            }

            buttonGuardar.Visible = isEditMode;
            buttonCancelar.Visible = isEditMode;
            buttonEditar.Visible = !isEditMode;
            buttonCerrar.Visible = !isEditMode;

            // General
            radiobuttonTipoPersonaFisica.Enabled = isEditMode;
            radiobuttonTipoPersonaJuridica.Enabled = isEditMode;
            textboxRazonSocial.ReadOnly = !isEditMode;
            textboxNombreFantasia.ReadOnly = !isEditMode;
            textboxApellido.ReadOnly = !isEditMode;
            textboxNombre.ReadOnly = !isEditMode;
            maskedtextboxCuit.ReadOnly = !isEditMode;
            textboxIngresosBrutos.ReadOnly = !isEditMode;

            // Notas y Auditoría
            textboxNotas.ReadOnly = !isEditMode;
            checkboxEsActivo.Enabled = isEditMode;
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();
        }

        private void SetAppearance()
        { 

        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            entidad = null;
            this.Dispose();
        }

        #endregion

        #region Load and Set Data

        private void SetDataFromObjectToControls()
        {
            // General
            radiobuttonTipoPersonaFisica.Checked = entidad.EsPersonaFisica;
            radiobuttonTipoPersonaJuridica.Checked = !entidad.EsPersonaFisica;
            textboxRazonSocial.Text = CardonerSistemas.ValueTranslation.ObjectStringToTextBox(entidad.RazonSocial);
            textboxNombreFantasia.Text = CardonerSistemas.ValueTranslation.ObjectStringToTextBox(entidad.NombreFantasia);
            textboxApellido.Text = CardonerSistemas.ValueTranslation.ObjectStringToTextBox(entidad.Apellido);
            textboxNombre.Text = CardonerSistemas.ValueTranslation.ObjectStringToTextBox(entidad.Nombre);
            maskedtextboxCuit.Text = CardonerSistemas.ValueTranslation.ObjectStringToTextBox(entidad.Cuit);
            textboxIngresosBrutos.Text = CardonerSistemas.ValueTranslation.ObjectStringToTextBox(entidad.IngresosBrutos);

            // Notas y Auditoría
            textboxNotas.Text = CardonerSistemas.ValueTranslation.ObjectStringToTextBox(entidad.Notas);
            checkboxEsActivo.CheckState = CardonerSistemas.ValueTranslation.ObjectBooleanToCheckBox(entidad.EsActivo);
            textboxId.Text = entidad.IdEntidadFormatted;
            textboxFechaHoraCreacion.Text = entidad.FechaHoraCreacionFormatted;
            textboxUsuarioCreacion.Text = entidad.UsuarioCreacionFormatted;
            textboxFechaHoraModificacion.Text = entidad.FechaHoraModificacionFormatted;
            textboxUsuarioModificacion.Text = entidad.UsuarioModificacionFormatted;
        }

        private void SetDataFromControlsToObject()
        {
            // General
            entidad.EsPersonaFisica = (radiobuttonTipoPersonaFisica.Checked);
            //entidad.RazonSocial = textboxRazonSocial.Text;

        }

        #endregion

        #region Controls behavior

        private void this_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Return:
                    if (isEditMode)
                    {
                        buttonGuardar.PerformClick();
                    }
                    else
                    {
                        buttonCerrar.PerformClick();
                    }
                    break;
                case (char)Keys.Escape:
                    if (isEditMode)
                    {
                        buttonCancelar.PerformClick();
                    }
                    else
                    {
                        buttonCerrar.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }

        private void TextBoxs_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void MaskedTextBoxs_Enter(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).SelectAll();
        }

        #endregion

        #region Main toolbar

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadEditar))
            {
                isEditMode = true;
                ChangeEditMode();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (context.ChangeTracker.HasChanges())
            {
                if (MessageBox.Show(string.Format("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", System.Environment.NewLine), CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        #endregion

    }
}
