using System;
using System.Drawing;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class formMdi : Form
    {

        #region Declarations

        private Size formMdiClientSize;

        #endregion

        #region Form stuff

        public formMdi()
        {
            InitializeComponent();
            SetAppearance();
        }

        private void SetAppearance()
        {
            // Cambio el puntero del mouse para indicar que la aplicación está iniciando
            this.Cursor = Cursors.AppStarting;

            // Deshabilito el Form hasta que se cierre el SplashScreen
            this.Enabled = false;

            // Título del form
            this.Text = CardonerSistemas.My.Application.Info.Title;

            menuitemAyudaAcercaDe.Text = "&Acerca de " + CardonerSistemas.My.Application.Info.Title + "...";

            this.Icon = Properties.Resources.ICON_APPLICATION_32;

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

        private void groupviewEntidades_GroupViewItemSelected(object sender, EventArgs e)
        {
            Syncfusion.Windows.Forms.Tools.GroupViewItem groupViewItem = (Syncfusion.Windows.Forms.Tools.GroupViewItem)sender;
            if (groupViewItem.Text == "Entidades")
            {

            }
        }
    }
}
