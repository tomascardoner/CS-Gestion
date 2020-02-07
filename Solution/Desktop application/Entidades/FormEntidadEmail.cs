using System;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidadEmail : Form
    {

        #region Declarations

        private CSGestionContext context = new CSGestionContext(true);
        private EntidadEmail entidadEmail;

        private bool isLoading = false;
        private bool isNew = false;
        private bool isEditMode = false;

        #endregion

        #region Form stuff

        public FormEntidadEmail()
        {
            InitializeComponent();
        }

        internal void LoadAndShow(bool editMode, Form parentForm, int idEntidad, byte idEmail)
        {
            isLoading = true;
            isNew = (idEmail == 0);
            isEditMode = editMode;

            if (idEmail == 0)
            {
                entidadEmail = new EntidadEmail();
                entidadEmail.IdEntidad = idEntidad;
                entidadEmail.EsActivo = true;
                entidadEmail.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                entidadEmail.FechaHoraCreacion = DateTime.Now;
                entidadEmail.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadEmail.FechaHoraModificacion = entidadEmail.FechaHoraCreacion;

                context.EntidadEmail.Add(entidadEmail);
            }
            else
            {
                entidadEmail = context.EntidadEmail.Find(idEntidad, idEmail);
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
            textboxEmail.ReadOnly = !isEditMode;
            textboxNombre.ReadOnly = !isEditMode;

            // Notas y Auditoría
            textboxNotas.ReadOnly = !isEditMode;
            checkboxEsActivo.Enabled = isEditMode;
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();

            ListasComunes.EmailTipo(comboboxTipo, context, false);
        }

        private void SetAppearance()
        { 

        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            entidadEmail = null;
            this.Dispose();
        }

        #endregion

        #region Load and Set Data

        private void SetDataFromObjectToControls()
        {
            // General
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxTipo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidadEmail.IdEmailTipo, CardonerSistemas.Constants.ByteFieldValueNotSpecified);
            if (entidadEmail.IdEmailTipo == CardonerSistemas.Constants.ByteFieldValueOther)
            {
                textboxTipoOtro.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadEmail.TipoOtro);
            }
            else
            {
                textboxTipoOtro.Text = string.Empty;
            }
            textboxEmail.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadEmail.Email);
            textboxNombre.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadEmail.Nombre);

            // Notas y Auditoría
            textboxNotas.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadEmail.Notas);
            checkboxEsActivo.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidadEmail.EsActivo);
            textboxId.Text = entidadEmail.IdEmailFormatted;
            textboxFechaHoraCreacion.Text = entidadEmail.FechaHoraCreacionFormatted;
            textboxUsuarioCreacion.Text = entidadEmail.UsuarioCreacionFormatted;
            textboxFechaHoraModificacion.Text = entidadEmail.FechaHoraModificacionFormatted;
            textboxUsuarioModificacion.Text = entidadEmail.UsuarioModificacionFormatted;
        }

        private void SetDataFromControlsToObject()
        {
            // General
            entidadEmail.IdEmailTipo = CardonerSistemas.ControlValueTranslation.ComboBoxToByte(comboboxTipo.SelectedValue).Value;
            if (Convert.ToByte(comboboxTipo.SelectedValue) == CardonerSistemas.Constants.ByteFieldValueOther)
            {
                entidadEmail.TipoOtro = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxTipoOtro.Text);
            }
            else
            {
                entidadEmail.TipoOtro = null;
            }
            entidadEmail.Email = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxEmail.Text);
            entidadEmail.Nombre = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNombre.Text);

            // Notas y Auditoría
            entidadEmail.Notas = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNotas.Text);
            entidadEmail.EsActivo = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxEsActivo.CheckState).Value;
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
            if (Permisos.Verificar(Permisos.EntidadEmailEditar))
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
                MessageBox.Show("Debe especificar el Tipo de e-mail.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboboxTipo.Focus();
                return;
            }
            if (textboxEmail.Text.Trim().Length == 0)
            {
                tabMain.SelectedTab = tabpageGeneral;
                MessageBox.Show("Debe especificar la dirección de e-mail.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textboxEmail.Focus();
                return;
            }

            // Calculo el nuevo Id
            if (isNew)
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    Entidad entidad = context.Entidad.Find(entidadEmail.IdEntidad);
                    if (entidad.EntidadEmail.Any())
                    {
                        entidadEmail.IdEmail = (byte)(entidad.EntidadEmail.Max(ed => ed.IdEmail) + 1);
                    }
                    else
                    {
                        entidadEmail.IdEmail = 1;
                    }
                }
            }

            // Paso los datos desde los controles al Objecto de EF
            SetDataFromControlsToObject();

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;

                entidadEmail.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadEmail.FechaHoraModificacion = DateTime.Now;

                try
                {
                    context.SaveChanges();

                    FormEntidad entidad = (FormEntidad)CardonerSistemas.Forms.MdiChildGetInstance(Program.FormMdi, "FormEntidad");
                    if (entidad != null)
                    {
                        entidad.EmailsRefreshData(entidadEmail.IdEmail);
                        entidad = null;
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                {
                    this.Cursor = Cursors.Default;

                    switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                    {
                        case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity:
                            MessageBox.Show("No se puede agregar el Email porque ya existe uno igual.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
