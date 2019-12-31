﻿namespace CS_Gestion
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
            this.tabpageDomicilios = new System.Windows.Forms.TabPage();
            this.datagridviewDomicilios = new System.Windows.Forms.DataGridView();
            this.columnDomiciliosTipoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDomiciliosDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDomiciliosLocalidadNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolstripDomicilios = new System.Windows.Forms.ToolStrip();
            this.buttonDomiciliosAgregar = new System.Windows.Forms.ToolStripButton();
            this.buttonDomiciliosEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonDomiciliosBorrar = new System.Windows.Forms.ToolStripButton();
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
            labelEsActivo.Location = new System.Drawing.Point(10, 90);
            labelEsActivo.Name = "labelEsActivo";
            labelEsActivo.Size = new System.Drawing.Size(40, 13);
            labelEsActivo.TabIndex = 2;
            labelEsActivo.Text = "Activo:";
            // 
            // labelModificacion
            // 
            labelModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelModificacion.AutoSize = true;
            labelModificacion.Location = new System.Drawing.Point(10, 165);
            labelModificacion.Name = "labelModificacion";
            labelModificacion.Size = new System.Drawing.Size(102, 13);
            labelModificacion.TabIndex = 9;
            labelModificacion.Text = "Ultima Modificación:";
            // 
            // labelCreacion
            // 
            labelCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelCreacion.AutoSize = true;
            labelCreacion.Location = new System.Drawing.Point(11, 139);
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
            this.toolstripMain.Size = new System.Drawing.Size(522, 39);
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
            this.textboxIngresosBrutos.MaxLength = 12;
            this.textboxIngresosBrutos.Name = "textboxIngresosBrutos";
            this.textboxIngresosBrutos.Size = new System.Drawing.Size(94, 20);
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
            this.tabcontrolMain.Controls.Add(this.tabpageNotasAuditoria);
            this.tabcontrolMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolMain.Location = new System.Drawing.Point(0, 39);
            this.tabcontrolMain.Name = "tabcontrolMain";
            this.tabcontrolMain.SelectedIndex = 0;
            this.tabcontrolMain.Size = new System.Drawing.Size(522, 219);
            this.tabcontrolMain.TabIndex = 0;
            this.tabcontrolMain.SelectedIndexChanged += new System.EventHandler(this.TabControlChanged);
            // 
            // tabpageGeneral
            // 
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
            this.tabpageGeneral.Size = new System.Drawing.Size(514, 190);
            this.tabpageGeneral.TabIndex = 0;
            this.tabpageGeneral.Text = "General";
            this.tabpageGeneral.UseVisualStyleBackColor = true;
            // 
            // tabpageDomicilios
            // 
            this.tabpageDomicilios.Controls.Add(this.datagridviewDomicilios);
            this.tabpageDomicilios.Controls.Add(this.toolstripDomicilios);
            this.tabpageDomicilios.Location = new System.Drawing.Point(4, 25);
            this.tabpageDomicilios.Name = "tabpageDomicilios";
            this.tabpageDomicilios.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageDomicilios.Size = new System.Drawing.Size(514, 190);
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
            this.datagridviewDomicilios.Size = new System.Drawing.Size(422, 184);
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
            this.toolstripDomicilios.Size = new System.Drawing.Size(86, 184);
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
            this.buttonDomiciliosBorrar.Image = global::CS_Gestion.Properties.Resources.ImageItemDelete32;
            this.buttonDomiciliosBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDomiciliosBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonDomiciliosBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonDomiciliosBorrar.Name = "buttonDomiciliosBorrar";
            this.buttonDomiciliosBorrar.Size = new System.Drawing.Size(83, 36);
            this.buttonDomiciliosBorrar.Text = "Borrar";
            this.buttonDomiciliosBorrar.Click += new System.EventHandler(this.DomiciliosBorrar_Click);
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
            this.tabpageNotasAuditoria.Size = new System.Drawing.Size(514, 190);
            this.tabpageNotasAuditoria.TabIndex = 1;
            this.tabpageNotasAuditoria.Text = "Notas y Auditoría";
            this.tabpageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // checkboxEsActivo
            // 
            this.checkboxEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxEsActivo.AutoSize = true;
            this.checkboxEsActivo.Location = new System.Drawing.Point(118, 90);
            this.checkboxEsActivo.Name = "checkboxEsActivo";
            this.checkboxEsActivo.Size = new System.Drawing.Size(15, 14);
            this.checkboxEsActivo.TabIndex = 3;
            this.checkboxEsActivo.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(11, 113);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id:";
            // 
            // textboxUsuarioModificacion
            // 
            this.textboxUsuarioModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxUsuarioModificacion.Location = new System.Drawing.Point(245, 162);
            this.textboxUsuarioModificacion.MaxLength = 50;
            this.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion";
            this.textboxUsuarioModificacion.ReadOnly = true;
            this.textboxUsuarioModificacion.Size = new System.Drawing.Size(259, 20);
            this.textboxUsuarioModificacion.TabIndex = 11;
            // 
            // textboxId
            // 
            this.textboxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxId.Location = new System.Drawing.Point(118, 110);
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
            this.textboxUsuarioCreacion.Location = new System.Drawing.Point(245, 136);
            this.textboxUsuarioCreacion.MaxLength = 50;
            this.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion";
            this.textboxUsuarioCreacion.ReadOnly = true;
            this.textboxUsuarioCreacion.Size = new System.Drawing.Size(259, 20);
            this.textboxUsuarioCreacion.TabIndex = 8;
            // 
            // textboxFechaHoraModificacion
            // 
            this.textboxFechaHoraModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxFechaHoraModificacion.Location = new System.Drawing.Point(118, 162);
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
            this.textboxFechaHoraCreacion.Location = new System.Drawing.Point(118, 136);
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
            this.textboxNotas.Size = new System.Drawing.Size(386, 78);
            this.textboxNotas.TabIndex = 1;
            this.textboxNotas.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // FormEntidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 258);
            this.Controls.Add(this.tabcontrolMain);
            this.Controls.Add(this.toolstripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FormEntidad";
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
    }
}