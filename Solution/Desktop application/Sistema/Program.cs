using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CS_Gestion
{
    static class Program
    {
        static internal EventLog EventLog = new EventLog(Constantes.EventLogName);

        // Config files
        static internal AppearanceConfig appearanceConfig;
        static internal DatabaseConfig databaseConfig;
        static internal EmailConfig emailConfig;
        static internal GeneralConfig generalConfig;

        static internal CardonerSistemas.Database.ADO.SQLServer Database;
        static internal FormMdi FormMdi;
        static internal List<UsuarioGrupoPermiso> Permisos;
        static internal List<Parametro> Parametros;
        static internal Appearance Appearance;
        static internal Usuario Usuario;
        //pUsuarioParametros As List(Of UsuarioParametro)
        static internal string LicensedTo;

        [STAThread]
        static void Main()
        {
            DateTime startupDateTime;

            Cursor.Current = Cursors.AppStarting;

            // Inicializo el EventLog
            EventLog.Source = CardonerSistemas.My.Application.Info.Title;
            EventLog.WriteEntry("La Aplicación se está iniciando.", EventLogEntryType.Information, Constantes.EventApplicationStarting );

            // Cargo los archivos de configuración de la aplicación
            if (!Configuration.LoadFiles())
            {
                TerminateApplication();
                return;
            }

            // Verifico si ya hay una instancia ejecutandose, si permite iniciar otra, o de lo contrario, muestro la instancia original
            if (generalConfig.SingleInstanceApplication)
            {
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Muestro el SplashScreen y cambio el puntero del mouse para indicar que la aplicación está iniciando.
            FormSplash splash = new FormSplash();
            splash.Show();
            splash.Cursor = Cursors.AppStarting;
            splash.labelStatus.Text = "Obteniendo los parámetros de conexión a la Base de datos...";
            Application.DoEvents();

            // Obtengo el Connection String para las conexiones de ADO .NET
            Database = new CardonerSistemas.Database.ADO.SQLServer();
            Database.ApplicationName = CardonerSistemas.My.Application.Info.Title;
            Database.Datasource = databaseConfig.Datasource;
            Database.InitialCatalog = databaseConfig.Database;
            Database.UserId = databaseConfig.UserId;
            // Desencripto la contraseña de la conexión a la base de datos que está en el archivo app.config
            CardonerSistemas.Encrypt.TripleDES passwordDecrypter = new CardonerSistemas.Encrypt.TripleDES(CardonerSistemas.Constants.PublicEncryptionPassword);
            string unencryptedPassword = "";
            if (!passwordDecrypter.Decrypt(databaseConfig.Password, ref unencryptedPassword))
            {
                EventLog.WriteEntry("No se pudo desencriptar la contraseña de conexión a la base de datos.", EventLogEntryType.Error, Constantes.EventApplicationConfigurationError);
                splash.Focus();
                MessageBox.Show("No se pudo desencriptar la contraseña de conexión a la base de datos.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordDecrypter = null;
                splash.Close();
                splash.Dispose();
                TerminateApplication();
                return;
            }
            Database.Password = unencryptedPassword;
            unencryptedPassword = null;
            passwordDecrypter = null;
            Database.MultipleActiveResultsets = true;
            Database.WorkstationID = Environment.MachineName;
            Database.CreateConnectionString();

            // Obtengo el Connection String para las conexiones de Entity Framework
            CSGestionContext.ConnectionString = CardonerSistemas.Database.EntityFramework.CreateConnectionString(databaseConfig.Provider, Database.ConnectionString,  "DatabaseModel");

            // Cargos los Parámetros desde la Base de datos
            splash.Focus();
            splash.labelStatus.Text = "Cargando los parámetros desde la Base de datos...";
            Application.DoEvents();
            if (!CS_Gestion.Parametros.CargarTodos())
            {
                EventLog.WriteEntry("No se pudieron cargar los parámetros de la base de datos.", EventLogEntryType.Error, Constantes.EventApplicationConfigurationError);
                splash.Close();
                splash.Dispose();
                TerminateApplication();
                return;
            }

            // Verifico que la Base de Datos corresponda a esta Aplicación a través del GUID guardado en los Parámetros
            if (CS_Gestion.Parametros.GetString(CS_Gestion.Parametros.ApplicationDatabaseGuid) != Constantes.ApplicationDatabaseGuid)
            {
                EventLog.WriteEntry("La Base de Datos especificada no corresponde a esta aplicación.", EventLogEntryType.Error, Constantes.EventApplicationConfigurationError);
                splash.Focus();
                MessageBox.Show("La Base de Datos especificada no corresponde a esta aplicación.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                splash.Close();
                splash.Dispose();
                TerminateApplication();
                return;
            }

            // Muestro el Nombre de la Compañía a la que está licenciada la Aplicación
            CardonerSistemas.Encrypt.TripleDES licenseDecrypter = new CardonerSistemas.Encrypt.TripleDES(Constantes.ApplicationLicensePassword);
            if (!licenseDecrypter.Decrypt(CS_Gestion.Parametros.GetString(CS_Gestion.Parametros.LicenseCompanyName, "EMPTY"), ref LicensedTo))
            {
                EventLog.WriteEntry("La Aplicación ha finalizado porque la Licencia especificada es incorrecta.", EventLogEntryType.Error, Constantes.EventApplicationConfigurationError);
                splash.Focus();
                MessageBox.Show("La Licencia especificada es incorrecta.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                licenseDecrypter = null;
                splash.Close();
                splash.Dispose();
                TerminateApplication();
                return;
            }
            licenseDecrypter = null;
            splash.labelLicensedTo.Text = LicensedTo;
            splash.Focus();
            Application.DoEvents();

            // Preparo los parámetros que hacen a la apariencia
            Appearance = new Appearance();

            // Tomo el tiempo de inicio para controlar los segundos mínimos que se debe mostrar el Splash Screen
            startupDateTime = DateTime.Now;

            // Muestro el form MDI principal
            FormMdi = new FormMdi();
            FormMdi.Show();

            splash.labelStatus.Text = "Todo completado.";
            splash.Focus();
            Application.DoEvents();

            // Espero el tiempo mínimo para mostrar el Splash Screen y después lo cierro
            if (!CardonerSistemas.Instance.IsRunningUnderIde())
            {
                while (DateTime.Now.Subtract(startupDateTime).Seconds < appearanceConfig.MinimumSplashScreenDisplaySeconds)
                {
                    Application.DoEvents();
                }
            }
            splash.Close();
            splash.Dispose();

            if (CardonerSistemas.Instance.IsRunningUnderIde())
            {
                // Como se está ejecutando dentro del IDE de Visual Studio, en lugar de pedir Usuario y contraseña, asumo que es el Administrador
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    Usuario = context.Usuario.Find(1);
                    if (!Usuario.Login())
                    {
                        EventLog.WriteEntry("La Aplicación finalizará porque no se pudieron obtener los datos del Usuario.", EventLogEntryType.FailureAudit, Constantes.EventUserLoginFailure);
                        TerminateApplication();
                        return;
                    }
                }
            }
            else
            {
                FormLogin login = new FormLogin();
                if (login.ShowDialog(FormMdi) != DialogResult.OK)
                {
                    EventLog.WriteEntry("La Aplicación finalizará porque no se ha iniciado sesión.", EventLogEntryType.FailureAudit, Constantes.EventUserLoginFailure);
                    TerminateApplication();
                    return;
                }
                login.Close();
                login.Dispose();
            }

            // Está todo listo. Cambio el puntero del mouse a modo normal y habilito el form MDI principal
            FormMdi.Cursor = Cursors.Default;
            FormMdi.Enabled = true;
            Cursor.Current = Cursors.Default;

            // Inicio el loop sobre el form MDI principal
            EventLog.WriteEntry("La Aplicación se ha iniciado correctamente.", EventLogEntryType.Information, Constantes.EventApplicationStarted);
            Application.Run(FormMdi);
        }

        static public void TerminateApplication()
        {
            if (FormMdi != null)
            {
                CardonerSistemas.Forms.MdiChildCloseAll(FormMdi);
            }
            Database = null;
            Permisos = null;
            Parametros = null;
            LicensedTo = null;
            Appearance = null;
            Usuario = null;

            try
            {
                EventLog.WriteEntry("La Aplicación ha finalizado.", EventLogEntryType.Information, Constantes.EventApplicationEnded);
                EventLog.Close();
                EventLog = null;
            }
            catch (Exception)
            {
            }
        }
    }
}
