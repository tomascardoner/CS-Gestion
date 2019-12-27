using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CS_Gestion
{
    static class Program
    {
        static public EventLog eventLog = new EventLog("Application");

        static public CardonerSistemas.Database.ADO.SQLServer pDatabase;
        //FillAndRefreshLists pFillAndRefreshLists;

        static public formMdi pFormMdi;
        //pPermisos As List(Of UsuarioGrupoPermiso)
        static public List<Parametro> pParametros;
        static public Usuario pUsuario;
        //pUsuarioParametros As List(Of UsuarioParametro)
        static public string pLicensedTo;

        [STAThread]
        static void Main()
        {
            DateTime startupDateTime;

            Cursor.Current = Cursors.AppStarting;

            eventLog.Source = "Application";
            eventLog.WriteEntry("La Aplicación se está iniciando.", EventLogEntryType.Information);

            // Verifico si ya hay una instancia ejecutandose, si permite iniciar otra, o de lo contrario, muestro la instancia original
            if (Properties.Settings.Default.SingleInstanceApplication)
            {
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Muestro el SplashScreen y cambio el puntero del mouse para indicar que la aplicación está iniciando.
            formSplash formSplashI = new formSplash();
            formSplashI.Show();
            formSplashI.Cursor = Cursors.AppStarting;
            formSplashI.labelStatus.Text = "Obteniendo los parámetros de conexión a la Base de datos...";
            Application.DoEvents();

            // Obtengo el Connection String para las conexiones de ADO .NET
            pDatabase = new CardonerSistemas.Database.ADO.SQLServer();
            pDatabase.ApplicationName = CardonerSistemas.My.Application.Info.Title;
            pDatabase.Datasource = Properties.Settings.Default.DatabaseConnectionDatasource;
            pDatabase.InitialCatalog = Properties.Settings.Default.DatabaseConnectionDatabase;
            pDatabase.UserID = Properties.Settings.Default.DatabaseConnectionUserID;
            // Desencripto la contraseña de la conexión a la base de datos que está en el archivo app.config
            CardonerSistemas.Encrypt.TripleDES passwordDecrypter = new CardonerSistemas.Encrypt.TripleDES(CardonerSistemas.Constants.PublicEncryptionPassword);
            string unencryptedPassword = "";
            if (!passwordDecrypter.Decrypt(Properties.Settings.Default.DatabaseConnectionPassword, ref unencryptedPassword))
            {
                MessageBox.Show("La contraseña encriptada de conexión a la base de datos, es incorrecta.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordDecrypter = null;
                formSplashI.Close();
                formSplashI.Dispose();
                TerminateApplication();
                return;
            }
            pDatabase.Password = unencryptedPassword;
            unencryptedPassword = null;
            passwordDecrypter = null;
            pDatabase.MultipleActiveResultsets = true;
            pDatabase.WorkstationID = Environment.MachineName;
            pDatabase.CreateConnectionString();

            // Obtengo el Connection String para las conexiones de Entity Framework
            CSGestionContext.ConnectionString = CardonerSistemas.Database.EntityFramework.CreateConnectionString(Properties.Settings.Default.DatabaseConnectionProvider, pDatabase.ConnectionString, "DatabaseModel");

            // Cargos los Parámetros desde la Base de datos
            formSplashI.labelStatus.Text = "Cargando los parámetros desde la Base de datos...";
            Application.DoEvents();
            if (!Parametros.CargarTodos())
            {
                formSplashI.Close();
                formSplashI.Dispose();
                TerminateApplication();
                return;
            }

            // Verifico que la Base de Datos corresponda a esta Aplicación a través del GUID guardado en los Parámetros
            if (Parametros.GetString(Parametros.ApplicationDatabaseGuid) != Constantes.ApplicationDatabaseGuid)
            {
                MessageBox.Show("La Base de Datos especificada no corresponde a esta aplicación.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                formSplashI.Close();
                formSplashI.Dispose();
                TerminateApplication();
                return;
            }

            // Muestro el Nombre de la Compañía a la que está licenciada la Aplicación
            CardonerSistemas.Encrypt.TripleDES licenseDecrypter = new CardonerSistemas.Encrypt.TripleDES(Constantes.ApplicationLicensePassword);
            if (!licenseDecrypter.Decrypt(Parametros.GetString(Parametros.LicenseCompanyName, "EMPTY"), ref pLicensedTo))
            {
                MessageBox.Show("La Licencia especificada es incorrecta.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                licenseDecrypter = null;
                formSplashI.Close();
                formSplashI.Dispose();
                TerminateApplication();
                return;
            }
            licenseDecrypter = null;
            formSplashI.labelLicensedTo.Text = pLicensedTo;
            Application.DoEvents();

            // Preparo instancia de clase para llenar los ComboBox
            //pFillAndRefreshLists = New FillAndRefreshLists

            // Tomo el tiempo de inicio para controlar los segundos mínimos que se debe mostrar el Splash Screen
            startupDateTime = DateTime.Now;

            // Muestro el form MDI principal
            pFormMdi = new formMdi();
            pFormMdi.Show();

            formSplashI.labelStatus.Text = "Todo completado.";
            Application.DoEvents();

            // Espero el tiempo mínimo para mostrar el Splash Screen y después lo cierro
            if (!CardonerSistemas.Instance.IsRunningUnderIDE())
            {
                while (DateTime.Now.Subtract(startupDateTime).Seconds < Properties.Settings.Default.SplashScreenMinimumDisplaySeconds)
                {
                    Application.DoEvents();
                }
            }
            formSplashI.Close();
            formSplashI.Dispose();

            //If CS_Instance.IsRunningUnderIDE Then
            //    ' Como se está ejecutando dentro del IDE de Visual Studio, en lugar de pedir Usuario y contraseña, asumo que es el Administrador
            //    Using dbcontext As New CSBomberosContext(True)
            //        pUsuario = dbcontext.Usuario.Find(1)
            //        MiscFunctions.UserLoggedIn()
            //    End Using
            //Else
            //    If Not formLogin.ShowDialog(pFormMDIMain) = DialogResult.OK Then
            //        Application.Exit()
            //        eventLog.WriteEntry("La Aplicación ha finalizado porque el Usuario no ha iniciado sesión.", TraceEventType.Warning);
            //        Exit Sub
            //    End If
            //    formLogin.Close()
            //    formLogin.Dispose()
            //End If

            // Está todo listo. Cambio el puntero del mouse a modo normal y habilito el form MDI principal
            pFormMdi.Cursor = Cursors.Default;
            pFormMdi.Enabled = true;
            Cursor.Current = Cursors.Default;

            // Inicio el loop sobre el form MDI principal
            //eventLog.WriteEntry("La Aplicación se ha iniciado correctamente.", TraceEventType.Information)
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
            pDatabase = null;
            // pFillAndRefreshLists = Nothing
            // pPermisos = Nothing
            pParametros = null;
            pLicensedTo = null;
            pUsuario = null;
            eventLog.Close();
            eventLog = null;
        }
    }
}
