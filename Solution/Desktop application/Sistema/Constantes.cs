using System.Drawing;

namespace CS_Gestion
{
    static class Constantes
    {
        internal const string ApplicationDatabaseGuid = "{C4DA1C3B-24EB-41bc-B0F9-5F98F4D0835F}";

        // Hex Key - 128 bits
        internal const string ApplicationLicensePassword = "8a62a4359253fb51c88105b852bac2bb";

        // Appearance
        internal const string DefaultFontString = "Microsoft Sans Serif; 8,25pt";

        // Usuarios
        internal const byte IdUsuarioGrupoAdministradores = 1;

        // Persona
        internal const string PersonaGeneroNoEspecifica = "-";
        internal const string PersonaGeneroMasculino = "M";
        internal const string PersonaGeneroFemenino = "F";

        // Events
        internal const string EventLogName = "Application";
        internal const int EventApplicationStarting = 1;
        internal const int EventUserLoginSuccess = 2;
        internal const int EventUserLoginFailure = 3;
        internal const int EventApplicationStarted = 4;

        internal const int EventApplicationEnded = 1000;

        internal const int EventApplicationConfigurationError = 5000;
    }
}
