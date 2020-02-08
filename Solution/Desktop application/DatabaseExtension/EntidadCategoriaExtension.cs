namespace CS_Gestion
{
    public partial class EntidadCategoria
    {
        internal string IdEntidadCategoriaFormatted
        {
            get
            {
                if (IdEntidadCategoria == 0)
                {
                    return Properties.Resources.StringItemNewMale;
                }
                else
                {
                    return IdEntidadCategoria.ToString(CardonerSistemas.Constants.FormatStringToNumberInteger);
                }
            }
        }

        internal string FechaHoraCreacionFormatted
        {
            get
            {
                return string.Format("{0} {1}", FechaHoraCreacion.ToShortDateString(), FechaHoraCreacion.ToShortTimeString());
            }
        }

        internal string UsuarioCreacionFormatted
        {
            get
            {
                if (UsuarioCreacion == null)
                {
                    return string.Empty;
                }
                else
                {
                    return UsuarioCreacion.Descripcion;
                }
            }
        }

        internal string FechaHoraModificacionFormatted
        {
            get
            {
                return string.Format("{0} {1}", FechaHoraModificacion.ToShortDateString(), FechaHoraModificacion.ToShortTimeString());
            }
        }

        internal string UsuarioModificacionFormatted
        {
            get
            {
                if (UsuarioModificacion == null)
                {
                    return string.Empty;
                }
                else
                {
                    return UsuarioModificacion.Descripcion;
                }
            }
        }

    }
}
