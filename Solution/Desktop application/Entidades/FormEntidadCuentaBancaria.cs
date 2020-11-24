using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidadCuentaBancaria : Form
    {

        #region Declarations

        private CSGestionContext context = new CSGestionContext(true);
        private EntidadCuentaBancaria entidadCuentaBancaria;

        private bool isLoading = false;
        private bool isNew = false;
        private bool isEditMode = false;

        private string codigoBanco = "";
        private List<Banco> bancos = null;

        #endregion

        #region Form stuff

        public FormEntidadCuentaBancaria()
        {
            InitializeComponent();
        }

        internal void LoadAndShow(bool editMode, Form parentForm, int idEntidad, byte idCuentaBancaria)
        {
            isLoading = true;
            isNew = (idCuentaBancaria == 0);
            isEditMode = editMode;

            if (idCuentaBancaria == 0)
            {
                entidadCuentaBancaria = new EntidadCuentaBancaria();
                entidadCuentaBancaria.IdEntidad = idEntidad;
                entidadCuentaBancaria.EsActivo = true;
                entidadCuentaBancaria.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                entidadCuentaBancaria.FechaHoraCreacion = DateTime.Now;
                entidadCuentaBancaria.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadCuentaBancaria.FechaHoraModificacion = entidadCuentaBancaria.FechaHoraCreacion;

                context.EntidadCuentaBancaria.Add(entidadCuentaBancaria);
            }
            else
            {
                entidadCuentaBancaria = context.EntidadCuentaBancaria.Find(idEntidad, idCuentaBancaria);
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
            comboboxBanco.Enabled = isEditMode;
            comboboxTipo.Enabled = isEditMode;
            maskedtextboxSucursal.ReadOnly = !isEditMode;
            textboxNumero.ReadOnly = !isEditMode;
            maskedtextboxCbu.ReadOnly = !isEditMode;
            textboxCbuAlias.ReadOnly = !isEditMode;
            maskedtextboxCuit.ReadOnly = !isEditMode;
            textboxTitular.ReadOnly = !isEditMode;
            textboxIdentificacion.ReadOnly = !isEditMode;

            // Notas y Auditoría
            textboxNotas.ReadOnly = !isEditMode;
            checkboxEsActivo.Enabled = isEditMode;
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();

            ListasComunes.Banco(comboboxBanco, context, false);
            ListasComunes.CuentaBancariaTipo(comboboxTipo, context, false);
        }

        private void SetAppearance()
        { 

        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            entidadCuentaBancaria = null;
            this.Dispose();
        }

        #endregion

        #region Load and Set Data

        private void SetDataFromObjectToControls()
        {
            // General
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxBanco, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidadCuentaBancaria.IdBanco, CardonerSistemas.Constants.ByteFieldValueNotSpecified);
            CardonerSistemas.ComboBox.SetSelectedValue(comboboxTipo, CardonerSistemas.ComboBox.SelectedItemOptions.Value, entidadCuentaBancaria.IdCuentaBancariaTipo, CardonerSistemas.Constants.ByteFieldValueNotSpecified);
            maskedtextboxSucursal.Text = CardonerSistemas.ControlValueTranslation.ShortToTextBox(entidadCuentaBancaria.Sucursal);
            textboxNumero.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadCuentaBancaria.Numero);
            maskedtextboxCbu.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadCuentaBancaria.Cbu);
            textboxCbuAlias.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadCuentaBancaria.CbuAlias);
            maskedtextboxCuit.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadCuentaBancaria.Cuit);
            textboxTitular.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadCuentaBancaria.Titular);
            textboxIdentificacion.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadCuentaBancaria.Identificacion);

            // Notas y Auditoría
            textboxNotas.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidadCuentaBancaria.Notas);
            checkboxEsActivo.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidadCuentaBancaria.EsActivo);
            textboxId.Text = entidadCuentaBancaria.IdCuentaBancariaFormatted;
            textboxFechaHoraCreacion.Text = entidadCuentaBancaria.FechaHoraCreacionFormatted;
            textboxUsuarioCreacion.Text = entidadCuentaBancaria.UsuarioCreacionFormatted;
            textboxFechaHoraModificacion.Text = entidadCuentaBancaria.FechaHoraModificacionFormatted;
            textboxUsuarioModificacion.Text = entidadCuentaBancaria.UsuarioModificacionFormatted;
        }

        private void SetDataFromControlsToObject()
        {
            // General
            entidadCuentaBancaria.IdBanco = CardonerSistemas.ControlValueTranslation.ComboBoxToByte(comboboxBanco.SelectedValue).Value;
            entidadCuentaBancaria.IdCuentaBancariaTipo = CardonerSistemas.ControlValueTranslation.ComboBoxToByte(comboboxTipo.SelectedValue);
            entidadCuentaBancaria.Sucursal = CardonerSistemas.ControlValueTranslation.TextBoxToShort(maskedtextboxSucursal.Text);
            entidadCuentaBancaria.Numero = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNumero.Text);
            entidadCuentaBancaria.Cbu = CardonerSistemas.ControlValueTranslation.TextBoxToString(maskedtextboxCbu.Text);
            entidadCuentaBancaria.CbuAlias = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxCbuAlias.Text);
            entidadCuentaBancaria.Cuit = CardonerSistemas.ControlValueTranslation.TextBoxToString(maskedtextboxCuit.Text);
            entidadCuentaBancaria.Titular = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxTitular.Text);
            entidadCuentaBancaria.Identificacion = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxIdentificacion.Text);

            // Notas y Auditoría
            entidadCuentaBancaria.Notas = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNotas.Text);
            entidadCuentaBancaria.EsActivo = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxEsActivo.CheckState).Value;
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

        private void TextBoxs_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void MaskedTextBoxs_Enter(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).SelectAll();
        }

        private void Cbu_TextChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            if (maskedtextboxCbu.Text.Length >= 3)
            {
                if (bancos == null)
                {
                    bancos = context.Banco.ToList();
                }
                if (codigoBanco != maskedtextboxCbu.Text.Substring(0, 3))
                {
                    Banco banco = bancos.Find(b => b.Codigo == maskedtextboxCbu.Text.Substring(0, 3));
                    if (banco != null)
                    {
                        codigoBanco = banco.Codigo;
                        CardonerSistemas.ComboBox.SetSelectedValue(comboboxBanco, CardonerSistemas.ComboBox.SelectedItemOptions.ValueOrFirst, banco.IdBanco);
                    }
                    else
                    {
                        comboboxBanco.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                comboboxBanco.SelectedIndex = -1;
            }
        }

        #endregion

        #region Main toolbar

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadCuentaBancariaEditar))
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
            if (comboboxBanco.SelectedValue == null)
            {
                tabMain.SelectedTab = tabpageGeneral;
                MessageBox.Show("Debe especificar el Banco.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboboxBanco.Focus();
                return;
            }

            // CBU
            if (maskedtextboxCbu.Text.Length > 0)
            {
                if (maskedtextboxCbu.Text.Length < 12)
                {
                    tabMain.SelectedTab = tabpageGeneral;
                    MessageBox.Show("Debe especificar los 12 dígitos del CBU.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maskedtextboxCbu.Focus();
                    return;
                }
                switch (CardonerSistemas.Bank.VerificarCBU(maskedtextboxCbu.Text))
                {
                    case 0:
                        tabMain.SelectedTab = tabpageGeneral;
                        MessageBox.Show("El CBU ingresado es incorrecto.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maskedtextboxCbu.Focus();
                        return;
                    case 1:
                        tabMain.SelectedTab = tabpageGeneral;
                        MessageBox.Show("El CBU ingresado tiene un error en el 1er. bloque.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maskedtextboxCbu.Focus();
                        return;
                    case 2:
                        tabMain.SelectedTab = tabpageGeneral;
                        MessageBox.Show("El CBU ingresado tiene un error en el 2do. bloque.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        maskedtextboxCbu.Focus();
                        return;
                    default:
                        break;
                }
            }

            // Verifico el CUIT
            if (maskedtextboxCuit.Text.Length > 0)
            {
                if (maskedtextboxCuit.Text.Length < 11)
                {
                    tabMain.SelectedTab = tabpageGeneral;
                    MessageBox.Show("El CUIT está incompleto. Debe tener 11 dígitos.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maskedtextboxCuit.Focus();
                    return;
                }
                if (!CardonerSistemas.Afip.VerificarCuit(maskedtextboxCuit.Text))
                {
                    tabMain.SelectedTab = tabpageGeneral;
                    MessageBox.Show("El CUIT es incorrecto. Verifíquelo.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maskedtextboxCuit.Focus();
                    return;
                }
            }

            // Calculo el nuevo Id
            if (isNew)
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    Entidad entidad = context.Entidad.Find(entidadCuentaBancaria.IdEntidad);
                    if (entidad.EntidadCuentaBancaria.Any())
                    {
                        entidadCuentaBancaria.IdCuentaBancaria = (byte)(entidad.EntidadCuentaBancaria.Max(ed => ed.IdCuentaBancaria) + 1);
                    }
                    else
                    {
                        entidadCuentaBancaria.IdCuentaBancaria = 1;
                    }
                }
            }

            // Paso los datos desde los controles al Objecto de EF
            SetDataFromControlsToObject();

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;

                entidadCuentaBancaria.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidadCuentaBancaria.FechaHoraModificacion = DateTime.Now;

                try
                {
                    context.SaveChanges();

                    FormEntidad entidad = (FormEntidad)CardonerSistemas.Forms.MdiChildGetInstance(Program.FormMdi, "FormEntidad");
                    if (entidad != null)
                    {
                        entidad.CuentasBancariasRefreshData(entidadCuentaBancaria.IdCuentaBancaria);
                        entidad = null;
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                {
                    this.Cursor = Cursors.Default;

                    switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                    {
                        case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity:
                            MessageBox.Show("No se puede agregar la Cuenta Bancaria porque ya existe una igual.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
