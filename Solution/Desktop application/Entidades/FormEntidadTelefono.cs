using System;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidadTelefono : Form
    {

        #region Declarations

        private CSGestionContext context = new CSGestionContext(true);
        private EntidadTelefono entidadTelefono;

        private bool isLoading = false;
        private bool isNew = false;
        private bool isEditMode = false;

        #endregion

        #region Form stuff

        public FormEntidadTelefono()
        {
            InitializeComponent();
        }

        internal void LoadAndShow(bool editMode, Form parentForm, int idEntidad, byte idTelefono)
        {
            isLoading = true;
            isNew = (idTelefono == 0);
            isEditMode = editMode;

            if (idTelefono == 0)
            {
                entidadTelefono = new EntidadTelefono();
                entidadTelefono.IdEntidad = idEntidad;
                entidadTelefono.EsActivo = true;
                entidadTelefono.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                entidadTelefono.FechaHoraCreacion = DateTime.Now;
                entidadTelefono.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadTelefono.FechaHoraModificacion = entidadTelefono.FechaHoraCreacion;

                context.EntidadTelefono.Add(entidadTelefono);
            }
            else
            {
                entidadTelefono = context.EntidadTelefono.Find(idEntidad, idTelefono);
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
            comboboxTipo.Enabled = isEditMode;
            textboxTipoOtro.ReadOnly = !isEditMode;
            textboxNumero.ReadOnly = !isEditMode;

            // Notas y Auditoría
            textboxNotas.ReadOnly = !isEditMode;
            checkboxEsActivo.Enabled = isEditMode;
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();

            ListasComunes.TelefonoTipo(comboboxTipo, context, false);
        }

        private void SetAppearance()
        { 

        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            entidadTelefono = null;
            this.Dispose();
        }

        #endregion

        #region Load and Set Data

        private void SetDataFromObjectToControls()
        {
            // General
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxTipo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidadTelefono.IdTelefonoTipo, CardonerSistemas.Constants.ByteFieldValueNotSpecified);
            if (entidadTelefono.IdTelefonoTipo == CardonerSistemas.Constants.ByteFieldValueOther)
            {
                textboxTipoOtro.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadTelefono.TipoOtro);
            }
            else
            {
                textboxTipoOtro.Text = string.Empty;
            }
            textboxNumero.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadTelefono.Numero);

            // Notas y Auditoría
            textboxNotas.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadTelefono.Notas);
            checkboxEsActivo.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidadTelefono.EsActivo);
            textboxId.Text = entidadTelefono.IdTelefonoFormatted;
            textboxFechaHoraCreacion.Text = entidadTelefono.FechaHoraCreacionFormatted;
            textboxUsuarioCreacion.Text = entidadTelefono.UsuarioCreacionFormatted;
            textboxFechaHoraModificacion.Text = entidadTelefono.FechaHoraModificacionFormatted;
            textboxUsuarioModificacion.Text = entidadTelefono.UsuarioModificacionFormatted;
        }

        private void SetDataFromControlsToObject()
        {
            // General
            entidadTelefono.IdTelefonoTipo = CardonerSistemas.ControlValueTranslation.ComboBoxToByte(comboboxTipo.SelectedValue).Value;
            if (Convert.ToByte(comboboxTipo.SelectedValue) == CardonerSistemas.Constants.ByteFieldValueOther)
            {
                entidadTelefono.TipoOtro = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxTipoOtro.Text);
            }
            else
            {
                entidadTelefono.TipoOtro = null;
            }
            entidadTelefono.Numero = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNumero.Text);

            // Notas y Auditoría
            entidadTelefono.Notas = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNotas.Text);
            entidadTelefono.EsActivo = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxEsActivo.CheckState).Value;
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
                        if (this.ActiveControl != textboxNotas)
                        {
                            buttonGuardar.PerformClick();
                        }
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

        private void Tipo_Cambio(object sender, EventArgs e)
        {
            if (comboboxTipo.SelectedValue == null)
            {
                textboxTipoOtro.Visible = false;
            }
            else
            {
                textboxTipoOtro.Visible = ((byte)comboboxTipo.SelectedValue == CardonerSistemas.Constants.ByteFieldValueOther);
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
            if (Permisos.Verificar(Permisos.EntidadTelefonoEditar))
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
            if (comboboxTipo.SelectedValue == null)
            {
                tabMain.SelectedTab = tabpageGeneral;
                MessageBox.Show("Debe especificar el Tipo de Teléfono.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboboxTipo.Focus();
                return;
            }
            if (textboxNumero.Text.Trim().Length == 0)
            {
                tabMain.SelectedTab = tabpageGeneral;
                MessageBox.Show("Debe especificar el Número de Teléfono.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxNumero.Focus();
                return;
            }

            // Calculo el nuevo Id
            if (isNew)
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    Entidad entidad = context.Entidad.Find(entidadTelefono.IdEntidad);
                    if (entidad.EntidadTelefono.Any())
                    {
                        entidadTelefono.IdTelefono = (byte)(entidad.EntidadTelefono.Max(ed => ed.IdTelefono) + 1);
                    }
                    else
                    {
                        entidadTelefono.IdTelefono = 1;
                    }
                }
            }

            // Paso los datos desde los controles al Objecto de EF
            SetDataFromControlsToObject();

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;

                entidadTelefono.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadTelefono.FechaHoraModificacion = DateTime.Now;

                try
                {
                    context.SaveChanges();

                    FormEntidad entidad = (FormEntidad)CardonerSistemas.Forms.MdiChildGetInstance(Program.FormMdi, "FormEntidad");
                    if (entidad != null)
                    {
                        entidad.TelefonosRefreshData(entidadTelefono.IdTelefono);
                        entidad = null;
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                {
                    this.Cursor = Cursors.Default;

                    switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                    {
                        case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity:
                            MessageBox.Show("No se puede agregar el Telefono porque ya existe uno igual.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
