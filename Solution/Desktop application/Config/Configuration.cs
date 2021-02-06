using System.Windows.Forms;

namespace CS_Gestion
{
    static class Configuration
    {
        private const string ConfigSubFolder = "Config";

        private const string AppearanceFileName = "Appearance.config";
        private const string DatabaseFileName = "Database.config";
        private const string EmailFileName = "Email.config";
        private const string GeneralFileName = "General.config";

        static internal bool LoadFiles()
        {
            string ConfigFolder;

            if (Application.ExecutablePath.EndsWith(@"\"))
            {
                ConfigFolder = Application.StartupPath + ConfigSubFolder + @"\";
            }
            else
            {
                ConfigFolder = Application.StartupPath + @"\" + ConfigSubFolder + @"\";
            }

            if (!CardonerSistemas.ConfigurationXml.LoadFile(ConfigFolder, AppearanceFileName, ref Program.appearanceConfig))
            {
                return false;
            }
            if (!CardonerSistemas.ConfigurationXml.LoadFile(ConfigFolder, DatabaseFileName, ref Program.databaseConfig))
            {
                return false;
            }
            if (!CardonerSistemas.ConfigurationXml.LoadFile(ConfigFolder, EmailFileName, ref Program.emailConfig))
            {
                return false;
            }
            if (!CardonerSistemas.ConfigurationXml.LoadFile(ConfigFolder, GeneralFileName, ref Program.generalConfig))
            {
                return false;
            }

            return true;
        }

    }
}