using CardonerSistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS_Gestion
{
    public partial class FormEntidad : Form
    {

        #region Declarations

        private CSGestionContext context = new CSGestionContext(true);
        private Entidad entidad;

        private bool isLoading = false;
        private bool isNew = false;
        private bool isEditMode = false;

        #endregion

        #region Form stuff

        public FormEntidad()
        {
            InitializeComponent();
        }

        internal void LoadAndShow(bool editMode, Form parentForm, int idEntidad)
        {
            isLoading = true;
            isNew = (idEntidad == 0);
            isEditMode = editMode;

            if (isNew)
            {
                entidad = new Entidad();
                entidad.EsActivo = true;
                entidad.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                entidad.FechaHoraCreacion = DateTime.Now;
                entidad.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidad.FechaHoraModificacion = entidad.FechaHoraCreacion;
                context.Entidad.Add(entidad);
            }
            else
            {
                entidad = context.Entidad.Find(idEntidad);
            }

            this.MdiParent = Program.FormMdi;
            CardonerSistemas.Forms.CenterToParent(parentForm, this);
            InitializeFormAndControls();
            SetDataFromObjectToControls();
            this.Show();
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Focus();

            isLoading = false;

            ChangeEditMode();
        }

        private void ChangeEditMode()
        {
            if (isLoading)
            {
                return;
            }

            buttonGuardar.Visible = isEditMode;
            buttonCancelar.Visible = isEditMode;
            buttonEditar.Visible = !isEditMode;
            buttonCerrar.Visible = !isEditMode;

            // General
            radiobuttonTipoPersonaFisica.Enabled = isEditMode;
            radiobuttonTipoPersonaJuridica.Enabled = isEditMode;
            ChangeEditModeTipoPersona();
            textboxNombreFantasia.ReadOnly = !isEditMode;
            maskedtextboxCuit.ReadOnly = !isEditMode;
            textboxIngresosBrutos.ReadOnly = !isEditMode;
            textboxPaginaWeb.ReadOnly = !isEditMode;
            checkboxTipoCliente.Enabled = isEditMode;
            checkboxTipoProveedor.Enabled = isEditMode;
            checkboxTipoTransportista.Enabled = isEditMode;

            // Grillas
            toolstripDomicilios.Enabled = !isEditMode;
            toolstripEmails.Enabled = !isEditMode;
            toolstripTelefonos.Enabled = !isEditMode;
            toolstripCuentasBancarias.Enabled = !isEditMode;
            toolstripCategorias.Enabled = !isEditMode;

            // Notas y Auditoría
            textboxNotas.ReadOnly = !isEditMode;
            checkboxEsActivo.Enabled = isEditMode;
        }

        private void ChangeEditModeTipoPersona()
        {
            textboxRazonSocial.ReadOnly = (radiobuttonTipoPersonaFisica.Checked | !isEditMode);
            textboxApellido.ReadOnly = (radiobuttonTipoPersonaJuridica.Checked | !isEditMode);
            textboxNombre.ReadOnly = (radiobuttonTipoPersonaJuridica.Checked | !isEditMode);
        }

        private void InitializeFormAndControls()
        {
            SetAppearance();
        }

        private void SetAppearance()
        {
            this.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(Properties.Resources.ImageEntidad16);
        }

        private void this_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
            context = null;
            entidad = null;
            this.Dispose();
        }

        #endregion

        #region Load and Set Data

        private void SetDataFromObjectToControls()
        {
            // General
            radiobuttonTipoPersonaFisica.Checked = entidad.EsPersonaFisica;
            radiobuttonTipoPersonaJuridica.Checked = !entidad.EsPersonaFisica;
            if (entidad.EsPersonaFisica)
            {
                textboxRazonSocial.Clear();
                textboxApellido.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidad.Apellido);
                textboxNombre.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidad.Nombre);
            }
            else
            {
                textboxRazonSocial.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidad.RazonSocial);
                textboxApellido.Clear();
                textboxNombre.Clear();
            }
            textboxNombreFantasia.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidad.NombreFantasia);
            maskedtextboxCuit.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidad.Cuit);
            textboxIngresosBrutos.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidad.IngresosBrutos);
            textboxPaginaWeb.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidad.PaginaWeb);
            checkboxTipoCliente.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidad.TipoCliente);
            checkboxTipoProveedor.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidad.TipoProveedor);
            checkboxTipoTransportista.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidad.TipoTransportista);

            // Notas y Auditoría
            textboxNotas.Text = CardonerSistemas.ControlValueTranslation.StringToTextBox(entidad.Notas);
            checkboxEsActivo.CheckState = CardonerSistemas.ControlValueTranslation.BooleanToCheckBox(entidad.EsActivo);
            textboxId.Text = entidad.IdEntidadFormatted;
            textboxFechaHoraCreacion.Text = entidad.FechaHoraCreacionFormatted;
            textboxUsuarioCreacion.Text = entidad.UsuarioCreacionFormatted;
            textboxFechaHoraModificacion.Text = entidad.FechaHoraModificacionFormatted;
            textboxUsuarioModificacion.Text = entidad.UsuarioModificacionFormatted;
        }

        private void SetDataFromControlsToObject()
        {
            // General
            entidad.EsPersonaFisica = (radiobuttonTipoPersonaFisica.Checked);
            if (radiobuttonTipoPersonaFisica.Checked)
            {
                entidad.RazonSocial = null;
                entidad.Apellido = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxApellido.Text);
                entidad.Nombre = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNombre.Text);
            }
            else
            {
                entidad.RazonSocial = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxRazonSocial.Text);
                entidad.Apellido = null;
                entidad.Nombre = null;
            }
            entidad.NombreFantasia = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNombreFantasia.Text);
            entidad.Cuit = CardonerSistemas.ControlValueTranslation.TextBoxToString(maskedtextboxCuit.Text);
            entidad.IngresosBrutos = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxIngresosBrutos.Text);
            entidad.PaginaWeb = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxPaginaWeb.Text);
            entidad.TipoCliente = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxTipoCliente.CheckState).Value;
            entidad.TipoProveedor = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxTipoProveedor.CheckState).Value;
            entidad.TipoTransportista = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxTipoTransportista.CheckState).Value;

            // Notas y Auditoría
            entidad.Notas = CardonerSistemas.ControlValueTranslation.TextBoxToString(textboxNotas.Text);
            entidad.EsActivo = CardonerSistemas.ControlValueTranslation.CheckBoxToBoolean(checkboxEsActivo.CheckState).Value;
        }

        #endregion

        #region Controls behavior

        private void TabControlChanged(object sender, EventArgs e)
        {
            if (entidad.IdEntidad != 0)
            {
                if (tabcontrolMain.SelectedTab.Name == tabpageDomicilios.Name && tabpageDomicilios.Tag == null)
                {
                    DomiciliosRefreshData();
                    tabpageDomicilios.Tag = "Refreshed";
                }
                if (tabcontrolMain.SelectedTab.Name == tabpageEmails.Name && tabpageEmails.Tag == null)
                {
                    EmailsRefreshData();
                    tabpageEmails.Tag = "Refreshed";
                }
                if (tabcontrolMain.SelectedTab.Name == tabpageTelefonos.Name && tabpageTelefonos.Tag == null)
                {
                    TelefonosRefreshData();
                    tabpageTelefonos.Tag = "Refreshed";
                }
                if (tabcontrolMain.SelectedTab.Name == tabpageCuentasBancarias.Name && tabpageCuentasBancarias.Tag == null)
                {
                    CuentasBancariasRefreshData();
                    tabpageCuentasBancarias.Tag = "Refreshed";
                }
                if (tabcontrolMain.SelectedTab.Name == tabpageCategorias.Name && tabpageCategorias.Tag == null)
                {
                    CategoriasRefreshData();
                    tabpageCategorias.Tag = "Refreshed";
                }
            }
        }

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

        private void TipoPersona_CheckedChanged(object sender, EventArgs e)
        {
            ChangeEditModeTipoPersona();
        }

        private void TextBoxs_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void MaskedTextBoxs_Enter(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).SelectAll();
        }

        private void buttonPaginaWebAbrir_Click(object sender, EventArgs e)
        {
            if (textboxPaginaWeb.Text.Trim().Length > 0)
            {
                CardonerSistemas.Process.Start(textboxPaginaWeb.Text.Trim());
            }
        }

        #endregion

        #region Main toolbar

        private void Editar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadEditar))
            {
                isEditMode = true;
                ChangeEditMode();
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (!radiobuttonTipoPersonaFisica.Checked & !radiobuttonTipoPersonaJuridica.Checked)
            {
                tabcontrolMain.SelectedTab = tabpageGeneral;
                MessageBox.Show("Debe seleccionar el Tipo de Persona.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (radiobuttonTipoPersonaFisica.Checked)
            {
                if (textboxApellido.Text.Trim().Length == 0)
                {
                    tabcontrolMain.SelectedTab = tabpageGeneral;
                    MessageBox.Show("Debe ingresar el Apellido.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textboxApellido.Focus();
                    return;
                }
            }
            else
            {
                if (textboxRazonSocial.Text.Trim().Length == 0)
                {
                    tabcontrolMain.SelectedTab = tabpageGeneral;
                    MessageBox.Show("Debe ingresar la Razón Social.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textboxRazonSocial.Focus();
                    return;
                }
            }

            if (maskedtextboxCuit.Text.Length > 0)
            {
                if (maskedtextboxCuit.Text.Length < 11)
                {
                    tabcontrolMain.SelectedTab = tabpageGeneral;
                    MessageBox.Show("El CUIT está incompleto. Debe tener 11 dígitos.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maskedtextboxCuit.Focus();
                    return;
                }
                if (!CardonerSistemas.Afip.VerificarCuit(maskedtextboxCuit.Text))
                {
                    tabcontrolMain.SelectedTab = tabpageGeneral;
                    MessageBox.Show("El CUIT es incorrecto. Verifíquelo.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maskedtextboxCuit.Focus();
                    return;
                }
            }

            if (!(checkboxTipoCliente.Checked || checkboxTipoProveedor.Checked || checkboxTipoTransportista.Checked))
            {
                tabcontrolMain.SelectedTab = tabpageGeneral;
                MessageBox.Show("Debe especificar el Tipo de Entidad.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedtextboxCuit.Focus();
                return;
            }

            // Calculo el nuevo Id
            if (isNew)
            {
                using (CSGestionContext context = new CSGestionContext(true))
                {
                    if (context.Entidad.Any())
                    {
                        entidad.IdEntidad = (from ent in context.Entidad select ent.IdEntidad).Max() + 1;
                    }
                    else
                    {
                        entidad.IdEntidad = 1;
                    }
                }
            }

            // Paso los datos desde los controles al Objecto de EF
            SetDataFromControlsToObject();

            if (context.ChangeTracker.HasChanges())
            {
                this.Cursor = Cursors.WaitCursor;

                entidad.IdUsuarioModificacion = Program.Usuario.IdUsuario;
                entidad.FechaHoraModificacion = DateTime.Now;

                try
                {
                    context.SaveChanges();

                    if (CardonerSistemas.Forms.MdiChildIsLoaded(Program.FormMdi, "FormEntidades"))
                    {
                        FormEntidades entidades = (FormEntidades)CardonerSistemas.Forms.MdiChildGetInstance(Program.FormMdi, "FormEntidades");
                        entidades.RefreshData(entidad.IdEntidad);
                        entidades = null;
                    }
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                {
                    this.Cursor = Cursors.Default;

                    switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                    {
                        case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity:
                            MessageBox.Show("No se puede agregar la Entidad porque ya existe una Entidad con el mismo nombre.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion

        #region Domicilios

        internal class DomiciliosGridRowData
        {
            public byte IdDomicilio { get; set; }
            public string DomicilioTipoNombre { get; set; }
            public string DomicilioParaMostrar { get; set; }
            public string LocalidadNombre { get; set; }
        }

        internal void DomiciliosRefreshData(byte positionIdDomicilio = 0, bool restorePosition = false)
        {
            List<DomiciliosGridRowData> listDomicilios;

            if (restorePosition)
            {
                if (datagridviewDomicilios.CurrentRow == null)
                {
                    positionIdDomicilio = 0;
                }
                else
                {
                    positionIdDomicilio = ((DomiciliosGridRowData)datagridviewDomicilios.CurrentRow.DataBoundItem).IdDomicilio;
                }
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                listDomicilios = (from ed in context.EntidadDomicilio
                                  join dt in context.DomicilioTipo on ed.IdDomicilioTipo equals dt.IdDomicilioTipo
                                  join l in context.Localidad on new { k1 = ed.IdProvincia, k2 = ed.IdLocalidad } equals new { k1 = (byte?)l.IdProvincia, k2 = (short?)l.IdLocalidad } into grupolocalidades
                                  from gl in grupolocalidades.DefaultIfEmpty()
                                  where ed.IdEntidad == entidad.IdEntidad
                                  orderby dt.Nombre
                                  select new DomiciliosGridRowData() { IdDomicilio = ed.IdDomicilio, DomicilioTipoNombre = (dt.IdDomicilioTipo == CardonerSistemas.Constants.ByteFieldValueOther ? ed.TipoOtro : dt.Nombre), DomicilioParaMostrar = ed.DomicilioParaMostrar, LocalidadNombre = (gl == null ? string.Empty : gl.Nombre) }).ToList();

                datagridviewDomicilios.AutoGenerateColumns = false;
                datagridviewDomicilios.DataSource = listDomicilios;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al leer los Domicilios.");
                this.Cursor = Cursors.Default;
                return;
            }

            this.Cursor = Cursors.Default;

            if (positionIdDomicilio != 0)
            {
                foreach (DataGridViewRow row in datagridviewDomicilios.Rows)
                {
                    if (((DomiciliosGridRowData)row.DataBoundItem).IdDomicilio == positionIdDomicilio)
                    {
                        datagridviewDomicilios.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }

        }

        private void DomiciliosAgregar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadDomicilioAgregar))
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadDomicilio formDomicilio = new FormEntidadDomicilio();
                formDomicilio.LoadAndShow(true, this, entidad.IdEntidad, 0);

                this.Cursor = Cursors.Default;
            }
        }

        private void DomiciliosEditar_Click(object sender, EventArgs e)
        {
            if (datagridviewDomicilios.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Domicilio para editar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadDomicilioEditar))
                {
                    this.Cursor = Cursors.WaitCursor;

                    FormEntidadDomicilio formDomicilio = new FormEntidadDomicilio();
                    formDomicilio.LoadAndShow(true, this, entidad.IdEntidad, ((DomiciliosGridRowData)datagridviewDomicilios.CurrentRow.DataBoundItem).IdDomicilio);

                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void DomiciliosBorrar_Click(object sender, EventArgs e)
        {
            if (datagridviewDomicilios.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Domicilio para borrar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadDomicilioBorrar))
                {
                    DomiciliosGridRowData rowData = (DomiciliosGridRowData)datagridviewDomicilios.CurrentRow.DataBoundItem;
                    string mensaje = string.Format("Se borrará el Domicilio seleccionado.{0}{0}Tipo: {1}{0}Domicilio: {2}{0}Localidad: {3}{0}{0}¿Confirma el borrado definitivo?", Environment.NewLine, rowData.DomicilioTipoNombre, rowData.DomicilioParaMostrar, rowData.LocalidadNombre);
                    if (MessageBox.Show(mensaje, CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        EntidadDomicilio domicilioEntidad = context.EntidadDomicilio.Find(entidad.IdEntidad, rowData.IdDomicilio);
                        context.EntidadDomicilio.Remove(domicilioEntidad);
                        context.SaveChanges();
                        domicilioEntidad = null;

                        DomiciliosRefreshData();

                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void DomiciliosVer_Click(object sender, EventArgs e)
        {
            if (datagridviewDomicilios.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Domicilio para ver.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadDomicilio formDomicilio = new FormEntidadDomicilio();
                formDomicilio.LoadAndShow(false, this, entidad.IdEntidad, ((DomiciliosGridRowData)datagridviewDomicilios.CurrentRow.DataBoundItem).IdDomicilio);

                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Emails

        internal class EmailsGridRowData
        {
            public byte IdEmail { get; set; }
            public string EmailTipoNombre { get; set; }
            public string Email { get; set; }
            public string Nombre { get; set; }
        }

        internal void EmailsRefreshData(byte positionIdEmail = 0, bool restorePosition = false)
        {
            List<EmailsGridRowData> listEmails;

            if (restorePosition)
            {
                if (datagridviewEmails.CurrentRow == null)
                {
                    positionIdEmail = 0;
                }
                else
                {
                    positionIdEmail = ((EmailsGridRowData)datagridviewEmails.CurrentRow.DataBoundItem).IdEmail;
                }
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                listEmails = (from ee in context.EntidadEmail
                                join et in context.EmailTipo on ee.IdEmailTipo equals et.IdEmailTipo
                                where ee.IdEntidad == entidad.IdEntidad
                                orderby et.Nombre
                                select new EmailsGridRowData() { IdEmail = ee.IdEmail, EmailTipoNombre = ((et.IdEmailTipo == CardonerSistemas.Constants.ByteFieldValueOther & ee.TipoOtro != null) ? ee.TipoOtro : et.Nombre), Email = ee.Email, Nombre = ee.Nombre }).ToList();

                datagridviewEmails.AutoGenerateColumns = false;
                datagridviewEmails.DataSource = listEmails;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al leer los e-mails.");
                this.Cursor = Cursors.Default;
                return;
            }

            this.Cursor = Cursors.Default;

            if (positionIdEmail != 0)
            {
                foreach (DataGridViewRow row in datagridviewEmails.Rows)
                {
                    if (((EmailsGridRowData)row.DataBoundItem).IdEmail == positionIdEmail)
                    {
                        datagridviewEmails.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }

        }

        private void EmailsAgregar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadEmailAgregar))
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadEmail formEmail = new FormEntidadEmail();
                formEmail.LoadAndShow(true, this, entidad.IdEntidad, 0);

                this.Cursor = Cursors.Default;
            }
        }

        private void EmailsEditar_Click(object sender, EventArgs e)
        {
            if (datagridviewEmails.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Email para editar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadEmailEditar))
                {
                    this.Cursor = Cursors.WaitCursor;

                    FormEntidadEmail formEmail = new FormEntidadEmail();
                    formEmail.LoadAndShow(true, this, entidad.IdEntidad, ((EmailsGridRowData)datagridviewEmails.CurrentRow.DataBoundItem).IdEmail);

                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void EmailsBorrar_Click(object sender, EventArgs e)
        {
            if (datagridviewEmails.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Email para borrar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadEmailBorrar))
                {
                    EmailsGridRowData rowData = (EmailsGridRowData)datagridviewEmails.CurrentRow.DataBoundItem;
                    string mensaje = string.Format("Se borrará el e-mail seleccionado.{0}{0}Tipo: {1}{0}e-mail: {2}{0}Nombre: {3}{0}{0}¿Confirma el borrado definitivo?", Environment.NewLine, rowData.EmailTipoNombre, rowData.Email, rowData.Nombre);
                    if (MessageBox.Show(mensaje, CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        EntidadEmail EmailEntidad = context.EntidadEmail.Find(entidad.IdEntidad, rowData.IdEmail);
                        context.EntidadEmail.Remove(EmailEntidad);
                        context.SaveChanges();
                        EmailEntidad = null;

                        EmailsRefreshData();

                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void EmailsVer_Click(object sender, EventArgs e)
        {
            if (datagridviewEmails.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Email para ver.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadEmail formEmail = new FormEntidadEmail();
                formEmail.LoadAndShow(false, this, entidad.IdEntidad, ((EmailsGridRowData)datagridviewEmails.CurrentRow.DataBoundItem).IdEmail);

                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Telefonos

        internal class TelefonosGridRowData
        {
            public byte IdTelefono { get; set; }
            public string TelefonoTipoNombre { get; set; }
            public string Numero { get; set; }
        }

        internal void TelefonosRefreshData(byte positionIdTelefono = 0, bool restorePosition = false)
        {
            List<TelefonosGridRowData> listTelefonos;

            if (restorePosition)
            {
                if (datagridviewTelefonos.CurrentRow == null)
                {
                    positionIdTelefono = 0;
                }
                else
                {
                    positionIdTelefono = ((TelefonosGridRowData)datagridviewTelefonos.CurrentRow.DataBoundItem).IdTelefono;
                }
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                listTelefonos = (from et in context.EntidadTelefono
                              join tt in context.TelefonoTipo on et.IdTelefonoTipo equals tt.IdTelefonoTipo
                              where et.IdEntidad == entidad.IdEntidad
                              orderby tt.Nombre
                              select new TelefonosGridRowData() { IdTelefono = et.IdTelefono, TelefonoTipoNombre = ((tt.IdTelefonoTipo == CardonerSistemas.Constants.ByteFieldValueOther & et.TipoOtro != null) ? et.TipoOtro : tt.Nombre), Numero = et.Numero }).ToList();

                datagridviewTelefonos.AutoGenerateColumns = false;
                datagridviewTelefonos.DataSource = listTelefonos;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al leer los teléfonos.");
                this.Cursor = Cursors.Default;
                return;
            }

            this.Cursor = Cursors.Default;

            if (positionIdTelefono != 0)
            {
                foreach (DataGridViewRow row in datagridviewTelefonos.Rows)
                {
                    if (((TelefonosGridRowData)row.DataBoundItem).IdTelefono == positionIdTelefono)
                    {
                        datagridviewTelefonos.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }

        }

        private void TelefonosAgregar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadTelefonoAgregar))
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadTelefono formTelefono = new FormEntidadTelefono();
                formTelefono.LoadAndShow(true, this, entidad.IdEntidad, 0);

                this.Cursor = Cursors.Default;
            }
        }

        private void TelefonosEditar_Click(object sender, EventArgs e)
        {
            if (datagridviewTelefonos.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Teléfono para editar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadTelefonoEditar))
                {
                    this.Cursor = Cursors.WaitCursor;

                    FormEntidadTelefono formTelefono = new FormEntidadTelefono();
                    formTelefono.LoadAndShow(true, this, entidad.IdEntidad, ((TelefonosGridRowData)datagridviewTelefonos.CurrentRow.DataBoundItem).IdTelefono);

                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void TelefonosBorrar_Click(object sender, EventArgs e)
        {
            if (datagridviewTelefonos.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Teléfono para borrar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadTelefonoBorrar))
                {
                    TelefonosGridRowData rowData = (TelefonosGridRowData)datagridviewTelefonos.CurrentRow.DataBoundItem;
                    string mensaje = string.Format("Se borrará el teléfono seleccionado.{0}{0}Tipo: {1}{0}Número: {2}{0}{0}¿Confirma el borrado definitivo?", Environment.NewLine, rowData.TelefonoTipoNombre, rowData.Numero);
                    if (MessageBox.Show(mensaje, CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        EntidadTelefono TelefonoEntidad = context.EntidadTelefono.Find(entidad.IdEntidad, rowData.IdTelefono);
                        context.EntidadTelefono.Remove(TelefonoEntidad);
                        context.SaveChanges();
                        TelefonoEntidad = null;

                        TelefonosRefreshData();

                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void TelefonosVer_Click(object sender, EventArgs e)
        {
            if (datagridviewTelefonos.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún Teléfono para ver.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadTelefono formTelefono = new FormEntidadTelefono();
                formTelefono.LoadAndShow(false, this, entidad.IdEntidad, ((TelefonosGridRowData)datagridviewTelefonos.CurrentRow.DataBoundItem).IdTelefono);

                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region CuentaBancarias

        internal class CuentasBancariasGridRowData
        {
            public byte IdCuentaBancaria { get; set; }
            public string BancoNombre { get; set; }
            public string TipoNombre { get; set; }
            public short? Sucursal { get; set; }
            public string Numero { get; set; }
        }

        internal void CuentasBancariasRefreshData(byte positionIdCuentaBancaria = 0, bool restorePosition = false)
        {
            List<CuentasBancariasGridRowData> listCuentasBancarias;

            if (restorePosition)
            {
                if (datagridviewCuentasBancarias.CurrentRow == null)
                {
                    positionIdCuentaBancaria = 0;
                }
                else
                {
                    positionIdCuentaBancaria = ((CuentasBancariasGridRowData)datagridviewCuentasBancarias.CurrentRow.DataBoundItem).IdCuentaBancaria;
                }
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                listCuentasBancarias = (from ecb in context.EntidadCuentaBancaria
                                       join b in context.Banco on ecb.IdBanco equals b.IdBanco
                                       join cbt in context.CuentaBancariaTipo on ecb.IdCuentaBancariaTipo equals cbt.IdCuentaBancariaTipo into cuentabancariatipogrupo
                                       from cbtg in cuentabancariatipogrupo.DefaultIfEmpty()
                                       where ecb.IdEntidad == entidad.IdEntidad
                                       orderby b.Nombre, cbtg.Nombre
                                       select new CuentasBancariasGridRowData() { IdCuentaBancaria = ecb.IdCuentaBancaria, BancoNombre = b.Nombre, TipoNombre = (cbtg == null ? string.Empty : cbtg.Nombre), Sucursal = ecb.Sucursal, Numero = ecb.Numero }).ToList();

                datagridviewCuentasBancarias.AutoGenerateColumns = false;
                datagridviewCuentasBancarias.DataSource = listCuentasBancarias;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al leer las Cuentas Bancarias.");
                this.Cursor = Cursors.Default;
                return;
            }

            this.Cursor = Cursors.Default;

            if (positionIdCuentaBancaria != 0)
            {
                foreach (DataGridViewRow row in datagridviewCuentasBancarias.Rows)
                {
                    if (((CuentasBancariasGridRowData)row.DataBoundItem).IdCuentaBancaria == positionIdCuentaBancaria)
                    {
                        datagridviewCuentasBancarias.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }

        }

        private void CuentaBancariasAgregar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadCuentaBancariaAgregar))
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadCuentaBancaria formCuentaBancaria = new FormEntidadCuentaBancaria();
                formCuentaBancaria.LoadAndShow(true, this, entidad.IdEntidad, 0);

                this.Cursor = Cursors.Default;
            }
        }

        private void CuentaBancariasEditar_Click(object sender, EventArgs e)
        {
            if (datagridviewCuentasBancarias.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Cuenta Bancaria para editar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadCuentaBancariaEditar))
                {
                    this.Cursor = Cursors.WaitCursor;

                    FormEntidadCuentaBancaria formCuentaBancaria = new FormEntidadCuentaBancaria();
                    formCuentaBancaria.LoadAndShow(true, this, entidad.IdEntidad, ((CuentasBancariasGridRowData)datagridviewCuentasBancarias.CurrentRow.DataBoundItem).IdCuentaBancaria);

                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void CuentaBancariasBorrar_Click(object sender, EventArgs e)
        {
            if (datagridviewCuentasBancarias.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Cuenta Bancaria para borrar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadCuentaBancariaBorrar))
                {
                    CuentasBancariasGridRowData rowData = (CuentasBancariasGridRowData)datagridviewCuentasBancarias.CurrentRow.DataBoundItem;
                    string mensaje = string.Format("Se borrará la Cuenta Bancaria seleccionada.{0}{0}Banco: {1}{0}Tipo: {2}{0}Sucursal: {3}{0}Número: {4}{0}{0}¿Confirma el borrado definitivo?", Environment.NewLine, rowData.BancoNombre, rowData.TipoNombre, rowData.Sucursal, rowData.Numero);
                    if (MessageBox.Show(mensaje, CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        EntidadCuentaBancaria CuentaBancariaEntidad = context.EntidadCuentaBancaria.Find(entidad.IdEntidad, rowData.IdCuentaBancaria);
                        context.EntidadCuentaBancaria.Remove(CuentaBancariaEntidad);
                        context.SaveChanges();
                        CuentaBancariaEntidad = null;

                        CuentasBancariasRefreshData();

                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void CuentaBancariasVer_Click(object sender, EventArgs e)
        {
            if (datagridviewCuentasBancarias.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Cuenta Bancaria para ver.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadCuentaBancaria formCuentaBancaria = new FormEntidadCuentaBancaria();
                formCuentaBancaria.LoadAndShow(false, this, entidad.IdEntidad, ((CuentasBancariasGridRowData)datagridviewCuentasBancarias.CurrentRow.DataBoundItem).IdCuentaBancaria);

                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Categorias

        internal class CategoriasGridRowData
        {
            public short IdCategoria { get; set; }
            public string Nombre { get; set; }
        }

        internal void CategoriasRefreshData(short positionIdCategoria = 0, bool restorePosition = false)
        {
            List<CategoriasGridRowData> listCategorias;

            if (restorePosition)
            {
                if (datagridviewCategorias.CurrentRow == null)
                {
                    positionIdCategoria = 0;
                }
                else
                {
                    positionIdCategoria = ((CategoriasGridRowData)datagridviewCategorias.CurrentRow.DataBoundItem).IdCategoria;
                }
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                listCategorias = (from eec in context.EntidadEntidadCategoria
                                    join ec in context.EntidadCategoria on eec.IdEntidadCategoria equals ec.IdEntidadCategoria
                                    where eec.IdEntidad == entidad.IdEntidad
                                    orderby ec.Nombre
                                    select new CategoriasGridRowData() { IdCategoria = eec.IdEntidadCategoria, Nombre = ec.Nombre }).ToList();

                datagridviewCategorias.AutoGenerateColumns = false;
                datagridviewCategorias.DataSource = listCategorias;
            }
            catch (Exception ex)
            {
                CardonerSistemas.Error.ProcessError(ex, "Error al leer las Categorías.");
                this.Cursor = Cursors.Default;
                return;
            }

            this.Cursor = Cursors.Default;

            if (positionIdCategoria != 0)
            {
                foreach (DataGridViewRow row in datagridviewCategorias.Rows)
                {
                    if (((CategoriasGridRowData)row.DataBoundItem).IdCategoria == positionIdCategoria)
                    {
                        datagridviewCategorias.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }

        }

        private void CategoriasAgregar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadCategoriaAgregar))
            {
                this.Cursor = Cursors.WaitCursor;

                FormEntidadCategorias entidadCategorias = new FormEntidadCategorias(true);
                CardonerSistemas.Forms.CenterToParent(this, entidadCategorias);
                if (entidadCategorias.ShowDialog(this) == DialogResult.Yes)
                {
                    short idCategoria = 0;

                    foreach (DataGridViewRow row in entidadCategorias.datagridviewMain.SelectedRows)
                    {
                        idCategoria = ((EntidadCategoria)row.DataBoundItem).IdEntidadCategoria;
                        List<CategoriasGridRowData> categorias = (List<CategoriasGridRowData>)datagridviewCategorias.DataSource;
                        if (!categorias.Exists(ec => ec.IdCategoria == idCategoria))
                        {
                            EntidadEntidadCategoria categoria = new EntidadEntidadCategoria();
                            categoria.IdEntidad = entidad.IdEntidad;
                            categoria.IdEntidadCategoria = idCategoria;
                            categoria.IdUsuarioCreacion = Program.Usuario.IdUsuario;
                            categoria.FechaHoraCreacion = DateTime.Now;
                            context.EntidadEntidadCategoria.Add(categoria);
                        }
                    }
                    if (context.ChangeTracker.HasChanges())
                    {
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException dbuex)
                        {
                            this.Cursor = Cursors.Default;

                            switch (CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex))
                            {
                                case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity:
                                    MessageBox.Show("No se puede agregar la Categoría porque ya existe en esta Entidad.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        CategoriasRefreshData(idCategoria);
                    }
                }
                entidadCategorias = null;

                this.Cursor = Cursors.Default;
            }
        }

        private void CategoriasBorrar_Click(object sender, EventArgs e)
        {
            if (datagridviewCategorias.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna Categoría para borrar.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Permisos.Verificar(Permisos.EntidadCategoriaBorrar))
                {
                    CategoriasGridRowData rowData = (CategoriasGridRowData)datagridviewCategorias.CurrentRow.DataBoundItem;
                    string mensaje = string.Format("Se borrará la Categoría seleccionada.{0}{0}Nombre: {1}{0}{0}¿Confirma el borrado definitivo?", Environment.NewLine, rowData.Nombre);
                    if (MessageBox.Show(mensaje, CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        this.Cursor = Cursors.WaitCursor;

                        EntidadEntidadCategoria entidadEntidadCategoria = context.EntidadEntidadCategoria.Find(entidad.IdEntidad, rowData.IdCategoria);
                        context.EntidadEntidadCategoria.Remove(entidadEntidadCategoria);
                        context.SaveChanges();
                        entidadEntidadCategoria = null;

                        CategoriasRefreshData();

                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

        #endregion

    }
}
