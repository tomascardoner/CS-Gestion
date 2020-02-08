using System;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidadCategoria : Form
    {

        #region Declarations

        private CSGestionContext context = new CSGestionContext(true);
        private EntidadCategoria entidadCategoria;

        private bool isLoading = false;
        private bool isNew = false;
        private bool isEditMode = false;

        #endregion

        #region Form stuff

        public FormEntidadCategoria()
        {
            InitializeComponent();
        }

        internal void LoadAndShow(bool editMode, Form parentForm, short idEntidadCategoria)
        {
            isLoading = true;
            isNew = (idEntidadCategoria == 0);
            isEditMode = editMode;

            if (isNew)
            {
                entidadCategoria = new EntidadCategoria();
                entidadCategoria.EsActivo = true;
                entidadCategoria.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                entidadCategoria.FechaHoraCreacion = DateTime.Now;
                entidadCategoria.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadCategoria.FechaHoraModificacion = entidadCategoria.FechaHoraCreacion;

                context.EntidadCategoria.Add(entidadCategoria);
            }
            else
            {
                entidadCategoria = context.EntidadCategoria.Find(idEntidadCategoria);
            }

            CardonerSistemas.Forms.CenterToParent(parentForm, this);
            InitializeFormAndControls();
            SetDataFromObjectToControls();

            isLoading = false;

            ChangeEditMode();

            this.ShowDialog(parentForm);
        }

        private void ChangeEditMode()
        {
            buttonGuardar.Visible = isEditMode;
            buttonCancelar.Visible = isEditMode;
            buttonEditar.Visible = !isEditMode;
            buttonCerrar.Visible = !isEditMode;

            // General
            textboxNombre.ReadOnly = !isEditMode;

            // Notas y Auditoría
            checkboxEsActivo.Enabled = isEditMode;
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();
        }

        private void SetAppearance()
        { 

        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            entidadCategoria = null;
            this.Dispose();
        }

        #endregion

        #region Load and Set Data

        private void SetDataFromObjectToControls()
        {
            // General
            textboxNombre.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadCategoria.Nombre);

            // Notas y Auditoría
            checkboxEsActivo.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidadCategoria.EsActivo);
            textboxId.Text = entidadCategoria.IdEntidadCategoriaFormatted;
            textboxFechaHoraCreacion.Text = entidadCategoria.FechaHoraCreacionFormatted;
            textboxUsuarioCreacion.Text = entidadCategoria.UsuarioCreacionFormatted;
            textboxFechaHoraModificacion.Text = entidadCategoria.FechaHoraModificacionFormatted;
            textboxUsuarioModificacion.Text = entidadCategoria.UsuarioModificacionFormatted;
        }

        private void SetDataFromControlsToObject()
        {
            // General
            entidadCategoria.Nombre = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNombre.Text);

            // Notas y Auditoría
            entidadCategoria.EsActivo = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxEsActivo.CheckState).Value;
        }

        #endregion

        #region Controls behavior

        private void this_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Return:
                    if (isEditMode)
                    {
                        buttonGuardar.PerformClick();
                    }
                    else
                    {
                        buttonCerrar.PerformClick();
                    }
                    break;
                case (char)Keys.Escape:
                    if (isEditMode)
                    {
                        buttonCancelar.PerformClick();
                    }
                    else
                    {
                        buttonCerrar.PerformClick();
                    }
                    break;
                default:
                    break;
            }
        }

        private void TextBoxs_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        #endregion

        #region Main toolbar

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadCategoriaEditar))
            {
                isEditMode = true;
                ChangeEditMode();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            if (context.ChangeTracker.HasChanges())
            {
                if (MessageBox.Show(string.Format("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán.{0}{0}¿Confirma la pérdida de los cambios?", System.Environment.NewLine), CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            // Calculo el nuevo Id
            if (isNew)
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    if (context.EntidadCategoria.Any())
                    {
                        entidadCategoria.IdEntidadCategoria = (short)((from ec in context.EntidadCategoria select ec.IdEntidadCategoria).Max() + 1);
                    }
                    else
                    {
                        entidadCategoria.IdEntidadCategoria = 1;
                    }
                }
            }

            // Paso los datos desde los controles al Objecto de EF
            SetDataFromControlsToObject();

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;

                entidadCategoria.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadCategoria.FechaHoraModificacion = DateTime.Now;

                try
                {
                    context.SaveChanges();

                    FormEntidadCategorias entidadCategorias = (FormEntidadCategorias)CardonerSistemas.Forms.GetInstance("FormEntidadCategorias");
                    if (entidadCategorias != null)
                    {
                        entidadCategorias.RefreshData(entidadCategoria.IdEntidadCategoria);
                        entidadCategorias = null;
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                {
                    this.Cursor = Cursors.Default;

                    switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                    {
                        case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity:
                            MessageBox.Show("No se puede agregar la Categoría de Entidad porque ya existe una con el mismo nombre.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case CardonerSistemas.Database.EntityFramework.Errors.Unknown:
                            CardonerSistemas.Error.ProcessError((Exception)dbuex, Properties.Resources.StringErrorSavingChanges);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    CardonerSistemas.Error.ProcessError(ex, Properties.Resources.StringErrorSavingChanges);
                    return;
                }

            }

            this.Close();

        }

        #endregion

    }
}
