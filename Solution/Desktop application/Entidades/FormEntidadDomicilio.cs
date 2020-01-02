using System;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidadDomicilio : Form
    {

        #region Declarations

        private CSGestionContext context = new CSGestionContext(true);
        private EntidadDomicilio entidadDomicilio;

        private bool isLoading = false;
        private bool isNew = false;
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
            isNew = (idDomicilio == 0);
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

                context.EntidadDomicilio.Add(entidadDomicilio);
            }
            else
            {
                entidadDomicilio = context.EntidadDomicilio.Find(idEntidad, idDomicilio);
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
            textboxCalle1.ReadOnly = !isEditMode;
            textboxNumero.ReadOnly = !isEditMode;
            textboxPiso.ReadOnly = !isEditMode;
            textboxDepartamento.ReadOnly = !isEditMode;
            textboxCalle2.ReadOnly = !isEditMode;
            textboxCalle3.ReadOnly = !isEditMode;
            comboboxProvincia.Enabled = isEditMode;
            comboboxLocalidad.Enabled = isEditMode;
            textboxCodigoPostal.ReadOnly = !isEditMode;

            // Notas y Auditoría
            textboxNotas.ReadOnly = !isEditMode;
            checkboxEsActivo.Enabled = isEditMode;
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();

            ListasComunes.DomicilioTipo(comboboxTipo, context, false);
            ListasComunes.Provincia(comboboxProvincia, context, true);
        }

        private void SetAppearance()
        { 

        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            entidadDomicilio = null;
            this.Dispose();
        }

        #endregion

        #region Load and Set Data

        private void SetDataFromObjectToControls()
        {
            // General
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxTipo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidadDomicilio.IdDomicilioTipo, CardonerSistemas.Constants.ByteFieldValueNotSpecified);
            if (entidadDomicilio.IdDomicilioTipo == CardonerSistemas.Constants.ByteFieldValueOther)
            {
                textboxTipoOtro.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.TipoOtro);
            }
            else
            {
                textboxTipoOtro.Text = string.Empty;
            }
            textboxCalle1.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.Calle1);
            textboxNumero.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.Numero);
            textboxPiso.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.Piso);
            textboxDepartamento.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.Departamento);
            textboxCalle2.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.Calle2);
            textboxCalle3.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.Calle3);
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxProvincia, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidadDomicilio.IdProvincia, CardonerSistemas.Constants.ByteFieldValueNotSpecified);
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidadDomicilio.IdLocalidad, CardonerSistemas.Constants.ShortFieldValueNotSpecified);
            if (!isNew)
            {
                textboxCodigoPostal.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.CodigoPostal);
            }

            // Notas y Auditoría
            textboxNotas.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadDomicilio.Notas);
            checkboxEsActivo.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidadDomicilio.EsActivo);
            textboxId.Text = entidadDomicilio.IdDomicilioFormatted;
            textboxFechaHoraCreacion.Text = entidadDomicilio.FechaHoraCreacionFormatted;
            textboxUsuarioCreacion.Text = entidadDomicilio.UsuarioCreacionFormatted;
            textboxFechaHoraModificacion.Text = entidadDomicilio.FechaHoraModificacionFormatted;
            textboxUsuarioModificacion.Text = entidadDomicilio.UsuarioModificacionFormatted;
        }

        private void SetDataFromControlsToObject()
        {
            // General
            entidadDomicilio.IdDomicilioTipo = CardonerSistemas.ControlValueTranslation.ComboBoxToByte(comboboxTipo.SelectedValue).Value;
            if (Convert.ToByte(comboboxTipo.SelectedValue) == CardonerSistemas.Constants.ByteFieldValueOther)
            {
                entidadDomicilio.TipoOtro = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxTipoOtro.Text);
            }
            else
            {
                entidadDomicilio.TipoOtro = null;
            }
            entidadDomicilio.Calle1 = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxCalle1.Text);
            entidadDomicilio.Numero = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNumero.Text);
            entidadDomicilio.Piso = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxPiso.Text);
            entidadDomicilio.Departamento = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxDepartamento.Text);
            entidadDomicilio.Calle2 = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxCalle2.Text);
            entidadDomicilio.Calle3 = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxCalle3.Text);
            entidadDomicilio.IdProvincia = CardonerSistemas.ControlValueTranslation.ComboBoxToByte(comboboxProvincia.SelectedValue, CardonerSistemas.Constants.ByteFieldValueNotSpecified);
            entidadDomicilio.IdLocalidad = CardonerSistemas.ControlValueTranslation.ComboBoxToShort(comboboxLocalidad.SelectedValue, CardonerSistemas.Constants.ShortFieldValueNotSpecified);
            entidadDomicilio.CodigoPostal = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxCodigoPostal.Text);

            // Notas y Auditoría
            entidadDomicilio.Notas = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNotas.Text);
            entidadDomicilio.EsActivo = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxEsActivo.CheckState).Value;
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

        private void Provincia_Cambio(object sender, EventArgs e)
        {
            if (comboboxProvincia.SelectedValue == null)
            {
                ListasComunes.Localidad(comboboxLocalidad, context, 0, true);
                comboboxLocalidad.SelectedIndex = 0;
            }
            else
            {
                ListasComunes.Localidad(comboboxLocalidad, context, (byte)comboboxProvincia.SelectedValue, true);
                if ((byte)comboboxProvincia.SelectedValue == Parametros.GetIntegerAsByte(Parametros.DefaultProvinciaId))
                {
                    CardonerSistemas.ComboBox.SetSelectedValue(comboboxLocalidad, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, Parametros.GetIntegerAsShort(Parametros.DefaultLocalidadId));
                }
            }

        }

        private void Localidad_Cambio(object sender, EventArgs e)
        {
            if (comboboxLocalidad.SelectedValue != null)
            {
                if (((Localidad)comboboxLocalidad.SelectedItem).CodigoPostal != null)
                {
                    textboxCodigoPostal.Text = ((Localidad)comboboxLocalidad.SelectedItem).CodigoPostal;
                }
            }
        }

        #endregion

        #region Main toolbar

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadDomicilioEditar))
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
                MessageBox.Show("Debe especificar el Tipo de domicilio.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboboxTipo.Focus();
                return;
            }
            if (textboxCalle1.Text.Trim().Length == 0)
            {
                tabMain.SelectedTab = tabpageGeneral;
                MessageBox.Show("Debe especificar la Calle 1.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxCalle1.Focus();
                return;
            }

            // Calculo el nuevo Id
            if (isNew)
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    Entidad entidad = context.Entidad.Find(entidadDomicilio.IdEntidad);
                    if (entidad.EntidadDomicilio.Any())
                    {
                        entidadDomicilio.IdDomicilio = (byte)(entidad.EntidadDomicilio.Max(ed => ed.IdDomicilio) + 1);
                    }
                    else
                    {
                        entidadDomicilio.IdDomicilio = 1;
                    }
                }
            }

            // Paso los datos desde los controles al Objecto de EF
            SetDataFromControlsToObject();

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;

                entidadDomicilio.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadDomicilio.FechaHoraModificacion = DateTime.Now;

                try
                {
                    context.SaveChanges();

                    FormEntidad entidad = (FormEntidad)CardonerSistemas.Forms.MdiChildGetInstance(Program.FormMdi, "FormEntidad");
                    if (entidad != null)
                    {
                        entidad.DomiciliosRefreshData(entidadDomicilio.IdDomicilio);
                        entidad = null;
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                {
                    this.Cursor = Cursors.Default;

                    switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                    {
                        case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity:
                            MessageBox.Show("No se puede agregar el Domicilio porque ya existe uno igual.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
