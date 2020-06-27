namespace CS_Gestion
{
    partial class FormEntidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label labelNotas;
            System.Windows.Forms.Label labelEsActivo;
            System.Windows.Forms.Label labelModificacion;
            System.Windows.Forms.Label labelCreacion;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntidad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolstripMain = new System.Windows.Forms.ToolStrip();
            this.buttonCerrar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.buttonGuardar = new System.Windows.Forms.ToolStripButton();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.textboxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelTipoPersona = new System.Windows.Forms.Label();
            this.radiobuttonTipoPersonaJuridica = new System.Windows.Forms.RadioButton();
            this.radiobuttonTipoPersonaFisica = new System.Windows.Forms.RadioButton();
            this.textboxApellido = new System.Windows.Forms.TextBox();
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNombreFantasia = new System.Windows.Forms.Label();
            this.textboxNombreFantasia = new System.Windows.Forms.TextBox();
            this.maskedtextboxCuit = new System.Windows.Forms.MaskedTextBox();
            this.labelCuit = new System.Windows.Forms.Label();
            this.textboxIngresosBrutos = new System.Windows.Forms.TextBox();
            this.labelIngresosBrutos = new System.Windows.Forms.Label();
            this.tabcontrolMain = new CardonerSistemas.TabControl();
            this.tabpageGeneral = new System.Windows.Forms.TabPage();
            this.textboxPaginaWeb = new System.Windows.Forms.TextBox();
            this.labelPaginaWeb = new System.Windows.Forms.Label();
            this.checkboxTipoTransportista = new System.Windows.Forms.CheckBox();
            this.checkboxTipoProveedor = new System.Windows.Forms.CheckBox();
            this.checkboxTipoCliente = new System.Windows.Forms.CheckBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.tabpageDomicilios = new System.Windows.Forms.TabPage();
            this.datagridviewDomicilios = new System.Windows.Forms.DataGridView();
            this.columnDomiciliosTipoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDomiciliosDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDomiciliosLocalidadNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripDomicilios = new System.Windows.Forms.ToolStrip();
            this.buttonDomiciliosAgregar = new System.Windows.Forms.ToolStripButton();
            this.buttonDomiciliosEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonDomiciliosBorrar = new System.Windows.Forms.ToolStripButton();
            this.tabpageEmails = new System.Windows.Forms.TabPage();
            this.datagridviewEmails = new System.Windows.Forms.DataGridView();
            this.columnEmailsTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmailsEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmailsNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripEmails = new System.Windows.Forms.ToolStrip();
            this.buttonEmailsAgregar = new System.Windows.Forms.ToolStripButton();
            this.buttonEmailsEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonEmailsBorrar = new System.Windows.Forms.ToolStripButton();
            this.tabpageTelefonos = new System.Windows.Forms.TabPage();
            this.datagridviewTelefonos = new System.Windows.Forms.DataGridView();
            this.columnTelefonosTipoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefonosNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripTelefonos = new System.Windows.Forms.ToolStrip();
            this.buttonTelefonosAgregar = new System.Windows.Forms.ToolStripButton();
            this.buttonTelefonosEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonTelefonosBorrar = new System.Windows.Forms.ToolStripButton();
            this.tabpageCuentasBancarias = new System.Windows.Forms.TabPage();
            this.datagridviewCuentasBancarias = new System.Windows.Forms.DataGridView();
            this.columnCuentasBancariasBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuentasBancariasTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuentasBancariasSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuentasBancariasNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripCuentasBancarias = new System.Windows.Forms.ToolStrip();
            this.buttonCuentasBancariasAgregar = new System.Windows.Forms.ToolStripButton();
            this.CuentasBancariasEditar = new System.Windows.Forms.ToolStripButton();
            this.CuentasBancariasBorrar = new System.Windows.Forms.ToolStripButton();
            this.tabpageCategorias = new System.Windows.Forms.TabPage();
            this.datagridviewCategorias = new System.Windows.Forms.DataGridView();
            this.columnCategoriasNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripCategorias = new System.Windows.Forms.ToolStrip();
            this.buttonCategoriasAgregar = new System.Windows.Forms.ToolStripButton();
            this.buttonCategoriasBorrar = new System.Windows.Forms.ToolStripButton();
            this.tabpageNotasAuditoria = new System.Windows.Forms.TabPage();
            this.checkboxEsActivo = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textboxUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.textboxId = new System.Windows.Forms.TextBox();
            this.textboxUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.textboxFechaHoraModificacion = new System.Windows.Forms.TextBox();
            this.textboxFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.textboxNotas = new System.Windows.Forms.TextBox();
            labelNotas = new System.Windows.Forms.Label();
            labelEsActivo = new System.Windows.Forms.Label();
            labelModificacion = new System.Windows.Forms.Label();
            labelCreacion = new System.Windows.Forms.Label();
            this.toolstripMain.SuspendLayout();
            this.tabcontrolMain.SuspendLayout();
            this.tabpageGeneral.SuspendLayout();
            this.tabpageDomicilios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewDomicilios)).BeginInit();
            this.toolstripDomicilios.SuspendLayout();
            this.tabpageEmails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewEmails)).BeginInit();
            this.toolstripEmails.SuspendLayout();
            this.tabpageTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewTelefonos)).BeginInit();
            this.toolstripTelefonos.SuspendLayout();
            this.tabpageCuentasBancarias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCuentasBancarias)).BeginInit();
            this.toolstripCuentasBancarias.SuspendLayout();
            this.tabpageCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCategorias)).BeginInit();
            this.toolstripCategorias.SuspendLayout();
            this.tabpageNotasAuditoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNotas
            // 
            labelNotas.AutoSize = true;
            labelNotas.Location = new System.Drawing.Point(10, 9);
            labelNotas.Name = "labelNotas";
            labelNotas.Size = new System.Drawing.Size(38, 13);
            labelNotas.TabIndex = 0;
            labelNotas.Text = "Notas:";
            // 
            // labelEsActivo
            // 
            labelEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelEsActivo.AutoSize = true;
            labelEsActivo.Location = new System.Drawing.Point(10, 119);
            labelEsActivo.Name = "labelEsActivo";
            labelEsActivo.Size = new System.Drawing.Size(40, 13);
            labelEsActivo.TabIndex = 2;
            labelEsActivo.Text = "Activo:";
            // 
            // labelModificacion
            // 
            labelModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelModificacion.AutoSize = true;
            labelModificacion.Location = new System.Drawing.Point(10, 194);
            labelModificacion.Name = "labelModificacion";
            labelModificacion.Size = new System.Drawing.Size(102, 13);
            labelModificacion.TabIndex = 9;
            labelModificacion.Text = "Ultima Modificación:";
            // 
            // labelCreacion
            // 
            labelCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelCreacion.AutoSize = true;
            labelCreacion.Location = new System.Drawing.Point(11, 168);
            labelCreacion.Name = "labelCreacion";
            labelCreacion.Size = new System.Drawing.Size(52, 13);
            labelCreacion.TabIndex = 6;
            labelCreacion.Text = "Creación:";
            // 
            // toolstripMain
            // 
            this.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonCerrar,
            this.buttonEditar,
            this.buttonCancelar,
            this.buttonGuardar});
            this.toolstripMain.Location = new System.Drawing.Point(0, 0);
            this.toolstripMain.Name = "toolstripMain";
            this.toolstripMain.Size = new System.Drawing.Size(582, 39);
            this.toolstripMain.TabIndex = 1;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonCerrar.Image = global::CS_Gestion.Properties.Resources.ImageClose32;
            this.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 36);
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonEditar.Image = global::CS_Gestion.Properties.Resources.ImageItemEdit32;
            this.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(73, 36);
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonCancelar.Image = global::CS_Gestion.Properties.Resources.ImageCancel32;
            this.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 36);
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonGuardar.Image = global::CS_Gestion.Properties.Resources.ImageOk32;
            this.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(85, 36);
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Location = new System.Drawing.Point(6, 36);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(71, 13);
            this.labelRazonSocial.TabIndex = 3;
            this.labelRazonSocial.Text = "Razón social:";
            // 
            // textboxRazonSocial
            // 
            this.textboxRazonSocial.Location = new System.Drawing.Point(118, 33);
            this.textboxRazonSocial.MaxLength = 150;
            this.textboxRazonSocial.Name = "textboxRazonSocial";
            this.textboxRazonSocial.Size = new System.Drawing.Size(367, 20);
            this.textboxRazonSocial.TabIndex = 4;
            this.textboxRazonSocial.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(6, 88);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(52, 13);
            this.labelApellido.TabIndex = 7;
            this.labelApellido.Text = "Apellidos:";
            // 
            // labelTipoPersona
            // 
            this.labelTipoPersona.AutoSize = true;
            this.labelTipoPersona.Location = new System.Drawing.Point(6, 10);
            this.labelTipoPersona.Name = "labelTipoPersona";
            this.labelTipoPersona.Size = new System.Drawing.Size(87, 13);
            this.labelTipoPersona.TabIndex = 0;
            this.labelTipoPersona.Text = "Tipo de persona:";
            // 
            // radiobuttonTipoPersonaJuridica
            // 
            this.radiobuttonTipoPersonaJuridica.AutoSize = true;
            this.radiobuttonTipoPersonaJuridica.Checked = true;
            this.radiobuttonTipoPersonaJuridica.Location = new System.Drawing.Point(118, 8);
            this.radiobuttonTipoPersonaJuridica.Name = "radiobuttonTipoPersonaJuridica";
            this.radiobuttonTipoPersonaJuridica.Size = new System.Drawing.Size(63, 17);
            this.radiobuttonTipoPersonaJuridica.TabIndex = 1;
            this.radiobuttonTipoPersonaJuridica.TabStop = true;
            this.radiobuttonTipoPersonaJuridica.Text = "Jurídica";
            this.radiobuttonTipoPersonaJuridica.UseVisualStyleBackColor = true;
            this.radiobuttonTipoPersonaJuridica.CheckedChanged += new System.EventHandler(this.TipoPersona_CheckedChanged);
            // 
            // radiobuttonTipoPersonaFisica
            // 
            this.radiobuttonTipoPersonaFisica.AutoSize = true;
            this.radiobuttonTipoPersonaFisica.Location = new System.Drawing.Point(197, 8);
            this.radiobuttonTipoPersonaFisica.Name = "radiobuttonTipoPersonaFisica";
            this.radiobuttonTipoPersonaFisica.Size = new System.Drawing.Size(54, 17);
            this.radiobuttonTipoPersonaFisica.TabIndex = 2;
            this.radiobuttonTipoPersonaFisica.Text = "Física";
            this.radiobuttonTipoPersonaFisica.UseVisualStyleBackColor = true;
            this.radiobuttonTipoPersonaFisica.CheckedChanged += new System.EventHandler(this.TipoPersona_CheckedChanged);
            // 
            // textboxApellido
            // 
            this.textboxApellido.Location = new System.Drawing.Point(118, 85);
            this.textboxApellido.MaxLength = 50;
            this.textboxApellido.Name = "textboxApellido";
            this.textboxApellido.Size = new System.Drawing.Size(198, 20);
            this.textboxApellido.TabIndex = 8;
            this.textboxApellido.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // textboxNombre
            // 
            this.textboxNombre.Location = new System.Drawing.Point(118, 111);
            this.textboxNombre.MaxLength = 50;
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(198, 20);
            this.textboxNombre.TabIndex = 10;
            this.textboxNombre.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(6, 114);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(52, 13);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombres:";
            // 
            // labelNombreFantasia
            // 
            this.labelNombreFantasia.AutoSize = true;
            this.labelNombreFantasia.Location = new System.Drawing.Point(6, 62);
            this.labelNombreFantasia.Name = "labelNombreFantasia";
            this.labelNombreFantasia.Size = new System.Drawing.Size(104, 13);
            this.labelNombreFantasia.TabIndex = 5;
            this.labelNombreFantasia.Text = "Nombre de fantasía:";
            // 
            // textboxNombreFantasia
            // 
            this.textboxNombreFantasia.Location = new System.Drawing.Point(118, 59);
            this.textboxNombreFantasia.MaxLength = 150;
            this.textboxNombreFantasia.Name = "textboxNombreFantasia";
            this.textboxNombreFantasia.Size = new System.Drawing.Size(367, 20);
            this.textboxNombreFantasia.TabIndex = 6;
            this.textboxNombreFantasia.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // maskedtextboxCuit
            // 
            this.maskedtextboxCuit.AllowPromptAsInput = false;
            this.maskedtextboxCuit.AsciiOnly = true;
            this.maskedtextboxCuit.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtextboxCuit.HidePromptOnLeave = true;
            this.maskedtextboxCuit.Location = new System.Drawing.Point(118, 137);
            this.maskedtextboxCuit.Mask = "00-00000000-0";
            this.maskedtextboxCuit.Name = "maskedtextboxCuit";
            this.maskedtextboxCuit.Size = new System.Drawing.Size(94, 20);
            this.maskedtextboxCuit.TabIndex = 12;
            this.maskedtextboxCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtextboxCuit.Enter += new System.EventHandler(this.MaskedTextBoxs_Enter);
            // 
            // labelCuit
            // 
            this.labelCuit.AutoSize = true;
            this.labelCuit.Location = new System.Drawing.Point(6, 140);
            this.labelCuit.Name = "labelCuit";
            this.labelCuit.Size = new System.Drawing.Size(35, 13);
            this.labelCuit.TabIndex = 11;
            this.labelCuit.Text = "CUIT:";
            // 
            // textboxIngresosBrutos
            // 
            this.textboxIngresosBrutos.Location = new System.Drawing.Point(118, 163);
            this.textboxIngresosBrutos.MaxLength = 20;
            this.textboxIngresosBrutos.Name = "textboxIngresosBrutos";
            this.textboxIngresosBrutos.Size = new System.Drawing.Size(133, 20);
            this.textboxIngresosBrutos.TabIndex = 14;
            this.textboxIngresosBrutos.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // labelIngresosBrutos
            // 
            this.labelIngresosBrutos.AutoSize = true;
            this.labelIngresosBrutos.Location = new System.Drawing.Point(6, 166);
            this.labelIngresosBrutos.Name = "labelIngresosBrutos";
            this.labelIngresosBrutos.Size = new System.Drawing.Size(83, 13);
            this.labelIngresosBrutos.TabIndex = 13;
            this.labelIngresosBrutos.Text = "Ingresos Brutos:";
            // 
            // tabcontrolMain
            // 
            this.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabcontrolMain.Controls.Add(this.tabpageGeneral);
            this.tabcontrolMain.Controls.Add(this.tabpageDomicilios);
            this.tabcontrolMain.Controls.Add(this.tabpageEmails);
            this.tabcontrolMain.Controls.Add(this.tabpageTelefonos);
            this.tabcontrolMain.Controls.Add(this.tabpageCuentasBancarias);
            this.tabcontrolMain.Controls.Add(this.tabpageCategorias);
            this.tabcontrolMain.Controls.Add(this.tabpageNotasAuditoria);
            this.tabcontrolMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolMain.Location = new System.Drawing.Point(0, 39);
            this.tabcontrolMain.Name = "tabcontrolMain";
            this.tabcontrolMain.SelectedIndex = 0;
            this.tabcontrolMain.Size = new System.Drawing.Size(582, 271);
            this.tabcontrolMain.TabIndex = 0;
            this.tabcontrolMain.SelectedIndexChanged += new System.EventHandler(this.TabControlChanged);
            // 
            // tabpageGeneral
            // 
            this.tabpageGeneral.Controls.Add(this.textboxPaginaWeb);
            this.tabpageGeneral.Controls.Add(this.labelPaginaWeb);
            this.tabpageGeneral.Controls.Add(this.checkboxTipoTransportista);
            this.tabpageGeneral.Controls.Add(this.checkboxTipoProveedor);
            this.tabpageGeneral.Controls.Add(this.checkboxTipoCliente);
            this.tabpageGeneral.Controls.Add(this.labelTipo);
            this.tabpageGeneral.Controls.Add(this.labelTipoPersona);
            this.tabpageGeneral.Controls.Add(this.textboxIngresosBrutos);
            this.tabpageGeneral.Controls.Add(this.labelRazonSocial);
            this.tabpageGeneral.Controls.Add(this.labelIngresosBrutos);
            this.tabpageGeneral.Controls.Add(this.textboxRazonSocial);
            this.tabpageGeneral.Controls.Add(this.labelCuit);
            this.tabpageGeneral.Controls.Add(this.labelNombreFantasia);
            this.tabpageGeneral.Controls.Add(this.maskedtextboxCuit);
            this.tabpageGeneral.Controls.Add(this.textboxNombreFantasia);
            this.tabpageGeneral.Controls.Add(this.textboxNombre);
            this.tabpageGeneral.Controls.Add(this.labelApellido);
            this.tabpageGeneral.Controls.Add(this.labelNombre);
            this.tabpageGeneral.Controls.Add(this.radiobuttonTipoPersonaJuridica);
            this.tabpageGeneral.Controls.Add(this.textboxApellido);
            this.tabpageGeneral.Controls.Add(this.radiobuttonTipoPersonaFisica);
            this.tabpageGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabpageGeneral.Name = "tabpageGeneral";
            this.tabpageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageGeneral.Size = new System.Drawing.Size(574, 242);
            this.tabpageGeneral.TabIndex = 0;
            this.tabpageGeneral.Text = "General";
            this.tabpageGeneral.UseVisualStyleBackColor = true;
            // 
            // textboxPaginaWeb
            // 
            this.textboxPaginaWeb.Location = new System.Drawing.Point(118, 189);
            this.textboxPaginaWeb.MaxLength = 200;
            this.textboxPaginaWeb.Name = "textboxPaginaWeb";
            this.textboxPaginaWeb.Size = new System.Drawing.Size(448, 20);
            this.textboxPaginaWeb.TabIndex = 16;
            this.textboxPaginaWeb.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // labelPaginaWeb
            // 
            this.labelPaginaWeb.AutoSize = true;
            this.labelPaginaWeb.Location = new System.Drawing.Point(6, 192);
            this.labelPaginaWeb.Name = "labelPaginaWeb";
            this.labelPaginaWeb.Size = new System.Drawing.Size(66, 13);
            this.labelPaginaWeb.TabIndex = 15;
            this.labelPaginaWeb.Text = "Página web:";
            // 
            // checkboxTipoTransportista
            // 
            this.checkboxTipoTransportista.AutoSize = true;
            this.checkboxTipoTransportista.Location = new System.Drawing.Point(263, 216);
            this.checkboxTipoTransportista.Name = "checkboxTipoTransportista";
            this.checkboxTipoTransportista.Size = new System.Drawing.Size(87, 17);
            this.checkboxTipoTransportista.TabIndex = 20;
            this.checkboxTipoTransportista.Text = "Transportista";
            this.checkboxTipoTransportista.UseVisualStyleBackColor = true;
            // 
            // checkboxTipoProveedor
            // 
            this.checkboxTipoProveedor.AutoSize = true;
            this.checkboxTipoProveedor.Location = new System.Drawing.Point(182, 216);
            this.checkboxTipoProveedor.Name = "checkboxTipoProveedor";
            this.checkboxTipoProveedor.Size = new System.Drawing.Size(75, 17);
            this.checkboxTipoProveedor.TabIndex = 19;
            this.checkboxTipoProveedor.Text = "Proveedor";
            this.checkboxTipoProveedor.UseVisualStyleBackColor = true;
            // 
            // checkboxTipoCliente
            // 
            this.checkboxTipoCliente.AutoSize = true;
            this.checkboxTipoCliente.Location = new System.Drawing.Point(118, 216);
            this.checkboxTipoCliente.Name = "checkboxTipoCliente";
            this.checkboxTipoCliente.Size = new System.Drawing.Size(58, 17);
            this.checkboxTipoCliente.TabIndex = 18;
            this.checkboxTipoCliente.Text = "Cliente";
            this.checkboxTipoCliente.UseVisualStyleBackColor = true;
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(6, 217);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(84, 13);
            this.labelTipo.TabIndex = 17;
            this.labelTipo.Text = "Tipo de entidad:";
            // 
            // tabpageDomicilios
            // 
            this.tabpageDomicilios.Controls.Add(this.datagridviewDomicilios);
            this.tabpageDomicilios.Controls.Add(this.toolstripDomicilios);
            this.tabpageDomicilios.Location = new System.Drawing.Point(4, 25);
            this.tabpageDomicilios.Name = "tabpageDomicilios";
            this.tabpageDomicilios.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDomicilios.Size = new System.Drawing.Size(574, 242);
            this.tabpageDomicilios.TabIndex = 2;
            this.tabpageDomicilios.Text = "Domicilios";
            this.tabpageDomicilios.UseVisualStyleBackColor = true;
            // 
            // datagridviewDomicilios
            // 
            this.datagridviewDomicilios.AllowUserToAddRows = false;
            this.datagridviewDomicilios.AllowUserToDeleteRows = false;
            this.datagridviewDomicilios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.datagridviewDomicilios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewDomicilios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDomiciliosTipoNombre,
            this.columnDomiciliosDomicilio,
            this.columnDomiciliosLocalidadNombre});
            this.datagridviewDomicilios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewDomicilios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridviewDomicilios.Location = new System.Drawing.Point(89, 3);
            this.datagridviewDomicilios.MultiSelect = false;
            this.datagridviewDomicilios.Name = "datagridviewDomicilios";
            this.datagridviewDomicilios.ReadOnly = true;
            this.datagridviewDomicilios.RowHeadersVisible = false;
            this.datagridviewDomicilios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewDomicilios.Size = new System.Drawing.Size(482, 236);
            this.datagridviewDomicilios.TabIndex = 8;
            this.datagridviewDomicilios.DoubleClick += new System.EventHandler(this.DomiciliosVer_Click);
            // 
            // columnDomiciliosTipoNombre
            // 
            this.columnDomiciliosTipoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnDomiciliosTipoNombre.DataPropertyName = "DomicilioTipoNombre";
            this.columnDomiciliosTipoNombre.HeaderText = "Tipo";
            this.columnDomiciliosTipoNombre.Name = "columnDomiciliosTipoNombre";
            this.columnDomiciliosTipoNombre.ReadOnly = true;
            this.columnDomiciliosTipoNombre.Width = 53;
            // 
            // columnDomiciliosDomicilio
            // 
            this.columnDomiciliosDomicilio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnDomiciliosDomicilio.DataPropertyName = "DomicilioParaMostrar";
            this.columnDomiciliosDomicilio.HeaderText = "Domicilio";
            this.columnDomiciliosDomicilio.Name = "columnDomiciliosDomicilio";
            this.columnDomiciliosDomicilio.ReadOnly = true;
            this.columnDomiciliosDomicilio.Width = 74;
            // 
            // columnDomiciliosLocalidadNombre
            // 
            this.columnDomiciliosLocalidadNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnDomiciliosLocalidadNombre.DataPropertyName = "LocalidadNombre";
            this.columnDomiciliosLocalidadNombre.HeaderText = "Localidad";
            this.columnDomiciliosLocalidadNombre.Name = "columnDomiciliosLocalidadNombre";
            this.columnDomiciliosLocalidadNombre.ReadOnly = true;
            this.columnDomiciliosLocalidadNombre.Width = 78;
            // 
            // toolstripDomicilios
            // 
            this.toolstripDomicilios.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolstripDomicilios.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripDomicilios.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstripDomicilios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonDomiciliosAgregar,
            this.buttonDomiciliosEditar,
            this.buttonDomiciliosBorrar});
            this.toolstripDomicilios.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolstripDomicilios.Location = new System.Drawing.Point(3, 3);
            this.toolstripDomicilios.Name = "toolstripDomicilios";
            this.toolstripDomicilios.Size = new System.Drawing.Size(86, 236);
            this.toolstripDomicilios.TabIndex = 9;
            // 
            // buttonDomiciliosAgregar
            // 
            this.buttonDomiciliosAgregar.Image = global::CS_Gestion.Properties.Resources.ImageItemAdd32;
            this.buttonDomiciliosAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDomiciliosAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonDomiciliosAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDomiciliosAgregar.Name = "buttonDomiciliosAgregar";
            this.buttonDomiciliosAgregar.Size = new System.Drawing.Size(83, 36);
            this.buttonDomiciliosAgregar.Text = "Agregar";
            this.buttonDomiciliosAgregar.Click += new System.EventHandler(this.DomiciliosAgregar_Click);
            // 
            // buttonDomiciliosEditar
            // 
            this.buttonDomiciliosEditar.Image = global::CS_Gestion.Properties.Resources.ImageItemEdit32;
            this.buttonDomiciliosEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDomiciliosEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonDomiciliosEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDomiciliosEditar.Name = "buttonDomiciliosEditar";
            this.buttonDomiciliosEditar.Size = new System.Drawing.Size(83, 36);
            this.buttonDomiciliosEditar.Text = "Editar";
            this.buttonDomiciliosEditar.Click += new System.EventHandler(this.DomiciliosEditar_Click);
            // 
            // buttonDomiciliosBorrar
            // 
            this.buttonDomiciliosBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonDomiciliosBorrar.Image")));
            this.buttonDomiciliosBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDomiciliosBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonDomiciliosBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDomiciliosBorrar.Name = "buttonDomiciliosBorrar";
            this.buttonDomiciliosBorrar.Size = new System.Drawing.Size(83, 36);
            this.buttonDomiciliosBorrar.Text = "Borrar";
            this.buttonDomiciliosBorrar.Click += new System.EventHandler(this.DomiciliosBorrar_Click);
            // 
            // tabpageEmails
            // 
            this.tabpageEmails.Controls.Add(this.datagridviewEmails);
            this.tabpageEmails.Controls.Add(this.toolstripEmails);
            this.tabpageEmails.Location = new System.Drawing.Point(4, 25);
            this.tabpageEmails.Name = "tabpageEmails";
            this.tabpageEmails.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageEmails.Size = new System.Drawing.Size(574, 242);
            this.tabpageEmails.TabIndex = 3;
            this.tabpageEmails.Text = "e-Mails";
            this.tabpageEmails.UseVisualStyleBackColor = true;
            // 
            // datagridviewEmails
            // 
            this.datagridviewEmails.AllowUserToAddRows = false;
            this.datagridviewEmails.AllowUserToDeleteRows = false;
            this.datagridviewEmails.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.datagridviewEmails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnEmailsTipo,
            this.columnEmailsEmail,
            this.columnEmailsNombre});
            this.datagridviewEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewEmails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridviewEmails.Location = new System.Drawing.Point(89, 3);
            this.datagridviewEmails.MultiSelect = false;
            this.datagridviewEmails.Name = "datagridviewEmails";
            this.datagridviewEmails.ReadOnly = true;
            this.datagridviewEmails.RowHeadersVisible = false;
            this.datagridviewEmails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewEmails.Size = new System.Drawing.Size(482, 236);
            this.datagridviewEmails.TabIndex = 10;
            this.datagridviewEmails.DoubleClick += new System.EventHandler(this.EmailsVer_Click);
            // 
            // columnEmailsTipo
            // 
            this.columnEmailsTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnEmailsTipo.DataPropertyName = "EmailTipoNombre";
            this.columnEmailsTipo.HeaderText = "Tipo";
            this.columnEmailsTipo.Name = "columnEmailsTipo";
            this.columnEmailsTipo.ReadOnly = true;
            this.columnEmailsTipo.Width = 53;
            // 
            // columnEmailsEmail
            // 
            this.columnEmailsEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnEmailsEmail.DataPropertyName = "Email";
            this.columnEmailsEmail.HeaderText = "Email";
            this.columnEmailsEmail.Name = "columnEmailsEmail";
            this.columnEmailsEmail.ReadOnly = true;
            this.columnEmailsEmail.Width = 57;
            // 
            // columnEmailsNombre
            // 
            this.columnEmailsNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnEmailsNombre.DataPropertyName = "Nombre";
            this.columnEmailsNombre.HeaderText = "Nombre";
            this.columnEmailsNombre.Name = "columnEmailsNombre";
            this.columnEmailsNombre.ReadOnly = true;
            this.columnEmailsNombre.Width = 69;
            // 
            // toolstripEmails
            // 
            this.toolstripEmails.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolstripEmails.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripEmails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstripEmails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonEmailsAgregar,
            this.buttonEmailsEditar,
            this.buttonEmailsBorrar});
            this.toolstripEmails.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolstripEmails.Location = new System.Drawing.Point(3, 3);
            this.toolstripEmails.Name = "toolstripEmails";
            this.toolstripEmails.Size = new System.Drawing.Size(86, 236);
            this.toolstripEmails.TabIndex = 11;
            // 
            // buttonEmailsAgregar
            // 
            this.buttonEmailsAgregar.Image = global::CS_Gestion.Properties.Resources.ImageItemAdd32;
            this.buttonEmailsAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmailsAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEmailsAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEmailsAgregar.Name = "buttonEmailsAgregar";
            this.buttonEmailsAgregar.Size = new System.Drawing.Size(83, 36);
            this.buttonEmailsAgregar.Text = "Agregar";
            this.buttonEmailsAgregar.Click += new System.EventHandler(this.EmailsAgregar_Click);
            // 
            // buttonEmailsEditar
            // 
            this.buttonEmailsEditar.Image = global::CS_Gestion.Properties.Resources.ImageItemEdit32;
            this.buttonEmailsEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmailsEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEmailsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEmailsEditar.Name = "buttonEmailsEditar";
            this.buttonEmailsEditar.Size = new System.Drawing.Size(83, 36);
            this.buttonEmailsEditar.Text = "Editar";
            this.buttonEmailsEditar.Click += new System.EventHandler(this.EmailsEditar_Click);
            // 
            // buttonEmailsBorrar
            // 
            this.buttonEmailsBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmailsBorrar.Image")));
            this.buttonEmailsBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmailsBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEmailsBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEmailsBorrar.Name = "buttonEmailsBorrar";
            this.buttonEmailsBorrar.Size = new System.Drawing.Size(83, 36);
            this.buttonEmailsBorrar.Text = "Borrar";
            this.buttonEmailsBorrar.Click += new System.EventHandler(this.EmailsBorrar_Click);
            // 
            // tabpageTelefonos
            // 
            this.tabpageTelefonos.Controls.Add(this.datagridviewTelefonos);
            this.tabpageTelefonos.Controls.Add(this.toolstripTelefonos);
            this.tabpageTelefonos.Location = new System.Drawing.Point(4, 25);
            this.tabpageTelefonos.Name = "tabpageTelefonos";
            this.tabpageTelefonos.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageTelefonos.Size = new System.Drawing.Size(574, 242);
            this.tabpageTelefonos.TabIndex = 4;
            this.tabpageTelefonos.Text = "Teléfonos";
            this.tabpageTelefonos.UseVisualStyleBackColor = true;
            // 
            // datagridviewTelefonos
            // 
            this.datagridviewTelefonos.AllowUserToAddRows = false;
            this.datagridviewTelefonos.AllowUserToDeleteRows = false;
            this.datagridviewTelefonos.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.datagridviewTelefonos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTelefonosTipoNombre,
            this.columnTelefonosNumero});
            this.datagridviewTelefonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewTelefonos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridviewTelefonos.Location = new System.Drawing.Point(89, 3);
            this.datagridviewTelefonos.MultiSelect = false;
            this.datagridviewTelefonos.Name = "datagridviewTelefonos";
            this.datagridviewTelefonos.ReadOnly = true;
            this.datagridviewTelefonos.RowHeadersVisible = false;
            this.datagridviewTelefonos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewTelefonos.Size = new System.Drawing.Size(482, 236);
            this.datagridviewTelefonos.TabIndex = 12;
            this.datagridviewTelefonos.DoubleClick += new System.EventHandler(this.TelefonosVer_Click);
            // 
            // columnTelefonosTipoNombre
            // 
            this.columnTelefonosTipoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnTelefonosTipoNombre.DataPropertyName = "TelefonoTipoNombre";
            this.columnTelefonosTipoNombre.HeaderText = "Tipo";
            this.columnTelefonosTipoNombre.Name = "columnTelefonosTipoNombre";
            this.columnTelefonosTipoNombre.ReadOnly = true;
            this.columnTelefonosTipoNombre.Width = 53;
            // 
            // columnTelefonosNumero
            // 
            this.columnTelefonosNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnTelefonosNumero.DataPropertyName = "Numero";
            this.columnTelefonosNumero.HeaderText = "Número";
            this.columnTelefonosNumero.Name = "columnTelefonosNumero";
            this.columnTelefonosNumero.ReadOnly = true;
            this.columnTelefonosNumero.Width = 69;
            // 
            // toolstripTelefonos
            // 
            this.toolstripTelefonos.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolstripTelefonos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripTelefonos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstripTelefonos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonTelefonosAgregar,
            this.buttonTelefonosEditar,
            this.buttonTelefonosBorrar});
            this.toolstripTelefonos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolstripTelefonos.Location = new System.Drawing.Point(3, 3);
            this.toolstripTelefonos.Name = "toolstripTelefonos";
            this.toolstripTelefonos.Size = new System.Drawing.Size(86, 236);
            this.toolstripTelefonos.TabIndex = 13;
            // 
            // buttonTelefonosAgregar
            // 
            this.buttonTelefonosAgregar.Image = global::CS_Gestion.Properties.Resources.ImageItemAdd32;
            this.buttonTelefonosAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTelefonosAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonTelefonosAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonTelefonosAgregar.Name = "buttonTelefonosAgregar";
            this.buttonTelefonosAgregar.Size = new System.Drawing.Size(83, 36);
            this.buttonTelefonosAgregar.Text = "Agregar";
            this.buttonTelefonosAgregar.Click += new System.EventHandler(this.TelefonosAgregar_Click);
            // 
            // buttonTelefonosEditar
            // 
            this.buttonTelefonosEditar.Image = global::CS_Gestion.Properties.Resources.ImageItemEdit32;
            this.buttonTelefonosEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTelefonosEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonTelefonosEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonTelefonosEditar.Name = "buttonTelefonosEditar";
            this.buttonTelefonosEditar.Size = new System.Drawing.Size(83, 36);
            this.buttonTelefonosEditar.Text = "Editar";
            this.buttonTelefonosEditar.Click += new System.EventHandler(this.TelefonosEditar_Click);
            // 
            // buttonTelefonosBorrar
            // 
            this.buttonTelefonosBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonTelefonosBorrar.Image")));
            this.buttonTelefonosBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTelefonosBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonTelefonosBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonTelefonosBorrar.Name = "buttonTelefonosBorrar";
            this.buttonTelefonosBorrar.Size = new System.Drawing.Size(83, 36);
            this.buttonTelefonosBorrar.Text = "Borrar";
            this.buttonTelefonosBorrar.Click += new System.EventHandler(this.TelefonosBorrar_Click);
            // 
            // tabpageCuentasBancarias
            // 
            this.tabpageCuentasBancarias.Controls.Add(this.datagridviewCuentasBancarias);
            this.tabpageCuentasBancarias.Controls.Add(this.toolstripCuentasBancarias);
            this.tabpageCuentasBancarias.Location = new System.Drawing.Point(4, 25);
            this.tabpageCuentasBancarias.Name = "tabpageCuentasBancarias";
            this.tabpageCuentasBancarias.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCuentasBancarias.Size = new System.Drawing.Size(574, 242);
            this.tabpageCuentasBancarias.TabIndex = 5;
            this.tabpageCuentasBancarias.Text = "Cuentas Bancarias";
            this.tabpageCuentasBancarias.UseVisualStyleBackColor = true;
            // 
            // datagridviewCuentasBancarias
            // 
            this.datagridviewCuentasBancarias.AllowUserToAddRows = false;
            this.datagridviewCuentasBancarias.AllowUserToDeleteRows = false;
            this.datagridviewCuentasBancarias.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.datagridviewCuentasBancarias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridviewCuentasBancarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewCuentasBancarias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCuentasBancariasBanco,
            this.columnCuentasBancariasTipo,
            this.columnCuentasBancariasSucursal,
            this.columnCuentasBancariasNumero});
            this.datagridviewCuentasBancarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewCuentasBancarias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridviewCuentasBancarias.Location = new System.Drawing.Point(89, 3);
            this.datagridviewCuentasBancarias.MultiSelect = false;
            this.datagridviewCuentasBancarias.Name = "datagridviewCuentasBancarias";
            this.datagridviewCuentasBancarias.ReadOnly = true;
            this.datagridviewCuentasBancarias.RowHeadersVisible = false;
            this.datagridviewCuentasBancarias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewCuentasBancarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewCuentasBancarias.Size = new System.Drawing.Size(482, 236);
            this.datagridviewCuentasBancarias.TabIndex = 12;
            this.datagridviewCuentasBancarias.DoubleClick += new System.EventHandler(this.CuentaBancariasVer_Click);
            // 
            // columnCuentasBancariasBanco
            // 
            this.columnCuentasBancariasBanco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnCuentasBancariasBanco.DataPropertyName = "BancoNombre";
            this.columnCuentasBancariasBanco.HeaderText = "Banco";
            this.columnCuentasBancariasBanco.Name = "columnCuentasBancariasBanco";
            this.columnCuentasBancariasBanco.ReadOnly = true;
            this.columnCuentasBancariasBanco.Width = 63;
            // 
            // columnCuentasBancariasTipo
            // 
            this.columnCuentasBancariasTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnCuentasBancariasTipo.DataPropertyName = "TipoNombre";
            this.columnCuentasBancariasTipo.HeaderText = "Tipo";
            this.columnCuentasBancariasTipo.Name = "columnCuentasBancariasTipo";
            this.columnCuentasBancariasTipo.ReadOnly = true;
            this.columnCuentasBancariasTipo.Width = 53;
            // 
            // columnCuentasBancariasSucursal
            // 
            this.columnCuentasBancariasSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnCuentasBancariasSucursal.DataPropertyName = "Sucursal";
            this.columnCuentasBancariasSucursal.HeaderText = "Sucursal";
            this.columnCuentasBancariasSucursal.Name = "columnCuentasBancariasSucursal";
            this.columnCuentasBancariasSucursal.ReadOnly = true;
            this.columnCuentasBancariasSucursal.Width = 73;
            // 
            // columnCuentasBancariasNumero
            // 
            this.columnCuentasBancariasNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnCuentasBancariasNumero.DataPropertyName = "Numero";
            this.columnCuentasBancariasNumero.HeaderText = "Número";
            this.columnCuentasBancariasNumero.Name = "columnCuentasBancariasNumero";
            this.columnCuentasBancariasNumero.ReadOnly = true;
            this.columnCuentasBancariasNumero.Width = 69;
            // 
            // toolstripCuentasBancarias
            // 
            this.toolstripCuentasBancarias.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolstripCuentasBancarias.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripCuentasBancarias.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstripCuentasBancarias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonCuentasBancariasAgregar,
            this.CuentasBancariasEditar,
            this.CuentasBancariasBorrar});
            this.toolstripCuentasBancarias.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolstripCuentasBancarias.Location = new System.Drawing.Point(3, 3);
            this.toolstripCuentasBancarias.Name = "toolstripCuentasBancarias";
            this.toolstripCuentasBancarias.Size = new System.Drawing.Size(86, 236);
            this.toolstripCuentasBancarias.TabIndex = 13;
            // 
            // buttonCuentasBancariasAgregar
            // 
            this.buttonCuentasBancariasAgregar.Image = global::CS_Gestion.Properties.Resources.ImageItemAdd32;
            this.buttonCuentasBancariasAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCuentasBancariasAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCuentasBancariasAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCuentasBancariasAgregar.Name = "buttonCuentasBancariasAgregar";
            this.buttonCuentasBancariasAgregar.Size = new System.Drawing.Size(83, 36);
            this.buttonCuentasBancariasAgregar.Text = "Agregar";
            this.buttonCuentasBancariasAgregar.Click += new System.EventHandler(this.CuentaBancariasAgregar_Click);
            // 
            // CuentasBancariasEditar
            // 
            this.CuentasBancariasEditar.Image = global::CS_Gestion.Properties.Resources.ImageItemEdit32;
            this.CuentasBancariasEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CuentasBancariasEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CuentasBancariasEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CuentasBancariasEditar.Name = "CuentasBancariasEditar";
            this.CuentasBancariasEditar.Size = new System.Drawing.Size(83, 36);
            this.CuentasBancariasEditar.Text = "Editar";
            this.CuentasBancariasEditar.Click += new System.EventHandler(this.CuentaBancariasEditar_Click);
            // 
            // CuentasBancariasBorrar
            // 
            this.CuentasBancariasBorrar.Image = ((System.Drawing.Image)(resources.GetObject("CuentasBancariasBorrar.Image")));
            this.CuentasBancariasBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CuentasBancariasBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CuentasBancariasBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CuentasBancariasBorrar.Name = "CuentasBancariasBorrar";
            this.CuentasBancariasBorrar.Size = new System.Drawing.Size(83, 36);
            this.CuentasBancariasBorrar.Text = "Borrar";
            this.CuentasBancariasBorrar.Click += new System.EventHandler(this.CuentaBancariasBorrar_Click);
            // 
            // tabpageCategorias
            // 
            this.tabpageCategorias.Controls.Add(this.datagridviewCategorias);
            this.tabpageCategorias.Controls.Add(this.toolstripCategorias);
            this.tabpageCategorias.Location = new System.Drawing.Point(4, 25);
            this.tabpageCategorias.Name = "tabpageCategorias";
            this.tabpageCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageCategorias.Size = new System.Drawing.Size(574, 242);
            this.tabpageCategorias.TabIndex = 6;
            this.tabpageCategorias.Text = "Categorías";
            this.tabpageCategorias.UseVisualStyleBackColor = true;
            // 
            // datagridviewCategorias
            // 
            this.datagridviewCategorias.AllowUserToAddRows = false;
            this.datagridviewCategorias.AllowUserToDeleteRows = false;
            this.datagridviewCategorias.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.datagridviewCategorias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridviewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCategoriasNombre});
            this.datagridviewCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridviewCategorias.Location = new System.Drawing.Point(89, 3);
            this.datagridviewCategorias.MultiSelect = false;
            this.datagridviewCategorias.Name = "datagridviewCategorias";
            this.datagridviewCategorias.ReadOnly = true;
            this.datagridviewCategorias.RowHeadersVisible = false;
            this.datagridviewCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewCategorias.Size = new System.Drawing.Size(482, 236);
            this.datagridviewCategorias.TabIndex = 14;
            // 
            // columnCategoriasNombre
            // 
            this.columnCategoriasNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnCategoriasNombre.DataPropertyName = "Nombre";
            this.columnCategoriasNombre.HeaderText = "Nombre";
            this.columnCategoriasNombre.Name = "columnCategoriasNombre";
            this.columnCategoriasNombre.ReadOnly = true;
            this.columnCategoriasNombre.Width = 69;
            // 
            // toolstripCategorias
            // 
            this.toolstripCategorias.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolstripCategorias.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripCategorias.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolstripCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonCategoriasAgregar,
            this.buttonCategoriasBorrar});
            this.toolstripCategorias.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolstripCategorias.Location = new System.Drawing.Point(3, 3);
            this.toolstripCategorias.Name = "toolstripCategorias";
            this.toolstripCategorias.Size = new System.Drawing.Size(86, 236);
            this.toolstripCategorias.TabIndex = 15;
            // 
            // buttonCategoriasAgregar
            // 
            this.buttonCategoriasAgregar.Image = global::CS_Gestion.Properties.Resources.ImageItemAdd32;
            this.buttonCategoriasAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategoriasAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCategoriasAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCategoriasAgregar.Name = "buttonCategoriasAgregar";
            this.buttonCategoriasAgregar.Size = new System.Drawing.Size(83, 36);
            this.buttonCategoriasAgregar.Text = "Agregar";
            this.buttonCategoriasAgregar.Click += new System.EventHandler(this.CategoriasAgregar_Click);
            // 
            // buttonCategoriasBorrar
            // 
            this.buttonCategoriasBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCategoriasBorrar.Image")));
            this.buttonCategoriasBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategoriasBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCategoriasBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCategoriasBorrar.Name = "buttonCategoriasBorrar";
            this.buttonCategoriasBorrar.Size = new System.Drawing.Size(83, 36);
            this.buttonCategoriasBorrar.Text = "Borrar";
            this.buttonCategoriasBorrar.Click += new System.EventHandler(this.CategoriasBorrar_Click);
            // 
            // tabpageNotasAuditoria
            // 
            this.tabpageNotasAuditoria.Controls.Add(this.checkboxEsActivo);
            this.tabpageNotasAuditoria.Controls.Add(labelEsActivo);
            this.tabpageNotasAuditoria.Controls.Add(this.labelId);
            this.tabpageNotasAuditoria.Controls.Add(this.textboxUsuarioModificacion);
            this.tabpageNotasAuditoria.Controls.Add(this.textboxId);
            this.tabpageNotasAuditoria.Controls.Add(this.textboxUsuarioCreacion);
            this.tabpageNotasAuditoria.Controls.Add(this.textboxFechaHoraModificacion);
            this.tabpageNotasAuditoria.Controls.Add(this.textboxFechaHoraCreacion);
            this.tabpageNotasAuditoria.Controls.Add(labelModificacion);
            this.tabpageNotasAuditoria.Controls.Add(labelCreacion);
            this.tabpageNotasAuditoria.Controls.Add(labelNotas);
            this.tabpageNotasAuditoria.Controls.Add(this.textboxNotas);
            this.tabpageNotasAuditoria.Location = new System.Drawing.Point(4, 25);
            this.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria";
            this.tabpageNotasAuditoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageNotasAuditoria.Size = new System.Drawing.Size(574, 242);
            this.tabpageNotasAuditoria.TabIndex = 1;
            this.tabpageNotasAuditoria.Text = "Notas y Auditoría";
            this.tabpageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // checkboxEsActivo
            // 
            this.checkboxEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxEsActivo.AutoSize = true;
            this.checkboxEsActivo.Location = new System.Drawing.Point(118, 119);
            this.checkboxEsActivo.Name = "checkboxEsActivo";
            this.checkboxEsActivo.Size = new System.Drawing.Size(15, 14);
            this.checkboxEsActivo.TabIndex = 3;
            this.checkboxEsActivo.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(11, 142);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id:";
            // 
            // textboxUsuarioModificacion
            // 
            this.textboxUsuarioModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxUsuarioModificacion.Location = new System.Drawing.Point(245, 191);
            this.textboxUsuarioModificacion.MaxLength = 50;
            this.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion";
            this.textboxUsuarioModificacion.ReadOnly = true;
            this.textboxUsuarioModificacion.Size = new System.Drawing.Size(259, 20);
            this.textboxUsuarioModificacion.TabIndex = 11;
            // 
            // textboxId
            // 
            this.textboxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxId.Location = new System.Drawing.Point(118, 139);
            this.textboxId.MaxLength = 10;
            this.textboxId.Name = "textboxId";
            this.textboxId.ReadOnly = true;
            this.textboxId.Size = new System.Drawing.Size(72, 20);
            this.textboxId.TabIndex = 5;
            this.textboxId.TabStop = false;
            this.textboxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxUsuarioCreacion
            // 
            this.textboxUsuarioCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxUsuarioCreacion.Location = new System.Drawing.Point(245, 165);
            this.textboxUsuarioCreacion.MaxLength = 50;
            this.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion";
            this.textboxUsuarioCreacion.ReadOnly = true;
            this.textboxUsuarioCreacion.Size = new System.Drawing.Size(259, 20);
            this.textboxUsuarioCreacion.TabIndex = 8;
            // 
            // textboxFechaHoraModificacion
            // 
            this.textboxFechaHoraModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxFechaHoraModificacion.Location = new System.Drawing.Point(118, 191);
            this.textboxFechaHoraModificacion.MaxLength = 0;
            this.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion";
            this.textboxFechaHoraModificacion.ReadOnly = true;
            this.textboxFechaHoraModificacion.Size = new System.Drawing.Size(121, 20);
            this.textboxFechaHoraModificacion.TabIndex = 10;
            this.textboxFechaHoraModificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxFechaHoraCreacion
            // 
            this.textboxFechaHoraCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxFechaHoraCreacion.Location = new System.Drawing.Point(118, 165);
            this.textboxFechaHoraCreacion.MaxLength = 0;
            this.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion";
            this.textboxFechaHoraCreacion.ReadOnly = true;
            this.textboxFechaHoraCreacion.Size = new System.Drawing.Size(121, 20);
            this.textboxFechaHoraCreacion.TabIndex = 7;
            this.textboxFechaHoraCreacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxNotas
            // 
            this.textboxNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxNotas.Location = new System.Drawing.Point(118, 6);
            this.textboxNotas.MaxLength = 0;
            this.textboxNotas.Multiline = true;
            this.textboxNotas.Name = "textboxNotas";
            this.textboxNotas.Size = new System.Drawing.Size(448, 107);
            this.textboxNotas.TabIndex = 1;
            this.textboxNotas.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // FormEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 310);
            this.Controls.Add(this.tabcontrolMain);
            this.Controls.Add(this.toolstripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormEntidad";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Entidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.this_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.this_KeyPress);
            this.toolstripMain.ResumeLayout(false);
            this.toolstripMain.PerformLayout();
            this.tabcontrolMain.ResumeLayout(false);
            this.tabpageGeneral.ResumeLayout(false);
            this.tabpageGeneral.PerformLayout();
            this.tabpageDomicilios.ResumeLayout(false);
            this.tabpageDomicilios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewDomicilios)).EndInit();
            this.toolstripDomicilios.ResumeLayout(false);
            this.toolstripDomicilios.PerformLayout();
            this.tabpageEmails.ResumeLayout(false);
            this.tabpageEmails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewEmails)).EndInit();
            this.toolstripEmails.ResumeLayout(false);
            this.toolstripEmails.PerformLayout();
            this.tabpageTelefonos.ResumeLayout(false);
            this.tabpageTelefonos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewTelefonos)).EndInit();
            this.toolstripTelefonos.ResumeLayout(false);
            this.toolstripTelefonos.PerformLayout();
            this.tabpageCuentasBancarias.ResumeLayout(false);
            this.tabpageCuentasBancarias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCuentasBancarias)).EndInit();
            this.toolstripCuentasBancarias.ResumeLayout(false);
            this.toolstripCuentasBancarias.PerformLayout();
            this.tabpageCategorias.ResumeLayout(false);
            this.tabpageCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCategorias)).EndInit();
            this.toolstripCategorias.ResumeLayout(false);
            this.toolstripCategorias.PerformLayout();
            this.tabpageNotasAuditoria.ResumeLayout(false);
            this.tabpageNotasAuditoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolstripMain;
        internal System.Windows.Forms.ToolStripButton buttonCerrar;
        internal System.Windows.Forms.ToolStripButton buttonEditar;
        internal System.Windows.Forms.ToolStripButton buttonCancelar;
        internal System.Windows.Forms.ToolStripButton buttonGuardar;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox textboxRazonSocial;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelTipoPersona;
        private System.Windows.Forms.RadioButton radiobuttonTipoPersonaJuridica;
        private System.Windows.Forms.RadioButton radiobuttonTipoPersonaFisica;
        private System.Windows.Forms.TextBox textboxApellido;
        private System.Windows.Forms.TextBox textboxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNombreFantasia;
        private System.Windows.Forms.TextBox textboxNombreFantasia;
        internal System.Windows.Forms.MaskedTextBox maskedtextboxCuit;
        private System.Windows.Forms.Label labelCuit;
        private System.Windows.Forms.TextBox textboxIngresosBrutos;
        private System.Windows.Forms.Label labelIngresosBrutos;
        private CardonerSistemas.TabControl tabcontrolMain;
        private System.Windows.Forms.TabPage tabpageGeneral;
        private System.Windows.Forms.TabPage tabpageNotasAuditoria;
        internal System.Windows.Forms.TextBox textboxNotas;
        internal System.Windows.Forms.CheckBox checkboxEsActivo;
        internal System.Windows.Forms.Label labelId;
        internal System.Windows.Forms.TextBox textboxUsuarioModificacion;
        internal System.Windows.Forms.TextBox textboxId;
        internal System.Windows.Forms.TextBox textboxUsuarioCreacion;
        internal System.Windows.Forms.TextBox textboxFechaHoraModificacion;
        internal System.Windows.Forms.TextBox textboxFechaHoraCreacion;
        private System.Windows.Forms.TabPage tabpageDomicilios;
        internal System.Windows.Forms.DataGridView datagridviewDomicilios;
        internal System.Windows.Forms.ToolStrip toolstripDomicilios;
        internal System.Windows.Forms.ToolStripButton buttonDomiciliosAgregar;
        internal System.Windows.Forms.ToolStripButton buttonDomiciliosEditar;
        internal System.Windows.Forms.ToolStripButton buttonDomiciliosBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDomiciliosTipoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDomiciliosDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDomiciliosLocalidadNombre;
        private System.Windows.Forms.TabPage tabpageEmails;
        internal System.Windows.Forms.DataGridView datagridviewEmails;
        internal System.Windows.Forms.ToolStrip toolstripEmails;
        internal System.Windows.Forms.ToolStripButton buttonEmailsAgregar;
        internal System.Windows.Forms.ToolStripButton buttonEmailsEditar;
        internal System.Windows.Forms.ToolStripButton buttonEmailsBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmailsTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmailsEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmailsNombre;
        private System.Windows.Forms.TabPage tabpageTelefonos;
        internal System.Windows.Forms.DataGridView datagridviewTelefonos;
        internal System.Windows.Forms.ToolStrip toolstripTelefonos;
        internal System.Windows.Forms.ToolStripButton buttonTelefonosAgregar;
        internal System.Windows.Forms.ToolStripButton buttonTelefonosEditar;
        internal System.Windows.Forms.ToolStripButton buttonTelefonosBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefonosTipoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefonosNumero;
        private System.Windows.Forms.TabPage tabpageCuentasBancarias;
        internal System.Windows.Forms.DataGridView datagridviewCuentasBancarias;
        internal System.Windows.Forms.ToolStrip toolstripCuentasBancarias;
        internal System.Windows.Forms.ToolStripButton buttonCuentasBancariasAgregar;
        internal System.Windows.Forms.ToolStripButton CuentasBancariasEditar;
        internal System.Windows.Forms.ToolStripButton CuentasBancariasBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuentasBancariasBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuentasBancariasTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuentasBancariasSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuentasBancariasNumero;
        private System.Windows.Forms.CheckBox checkboxTipoCliente;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.CheckBox checkboxTipoTransportista;
        private System.Windows.Forms.CheckBox checkboxTipoProveedor;
        private System.Windows.Forms.TabPage tabpageCategorias;
        internal System.Windows.Forms.DataGridView datagridviewCategorias;
        internal System.Windows.Forms.ToolStrip toolstripCategorias;
        internal System.Windows.Forms.ToolStripButton buttonCategoriasAgregar;
        internal System.Windows.Forms.ToolStripButton buttonCategoriasBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategoriasNombre;
        private System.Windows.Forms.TextBox textboxPaginaWeb;
        private System.Windows.Forms.Label labelPaginaWeb;
    }
}