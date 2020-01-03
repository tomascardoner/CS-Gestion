﻿using System.Windows.Forms;

namespace CS_Gestion
{
    static class Permisos
    {
        internal const string Entidad = "Entidad";
        internal const string EntidadAgregar = "EntidadAgregar";
        internal const string EntidadEditar = "EntidadEditar";
        internal const string EntidadBorrar = "EntidadBorrar";

        internal const string EntidadDomicilio = "EntidadDomicilio";
        internal const string EntidadDomicilioAgregar = "EntidadDomicilioAgregar";
        internal const string EntidadDomicilioEditar = "EntidadDomicilioEditar";
        internal const string EntidadDomicilioBorrar = "EntidadDomicilioBorrar";

        internal const string EntidadEmail = "EntidadEmail";
        internal const string EntidadEmailAgregar = "EntidadEmailAgregar";
        internal const string EntidadEmailEditar = "EntidadEmailEditar";
        internal const string EntidadEmailBorrar = "EntidadEmailBorrar";

        internal static bool Verificar(string idPermiso, bool mostrarAviso = true)
        {
            if (Program.Usuario.IdUsuarioGrupo == Constantes.IdUsuarioGrupoAdministradores)
            {
                return true;
            }
            else
            {
                if (Program.Permisos.Find(ugp => ugp.IdUsuarioGrupo == Program.Usuario.IdUsuarioGrupo && ugp.IdPermiso.TrimEnd() == idPermiso) == null)
                {
                    if (mostrarAviso)
                    {
                        MessageBox.Show("No tiene autorización para realizar esta acción.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
