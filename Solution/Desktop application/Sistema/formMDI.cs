using System;
using System.Drawing;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormMdi : Form
    {

        #region Declarations

        private Size formMdiClientSize;

        #endregion

        #region Form stuff

        public FormMdi()
        {
            InitializeComponent();
            SetAppearance();
        }

        private void SetAppearance()
        {
            this.Cursor = Cursors.AppStarting;
            this.Icon = Properties.Resources.IconApplication32;
            this.Enabled = false;
            this.Text = CardonerSistemas.My.Application.Info.Title;

            menuitemAyudaAcercaDe.Text = "&Acerca de " + CardonerSistemas.My.Application.Info.Title + "...";

            // GroupView de comandos
            CommandToolbar.AddCommands(this);
            imagelistMain.Images.Add(Properties.Resources.ImageEntidad48);
        }

        private void Me_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                // Obtengo las medidas del client area del form MDI
                formMdiClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height - menustripMain.Height - statusstripMain.Height);

                // Hago un resize de todos los childs que estén abiertos
                foreach (Form form in this.MdiChildren)
                {
                    if (form.FormBorderStyle == FormBorderStyle.Sizable)
                    {
                        CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(this, form);
                    }
                    else
                    {
                        CardonerSistemas.Forms.MdiChildCenterToClientArea(form, formMdiClientSize);
                    }
                }
            }
        }

        private void Me_Closing(object sender, FormClosingEventArgs e)
        {
            if (!((e.CloseReason == CloseReason.ApplicationExitCall) | (e.CloseReason == CloseReason.TaskManagerClosing) | (e.CloseReason == CloseReason.WindowsShutDown)))
            {
                if (MessageBox.Show("¿Desea salir de la aplicación?", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
            Program.TerminateApplication();
        }

        #endregion

        #region Menú Archivo

        private void Opciones(object sender, EventArgs e)
        {
            // formOpciones.ShowDialog(Me);
        }

        private void UsuarioCerrarSesion(object sender, EventArgs e)
        {
            // CerrarSesionUsuario();
        }

        private void menuitemArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Menú Edición

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Menú Debug

        #endregion

        #region Menú Ventana

        private void menuitemVentanaMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuitemVentanaMosaicoVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuitemVentanaCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void menuitemVentanaOrganizarIconos_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void menuitemVentanaCerrarTodas_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuitemVentanaEncajarEnVentana_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Left = 0;
                this.ActiveMdiChild.Top = 0;
                this.ActiveMdiChild.Size = formMdiClientSize;
            }
        }

        #endregion

        #region Menú Ayuda


        #endregion

        #region Comandos - Principal

        private void ComandosPrincipales_ItemSelected(object sender, EventArgs e)
        {
            Syncfusion.Windows.Forms.Tools.GroupView group = (Syncfusion.Windows.Forms.Tools.GroupView)sender;
            if (group.SelectedItem >= 0)
            {
                switch (group.GroupViewItems[group.SelectedItem].Text)
                {
                    case CommandToolbar.PrincipalEntidades:
                        MostrarForm(Permisos.Entidad, new FormEntidades());
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region Comandos - Tablas

        private void ComandosTablas_ItemSelected(object sender, EventArgs e)
        {
            Syncfusion.Windows.Forms.Tools.GroupView group = (Syncfusion.Windows.Forms.Tools.GroupView)sender;
            if (group.SelectedItem >= 0)
            {
                switch (group.GroupViewItems[group.SelectedItem].Text)
                {
                    case CommandToolbar.TablasCategoriasEntidades:
                        MostrarForm(Permisos.EntidadCategoria, new FormEntidadCategorias(false));
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region Misc functions

        private void MostrarForm(string idPermiso, Form form)
        {
            if (Permisos.Verificar(idPermiso))
            {
                this.Cursor = Cursors.WaitCursor;
                CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(this, form);
                form.Show();
                if (form.WindowState == FormWindowState.Minimized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                form.Focus();
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

    }
}
