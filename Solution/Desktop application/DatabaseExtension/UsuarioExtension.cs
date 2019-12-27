
namespace CS_Gestion
{
    public partial class Usuario
    {
        public void LoggedIn()
        {

            // LoadUsuarioPermisosAndParametros()

            Program.FormMdi.menuitemDebug.Visible = (Program.Usuario.IdUsuario == 1);

            switch (Program.Usuario.Genero)
            {
                case CS_Gestion.Constantes.PersonaGeneroMasculino:
                    Program.FormMdi.labelUsuarioNombre.Image = Properties.Resources.IMAGE_USUARIO_HOMBRE_16;
                    break;
                case CS_Gestion.Constantes.PersonaGeneroFemenino:
                    Program.FormMdi.labelUsuarioNombre.Image = Properties.Resources.IMAGE_USUARIO_MUJER_16;
                    break;
                default:
                    Program.FormMdi.labelUsuarioNombre.Image = null;
                    break;
            }

            Program.FormMdi.labelUsuarioNombre.Text = Program.Usuario.Descripcion;

            Program.EventLog.WriteEntry(string.Format("El Usuario '{0}' ha iniciado sesión.", Program.Usuario.Nombre), System.Diagnostics.EventLogEntryType.SuccessAudit, Constantes.EventUserLoginSuccess );

        }
    }
}
