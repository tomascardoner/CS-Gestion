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
            }
        }

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
                                  select new DomiciliosGridRowData() { IdDomicilio = ed.IdDomicilio, DomicilioTipoNombre = dt.Nombre, DomicilioParaMostrar = ed.DomicilioParaMostrar, LocalidadNombre = (gl == null ? string.Empty : gl.Nombre) }).ToList();

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

        }

        private void DomiciliosAgregar_Click(object sender, EventArgs e)
        {
            if (Permisos.Verificar(Permisos.EntidadDomicilioAgregar))
            {
                this.Cursor = Cursors.WaitCursor;

                // FormEntidadDomicilio formDomicilio = new FormEntidadDomicilio();
                // formDomicilio.LoadDataAndShow(true, this, entidad.IdEntidad, 0);

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

                    // FormEntidadDomicilio formDomicilio = new FormEntidadDomicilio();
                    // formDomicilio.LoadDataAndShow(true, this, entidad.IdEntidad, ((DomiciliosGridRowData)datagridviewDomicilios.CurrentRow.DataBoundItem).IdDomicilio;

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
                if (Permisos.Verificar(Permisos.EntidadDomicilioEditar))
                {
                    this.Cursor = Cursors.WaitCursor;

                    // FormEntidadDomicilio formDomicilio = new FormEntidadDomicilio();
                    // formDomicilio.LoadDataAndShow(false, this, entidad.IdEntidad, ((DomiciliosGridRowData)datagridviewDomicilios.CurrentRow.DataBoundItem).IdDomicilio;

                    this.Cursor = Cursors.Default;
                }
            }
        }

        #endregion

    }
}
