namespace CS_Gestion
{
    partial class FormEntidadCuentaBancaria
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
            System.Windows.Forms.Label labelNumero;
            System.Windows.Forms.Label labelSucursal;
            System.Windows.Forms.Label labelBanco;
            System.Windows.Forms.Label labelEsActivo;
            System.Windows.Forms.Label labelModificacion;
            System.Windows.Forms.Label labelCreacion;
            System.Windows.Forms.Label labelNotas;
            System.Windows.Forms.Label labelTipo;
            System.Windows.Forms.Label labelCbuAlias;
            System.Windows.Forms.Label labelCbu;
            this.toolstripMain = new System.Windows.Forms.ToolStrip();
            this.buttonCerrar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.buttonGuardar = new System.Windows.Forms.ToolStripButton();
            this.tabMain = new CardonerSistemas.TabControl();
            this.tabpageGeneral = new System.Windows.Forms.TabPage();
            this.textboxTitular = new System.Windows.Forms.TextBox();
            this.labelTitular = new System.Windows.Forms.Label();
            this.labelCuit = new System.Windows.Forms.Label();
            this.maskedtextboxCuit = new System.Windows.Forms.MaskedTextBox();
            this.maskedtextboxSucursal = new System.Windows.Forms.MaskedTextBox();
            this.maskedtextboxCbu = new System.Windows.Forms.MaskedTextBox();
            this.textboxCbuAlias = new System.Windows.Forms.TextBox();
            this.comboboxTipo = new System.Windows.Forms.ComboBox();
            this.comboboxBanco = new System.Windows.Forms.ComboBox();
            this.textboxNumero = new System.Windows.Forms.TextBox();
            this.tabpageNotasAuditoria = new System.Windows.Forms.TabPage();
            this.checkboxEsActivo = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textboxUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.textboxId = new System.Windows.Forms.TextBox();
            this.textboxUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.textboxFechaHoraModificacion = new System.Windows.Forms.TextBox();
            this.textboxFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.textboxNotas = new System.Windows.Forms.TextBox();
            this.textboxIdentificacion = new System.Windows.Forms.TextBox();
            this.labelIdentificacion = new System.Windows.Forms.Label();
            labelNumero = new System.Windows.Forms.Label();
            labelSucursal = new System.Windows.Forms.Label();
            labelBanco = new System.Windows.Forms.Label();
            labelEsActivo = new System.Windows.Forms.Label();
            labelModificacion = new System.Windows.Forms.Label();
            labelCreacion = new System.Windows.Forms.Label();
            labelNotas = new System.Windows.Forms.Label();
            labelTipo = new System.Windows.Forms.Label();
            labelCbuAlias = new System.Windows.Forms.Label();
            labelCbu = new System.Windows.Forms.Label();
            this.toolstripMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabpageGeneral.SuspendLayout();
            this.tabpageNotasAuditoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new System.Drawing.Point(8, 89);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new System.Drawing.Size(47, 13);
            labelNumero.TabIndex = 6;
            labelNumero.Text = "Número:";
            // 
            // labelSucursal
            // 
            labelSucursal.AutoSize = true;
            labelSucursal.Location = new System.Drawing.Point(8, 63);
            labelSucursal.Name = "labelSucursal";
            labelSucursal.Size = new System.Drawing.Size(51, 13);
            labelSucursal.TabIndex = 4;
            labelSucursal.Text = "Sucursal:";
            // 
            // labelBanco
            // 
            labelBanco.AutoSize = true;
            labelBanco.Location = new System.Drawing.Point(8, 10);
            labelBanco.Name = "labelBanco";
            labelBanco.Size = new System.Drawing.Size(41, 13);
            labelBanco.TabIndex = 0;
            labelBanco.Text = "Banco:";
            // 
            // labelEsActivo
            // 
            labelEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelEsActivo.AutoSize = true;
            labelEsActivo.Location = new System.Drawing.Point(10, 120);
            labelEsActivo.Name = "labelEsActivo";
            labelEsActivo.Size = new System.Drawing.Size(40, 13);
            labelEsActivo.TabIndex = 2;
            labelEsActivo.Text = "Activo:";
            // 
            // labelModificacion
            // 
            labelModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelModificacion.AutoSize = true;
            labelModificacion.Location = new System.Drawing.Point(10, 195);
            labelModificacion.Name = "labelModificacion";
            labelModificacion.Size = new System.Drawing.Size(102, 13);
            labelModificacion.TabIndex = 9;
            labelModificacion.Text = "Ultima Modificación:";
            // 
            // labelCreacion
            // 
            labelCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelCreacion.AutoSize = true;
            labelCreacion.Location = new System.Drawing.Point(11, 169);
            labelCreacion.Name = "labelCreacion";
            labelCreacion.Size = new System.Drawing.Size(52, 13);
            labelCreacion.TabIndex = 6;
            labelCreacion.Text = "Creación:";
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
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new System.Drawing.Point(8, 37);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new System.Drawing.Size(31, 13);
            labelTipo.TabIndex = 2;
            labelTipo.Text = "Tipo:";
            // 
            // labelCbuAlias
            // 
            labelCbuAlias.AutoSize = true;
            labelCbuAlias.Location = new System.Drawing.Point(8, 141);
            labelCbuAlias.Name = "labelCbuAlias";
            labelCbuAlias.Size = new System.Drawing.Size(57, 13);
            labelCbuAlias.TabIndex = 10;
            labelCbuAlias.Text = "CBU Alias:";
            // 
            // labelCbu
            // 
            labelCbu.AutoSize = true;
            labelCbu.Location = new System.Drawing.Point(8, 115);
            labelCbu.Name = "labelCbu";
            labelCbu.Size = new System.Drawing.Size(32, 13);
            labelCbu.TabIndex = 8;
            labelCbu.Text = "CBU:";
            // 
            // toolstripMain
            // 
            this.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonCerrar,
            this.buttonEditar,
            this.buttonCancelar,
            this.buttonGuardar});
            this.toolstripMain.Location = new System.Drawing.Point(0, 0);
            this.toolstripMain.Name = "toolstripMain";
            this.toolstripMain.Size = new System.Drawing.Size(520, 39);
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
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabpageGeneral);
            this.tabMain.Controls.Add(this.tabpageNotasAuditoria);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 39);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(520, 274);
            this.tabMain.TabIndex = 0;
            // 
            // tabpageGeneral
            // 
            this.tabpageGeneral.Controls.Add(this.textboxIdentificacion);
            this.tabpageGeneral.Controls.Add(this.labelIdentificacion);
            this.tabpageGeneral.Controls.Add(this.textboxTitular);
            this.tabpageGeneral.Controls.Add(this.labelTitular);
            this.tabpageGeneral.Controls.Add(this.labelCuit);
            this.tabpageGeneral.Controls.Add(this.maskedtextboxCuit);
            this.tabpageGeneral.Controls.Add(this.maskedtextboxSucursal);
            this.tabpageGeneral.Controls.Add(this.maskedtextboxCbu);
            this.tabpageGeneral.Controls.Add(labelCbuAlias);
            this.tabpageGeneral.Controls.Add(this.textboxCbuAlias);
            this.tabpageGeneral.Controls.Add(labelCbu);
            this.tabpageGeneral.Controls.Add(this.comboboxTipo);
            this.tabpageGeneral.Controls.Add(labelTipo);
            this.tabpageGeneral.Controls.Add(this.comboboxBanco);
            this.tabpageGeneral.Controls.Add(labelBanco);
            this.tabpageGeneral.Controls.Add(labelNumero);
            this.tabpageGeneral.Controls.Add(this.textboxNumero);
            this.tabpageGeneral.Controls.Add(labelSucursal);
            this.tabpageGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabpageGeneral.Name = "tabpageGeneral";
            this.tabpageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageGeneral.Size = new System.Drawing.Size(512, 245);
            this.tabpageGeneral.TabIndex = 0;
            this.tabpageGeneral.Text = "General";
            this.tabpageGeneral.UseVisualStyleBackColor = true;
            // 
            // textboxTitular
            // 
            this.textboxTitular.Location = new System.Drawing.Point(87, 190);
            this.textboxTitular.MaxLength = 50;
            this.textboxTitular.Name = "textboxTitular";
            this.textboxTitular.Size = new System.Drawing.Size(270, 20);
            this.textboxTitular.TabIndex = 15;
            this.textboxTitular.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // labelTitular
            // 
            this.labelTitular.AutoSize = true;
            this.labelTitular.Location = new System.Drawing.Point(8, 193);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(39, 13);
            this.labelTitular.TabIndex = 14;
            this.labelTitular.Text = "Titular:";
            // 
            // labelCuit
            // 
            this.labelCuit.AutoSize = true;
            this.labelCuit.Location = new System.Drawing.Point(8, 167);
            this.labelCuit.Name = "labelCuit";
            this.labelCuit.Size = new System.Drawing.Size(35, 13);
            this.labelCuit.TabIndex = 12;
            this.labelCuit.Text = "CUIT:";
            // 
            // maskedtextboxCuit
            // 
            this.maskedtextboxCuit.AllowPromptAsInput = false;
            this.maskedtextboxCuit.AsciiOnly = true;
            this.maskedtextboxCuit.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtextboxCuit.HidePromptOnLeave = true;
            this.maskedtextboxCuit.Location = new System.Drawing.Point(87, 164);
            this.maskedtextboxCuit.Mask = "00-00000000-0";
            this.maskedtextboxCuit.Name = "maskedtextboxCuit";
            this.maskedtextboxCuit.Size = new System.Drawing.Size(94, 20);
            this.maskedtextboxCuit.TabIndex = 13;
            this.maskedtextboxCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtextboxCuit.Enter += new System.EventHandler(this.MaskedTextBoxs_Enter);
            // 
            // maskedtextboxSucursal
            // 
            this.maskedtextboxSucursal.AllowPromptAsInput = false;
            this.maskedtextboxSucursal.AsciiOnly = true;
            this.maskedtextboxSucursal.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtextboxSucursal.HidePromptOnLeave = true;
            this.maskedtextboxSucursal.Location = new System.Drawing.Point(87, 60);
            this.maskedtextboxSucursal.Mask = "9999";
            this.maskedtextboxSucursal.Name = "maskedtextboxSucursal";
            this.maskedtextboxSucursal.Size = new System.Drawing.Size(40, 20);
            this.maskedtextboxSucursal.TabIndex = 5;
            this.maskedtextboxSucursal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtextboxSucursal.Enter += new System.EventHandler(this.MaskedTextBoxs_Enter);
            // 
            // maskedtextboxCbu
            // 
            this.maskedtextboxCbu.AllowPromptAsInput = false;
            this.maskedtextboxCbu.AsciiOnly = true;
            this.maskedtextboxCbu.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtextboxCbu.HidePromptOnLeave = true;
            this.maskedtextboxCbu.Location = new System.Drawing.Point(87, 112);
            this.maskedtextboxCbu.Margin = new System.Windows.Forms.Padding(2);
            this.maskedtextboxCbu.Mask = "0000000-0 0000000000000-0";
            this.maskedtextboxCbu.Name = "maskedtextboxCbu";
            this.maskedtextboxCbu.Size = new System.Drawing.Size(153, 20);
            this.maskedtextboxCbu.TabIndex = 9;
            this.maskedtextboxCbu.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.maskedtextboxCbu.TextChanged += new System.EventHandler(this.Cbu_TextChanged);
            this.maskedtextboxCbu.Enter += new System.EventHandler(this.MaskedTextBoxs_Enter);
            // 
            // textboxCbuAlias
            // 
            this.textboxCbuAlias.Location = new System.Drawing.Point(87, 138);
            this.textboxCbuAlias.MaxLength = 50;
            this.textboxCbuAlias.Name = "textboxCbuAlias";
            this.textboxCbuAlias.Size = new System.Drawing.Size(150, 20);
            this.textboxCbuAlias.TabIndex = 11;
            this.textboxCbuAlias.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // comboboxTipo
            // 
            this.comboboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTipo.FormattingEnabled = true;
            this.comboboxTipo.Location = new System.Drawing.Point(87, 33);
            this.comboboxTipo.Name = "comboboxTipo";
            this.comboboxTipo.Size = new System.Drawing.Size(150, 21);
            this.comboboxTipo.TabIndex = 3;
            // 
            // comboboxBanco
            // 
            this.comboboxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxBanco.FormattingEnabled = true;
            this.comboboxBanco.Location = new System.Drawing.Point(87, 6);
            this.comboboxBanco.Name = "comboboxBanco";
            this.comboboxBanco.Size = new System.Drawing.Size(270, 21);
            this.comboboxBanco.TabIndex = 1;
            // 
            // textboxNumero
            // 
            this.textboxNumero.Location = new System.Drawing.Point(87, 86);
            this.textboxNumero.MaxLength = 50;
            this.textboxNumero.Name = "textboxNumero";
            this.textboxNumero.Size = new System.Drawing.Size(150, 20);
            this.textboxNumero.TabIndex = 7;
            this.textboxNumero.Enter += new System.EventHandler(this.TextBoxs_Enter);
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
            this.tabpageNotasAuditoria.Size = new System.Drawing.Size(512, 253);
            this.tabpageNotasAuditoria.TabIndex = 1;
            this.tabpageNotasAuditoria.Text = "Notas y Auditoría";
            this.tabpageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // checkboxEsActivo
            // 
            this.checkboxEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxEsActivo.AutoSize = true;
            this.checkboxEsActivo.Location = new System.Drawing.Point(118, 153);
            this.checkboxEsActivo.Name = "checkboxEsActivo";
            this.checkboxEsActivo.Size = new System.Drawing.Size(15, 14);
            this.checkboxEsActivo.TabIndex = 3;
            this.checkboxEsActivo.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(11, 143);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id:";
            // 
            // textboxUsuarioModificacion
            // 
            this.textboxUsuarioModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxUsuarioModificacion.Location = new System.Drawing.Point(245, 192);
            this.textboxUsuarioModificacion.MaxLength = 50;
            this.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion";
            this.textboxUsuarioModificacion.ReadOnly = true;
            this.textboxUsuarioModificacion.Size = new System.Drawing.Size(259, 20);
            this.textboxUsuarioModificacion.TabIndex = 11;
            // 
            // textboxId
            // 
            this.textboxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxId.Location = new System.Drawing.Point(118, 140);
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
            this.textboxUsuarioCreacion.Location = new System.Drawing.Point(245, 166);
            this.textboxUsuarioCreacion.MaxLength = 50;
            this.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion";
            this.textboxUsuarioCreacion.ReadOnly = true;
            this.textboxUsuarioCreacion.Size = new System.Drawing.Size(259, 20);
            this.textboxUsuarioCreacion.TabIndex = 8;
            // 
            // textboxFechaHoraModificacion
            // 
            this.textboxFechaHoraModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxFechaHoraModificacion.Location = new System.Drawing.Point(118, 192);
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
            this.textboxFechaHoraCreacion.Location = new System.Drawing.Point(118, 166);
            this.textboxFechaHoraCreacion.MaxLength = 0;
            this.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion";
            this.textboxFechaHoraCreacion.ReadOnly = true;
            this.textboxFechaHoraCreacion.Size = new System.Drawing.Size(121, 20);
            this.textboxFechaHoraCreacion.TabIndex = 7;
            this.textboxFechaHoraCreacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxNotas
            // 
            this.textboxNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxNotas.Location = new System.Drawing.Point(118, 6);
            this.textboxNotas.MaxLength = 0;
            this.textboxNotas.Multiline = true;
            this.textboxNotas.Name = "textboxNotas";
            this.textboxNotas.Size = new System.Drawing.Size(386, 108);
            this.textboxNotas.TabIndex = 1;
            this.textboxNotas.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // textboxIdentificacion
            // 
            this.textboxIdentificacion.Location = new System.Drawing.Point(87, 216);
            this.textboxIdentificacion.MaxLength = 50;
            this.textboxIdentificacion.Name = "textboxIdentificacion";
            this.textboxIdentificacion.Size = new System.Drawing.Size(270, 20);
            this.textboxIdentificacion.TabIndex = 17;
            this.textboxIdentificacion.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // labelIdentificacion
            // 
            this.labelIdentificacion.AutoSize = true;
            this.labelIdentificacion.Location = new System.Drawing.Point(8, 219);
            this.labelIdentificacion.Name = "labelIdentificacion";
            this.labelIdentificacion.Size = new System.Drawing.Size(73, 13);
            this.labelIdentificacion.TabIndex = 16;
            this.labelIdentificacion.Text = "Identificación:";
            // 
            // FormEntidadCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 313);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolstripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntidadCuentaBancaria";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cuenta Bancaria de la Entidad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.this_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.this_KeyPress);
            this.toolstripMain.ResumeLayout(false);
            this.toolstripMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabpageGeneral.ResumeLayout(false);
            this.tabpageGeneral.PerformLayout();
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
        private CardonerSistemas.TabControl tabMain;
        private System.Windows.Forms.TabPage tabpageGeneral;
        private System.Windows.Forms.TabPage tabpageNotasAuditoria;
        internal System.Windows.Forms.TextBox textboxNumero;
        internal System.Windows.Forms.ComboBox comboboxBanco;
        internal System.Windows.Forms.CheckBox checkboxEsActivo;
        internal System.Windows.Forms.Label labelId;
        internal System.Windows.Forms.TextBox textboxUsuarioModificacion;
        internal System.Windows.Forms.TextBox textboxId;
        internal System.Windows.Forms.TextBox textboxUsuarioCreacion;
        internal System.Windows.Forms.TextBox textboxFechaHoraModificacion;
        internal System.Windows.Forms.TextBox textboxFechaHoraCreacion;
        internal System.Windows.Forms.TextBox textboxNotas;
        internal System.Windows.Forms.ComboBox comboboxTipo;
        internal System.Windows.Forms.TextBox textboxCbuAlias;
        internal System.Windows.Forms.MaskedTextBox maskedtextboxCbu;
        private System.Windows.Forms.MaskedTextBox maskedtextboxSucursal;
        private System.Windows.Forms.Label labelCuit;
        internal System.Windows.Forms.MaskedTextBox maskedtextboxCuit;
        private System.Windows.Forms.TextBox textboxTitular;
        private System.Windows.Forms.Label labelTitular;
        private System.Windows.Forms.TextBox textboxIdentificacion;
        private System.Windows.Forms.Label labelIdentificacion;
    }
}