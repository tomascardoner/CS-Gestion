using System;
using System.Windows.Forms;

namespace CS_Gestion
{
    static class Program
    {
        static private formMdi pFormMdi;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DateTime startupDateTime;

            Cursor.Current = Cursors.AppStarting;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Tomo el tiempo de inicio para controlar los segundos mínimos que se debe mostrar el Splash Screen
            startupDateTime = DateTime.Now;

            // Muestro el form MDI principal
            pFormMdi = new formMdi();
            pFormMdi.Show();

            Application.DoEvents();

            // Está todo listo. Cambio el puntero del mouse a modo normal y habilito el form MDI principal
            pFormMdi.Cursor = Cursors.Default;
            pFormMdi.Enabled = true;
            Cursor.Current = Cursors.Default;

            // Inicio el loop sobre el form MDI principal
            Application.Run(pFormMdi);
        }

        static public void TerminateApplication()
        {
            if (pFormMdi != null)
            {
                foreach (Form form in pFormMdi.MdiChildren)
                {
                    form.Close();
                    form.Dispose();
                }
            }
            // pDatabase = Nothing
            // pFillAndRefreshLists = Nothing
            // pPermisos = Nothing
            // pParametros = Nothing
            // pLicensedTo = Nothing
            // pUsuario = Nothing
        }
    }
}
