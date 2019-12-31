using System;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidadDomicilio : Form
    {

        #region Declarations

        private CSGestionContext context = new CSGestionContext(true);
        private EntidadDomicilio entidadDomicilio;

        private bool isLoading = false;
        private bool isEditMode = false;

        #endregion

        #region Form stuff

        public FormEntidadDomicilio()
        {
            InitializeComponent();
        }

        internal void LoadAndShow(bool editMode, Form parentForm, int idEntidad, byte idDomicilio)
        {
            isLoading = true;
            isEditMode = editMode;

            if (idDomicilio == 0)
            {
                entidadDomicilio = new EntidadDomicilio();
                entidadDomicilio.IdEntidad = idEntidad;
                entidadDomicilio.IdProvincia = Parametros.GetIntegerAsByte(Parametros.DefaultProvinciaId);
                entidadDomicilio.IdLocalidad = Parametros.GetIntegerAsShort(Parametros.DefaultLocalidadId);
                entidadDomicilio.CodigoPostal = Parametros.GetString(Parametros.DefaultCodigoPostal);
                entidadDomicilio.EsActivo = true;
                entidadDomicilio.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                entidadDomicilio.FechaHoraCreacion = DateTime.Now;
                entidadDomicilio.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadDomicilio.FechaHoraModificacion = entidadDomicilio.FechaHoraCreacion;
            }
            else
            {
                entidadDomicilio = context.EntidadDomicilio.Find(idEntidad, idDomicilio);
            }

            CardonerSistemas.Forms.CenterToParent(parentForm, this);
            InitializeFormAndControls();
            SetDataFromObjectToControls();

            isLoading = false;

            ChangeMode();

            this.ShowDialog(parentForm);
        }

        #endregion

    }
}
