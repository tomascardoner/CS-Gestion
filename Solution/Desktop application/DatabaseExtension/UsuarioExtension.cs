using System.Linq;

namespace CS_Gestion
{
    public partial class Usuario
    {
        internal bool Login()
        {
            try
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    Program.Permisos = context.UsuarioGrupoPermiso.Where(ugp => ugp.IdUsuarioGrupo == IdUsuarioGrupo).ToList();
                }
            }
            catch (System.Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al cargar los Permisos y Parámetros del Usuario.");
                return false;
            }

            SetLoginInformation();

            return true;
        }

        private void SetLoginInformation()
        {
            Program.FormMdi.menuitemDebug.Visible = (IdUsuario == 1);

            switch (Genero)
            {
                case CS_Gestion.Constantes.PersonaGeneroMasculino:
                    Program.FormMdi.labelUsuarioNombre.Image = Properties.Resources.ImageHombre16;
                    break;
                case CS_Gestion.Constantes.PersonaGeneroFemenino:
                    Program.FormMdi.labelUsuarioNombre.Image = Properties.Resources.ImageMujer16;
                    break;
                default:
                    Program.FormMdi.labelUsuarioNombre.Image = null;
                    break;
            }

            Program.FormMdi.labelUsuarioNombre.Text = Descripcion;

            Program.EventLog.WriteEntry(string.Format("El Usuario '{0}' ha iniciado sesión.", Nombre), System.Diagnostics.EventLogEntryType.SuccessAudit, Constantes.EventUserLoginSuccess );
        }
    }
}
