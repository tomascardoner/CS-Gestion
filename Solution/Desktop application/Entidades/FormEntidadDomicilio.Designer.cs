namespace CS_Gestion
{
    partial class FormEntidadDomicilio
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
            System.Windows.Forms.Label labelDomicilioCalle3;
            System.Windows.Forms.Label labelDomicilioCalle2;
            System.Windows.Forms.Label labelDomicilioCalle1;
            System.Windows.Forms.Label labelDomicilioCodigoPostal;
            System.Windows.Forms.Label labelDomicilioDepartamento;
            System.Windows.Forms.Label labelDomicilioLocalidad;
            System.Windows.Forms.Label labelDomicilioProvincia;
            System.Windows.Forms.Label labelDomicilioNumero;
            System.Windows.Forms.Label labelDomicilioPiso;
            System.Windows.Forms.Label labelTipo;
            System.Windows.Forms.Label labelEsActivo;
            System.Windows.Forms.Label labelModificacion;
            System.Windows.Forms.Label labelCreacion;
            System.Windows.Forms.Label labelNotas;
            this.toolstripMain = new System.Windows.Forms.ToolStrip();
            this.buttonCerrar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.buttonGuardar = new System.Windows.Forms.ToolStripButton();
            this.tabMain = new CardonerSistemas.TabControl();
            this.tabpageGeneral = new System.Windows.Forms.TabPage();
            this.tabpageNotasAuditoria = new System.Windows.Forms.TabPage();
            this.textboxDomicilioCalle3 = new System.Windows.Forms.TextBox();
            this.textboxDomicilioCalle2 = new System.Windows.Forms.TextBox();
            this.comboboxDomicilioLocalidad = new System.Windows.Forms.ComboBox();
            this.comboboxDomicilioProvincia = new System.Windows.Forms.ComboBox();
            this.textboxDomicilioCalle1 = new System.Windows.Forms.TextBox();
            this.textboxDomicilioCodigoPostal = new System.Windows.Forms.TextBox();
            this.textboxDomicilioDepartamento = new System.Windows.Forms.TextBox();
            this.textboxDomicilioNumero = new System.Windows.Forms.TextBox();
            this.textboxDomicilioPiso = new System.Windows.Forms.TextBox();
            this.textboxTipoOtro = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkboxEsActivo = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textboxUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.textboxId = new System.Windows.Forms.TextBox();
            this.textboxUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.textboxFechaHoraModificacion = new System.Windows.Forms.TextBox();
            this.textboxFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.textboxNotas = new System.Windows.Forms.TextBox();
            labelDomicilioCalle3 = new System.Windows.Forms.Label();
            labelDomicilioCalle2 = new System.Windows.Forms.Label();
            labelDomicilioCalle1 = new System.Windows.Forms.Label();
            labelDomicilioCodigoPostal = new System.Windows.Forms.Label();
            labelDomicilioDepartamento = new System.Windows.Forms.Label();
            labelDomicilioLocalidad = new System.Windows.Forms.Label();
            labelDomicilioProvincia = new System.Windows.Forms.Label();
            labelDomicilioNumero = new System.Windows.Forms.Label();
            labelDomicilioPiso = new System.Windows.Forms.Label();
            labelTipo = new System.Windows.Forms.Label();
            labelEsActivo = new System.Windows.Forms.Label();
            labelModificacion = new System.Windows.Forms.Label();
            labelCreacion = new System.Windows.Forms.Label();
            labelNotas = new System.Windows.Forms.Label();
            this.toolstripMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabpageGeneral.SuspendLayout();
            this.tabpageNotasAuditoria.SuspendLayout();
            this.SuspendLayout();
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
            this.tabMain.Size = new System.Drawing.Size(520, 249);
            this.tabMain.TabIndex = 0;
            // 
            // tabpageGeneral
            // 
            this.tabpageGeneral.Controls.Add(this.comboBox1);
            this.tabpageGeneral.Controls.Add(this.textboxTipoOtro);
            this.tabpageGeneral.Controls.Add(labelTipo);
            this.tabpageGeneral.Controls.Add(labelDomicilioCalle3);
            this.tabpageGeneral.Controls.Add(labelDomicilioCalle2);
            this.tabpageGeneral.Controls.Add(this.textboxDomicilioCalle3);
            this.tabpageGeneral.Controls.Add(this.textboxDomicilioCalle2);
            this.tabpageGeneral.Controls.Add(this.comboboxDomicilioLocalidad);
            this.tabpageGeneral.Controls.Add(this.comboboxDomicilioProvincia);
            this.tabpageGeneral.Controls.Add(labelDomicilioCalle1);
            this.tabpageGeneral.Controls.Add(this.textboxDomicilioCalle1);
            this.tabpageGeneral.Controls.Add(labelDomicilioCodigoPostal);
            this.tabpageGeneral.Controls.Add(this.textboxDomicilioCodigoPostal);
            this.tabpageGeneral.Controls.Add(labelDomicilioDepartamento);
            this.tabpageGeneral.Controls.Add(this.textboxDomicilioDepartamento);
            this.tabpageGeneral.Controls.Add(labelDomicilioLocalidad);
            this.tabpageGeneral.Controls.Add(labelDomicilioProvincia);
            this.tabpageGeneral.Controls.Add(labelDomicilioNumero);
            this.tabpageGeneral.Controls.Add(this.textboxDomicilioNumero);
            this.tabpageGeneral.Controls.Add(labelDomicilioPiso);
            this.tabpageGeneral.Controls.Add(this.textboxDomicilioPiso);
            this.tabpageGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabpageGeneral.Name = "tabpageGeneral";
            this.tabpageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageGeneral.Size = new System.Drawing.Size(531, 220);
            this.tabpageGeneral.TabIndex = 0;
            this.tabpageGeneral.Text = "General";
            this.tabpageGeneral.UseVisualStyleBackColor = true;
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
            this.tabpageNotasAuditoria.Size = new System.Drawing.Size(512, 220);
            this.tabpageNotasAuditoria.TabIndex = 1;
            this.tabpageNotasAuditoria.Text = "Notas y Auditoría";
            this.tabpageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // labelDomicilioCalle3
            // 
            labelDomicilioCalle3.AutoSize = true;
            labelDomicilioCalle3.Location = new System.Drawing.Point(8, 114);
            labelDomicilioCalle3.Name = "labelDomicilioCalle3";
            labelDomicilioCalle3.Size = new System.Drawing.Size(42, 13);
            labelDomicilioCalle3.TabIndex = 13;
            labelDomicilioCalle3.Text = "Calle 3:";
            // 
            // labelDomicilioCalle2
            // 
            labelDomicilioCalle2.AutoSize = true;
            labelDomicilioCalle2.Location = new System.Drawing.Point(8, 88);
            labelDomicilioCalle2.Name = "labelDomicilioCalle2";
            labelDomicilioCalle2.Size = new System.Drawing.Size(42, 13);
            labelDomicilioCalle2.TabIndex = 11;
            labelDomicilioCalle2.Text = "Calle 2:";
            // 
            // textboxDomicilioCalle3
            // 
            this.textboxDomicilioCalle3.Location = new System.Drawing.Point(74, 111);
            this.textboxDomicilioCalle3.MaxLength = 50;
            this.textboxDomicilioCalle3.Name = "textboxDomicilioCalle3";
            this.textboxDomicilioCalle3.Size = new System.Drawing.Size(258, 20);
            this.textboxDomicilioCalle3.TabIndex = 14;
            // 
            // textboxDomicilioCalle2
            // 
            this.textboxDomicilioCalle2.Location = new System.Drawing.Point(74, 85);
            this.textboxDomicilioCalle2.MaxLength = 50;
            this.textboxDomicilioCalle2.Name = "textboxDomicilioCalle2";
            this.textboxDomicilioCalle2.Size = new System.Drawing.Size(258, 20);
            this.textboxDomicilioCalle2.TabIndex = 12;
            // 
            // comboboxDomicilioLocalidad
            // 
            this.comboboxDomicilioLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDomicilioLocalidad.FormattingEnabled = true;
            this.comboboxDomicilioLocalidad.Location = new System.Drawing.Point(74, 164);
            this.comboboxDomicilioLocalidad.Name = "comboboxDomicilioLocalidad";
            this.comboboxDomicilioLocalidad.Size = new System.Drawing.Size(258, 21);
            this.comboboxDomicilioLocalidad.TabIndex = 18;
            // 
            // comboboxDomicilioProvincia
            // 
            this.comboboxDomicilioProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDomicilioProvincia.FormattingEnabled = true;
            this.comboboxDomicilioProvincia.Location = new System.Drawing.Point(74, 137);
            this.comboboxDomicilioProvincia.Name = "comboboxDomicilioProvincia";
            this.comboboxDomicilioProvincia.Size = new System.Drawing.Size(258, 21);
            this.comboboxDomicilioProvincia.TabIndex = 16;
            // 
            // labelDomicilioCalle1
            // 
            labelDomicilioCalle1.AutoSize = true;
            labelDomicilioCalle1.Location = new System.Drawing.Point(8, 36);
            labelDomicilioCalle1.Name = "labelDomicilioCalle1";
            labelDomicilioCalle1.Size = new System.Drawing.Size(33, 13);
            labelDomicilioCalle1.TabIndex = 3;
            labelDomicilioCalle1.Text = "Calle:";
            // 
            // textboxDomicilioCalle1
            // 
            this.textboxDomicilioCalle1.Location = new System.Drawing.Point(74, 33);
            this.textboxDomicilioCalle1.MaxLength = 100;
            this.textboxDomicilioCalle1.Name = "textboxDomicilioCalle1";
            this.textboxDomicilioCalle1.Size = new System.Drawing.Size(258, 20);
            this.textboxDomicilioCalle1.TabIndex = 4;
            // 
            // labelDomicilioCodigoPostal
            // 
            labelDomicilioCodigoPostal.AutoSize = true;
            labelDomicilioCodigoPostal.Location = new System.Drawing.Point(8, 194);
            labelDomicilioCodigoPostal.Name = "labelDomicilioCodigoPostal";
            labelDomicilioCodigoPostal.Size = new System.Drawing.Size(59, 13);
            labelDomicilioCodigoPostal.TabIndex = 19;
            labelDomicilioCodigoPostal.Text = "Cód. Post.:";
            // 
            // textboxDomicilioCodigoPostal
            // 
            this.textboxDomicilioCodigoPostal.Location = new System.Drawing.Point(74, 191);
            this.textboxDomicilioCodigoPostal.MaxLength = 8;
            this.textboxDomicilioCodigoPostal.Name = "textboxDomicilioCodigoPostal";
            this.textboxDomicilioCodigoPostal.Size = new System.Drawing.Size(50, 20);
            this.textboxDomicilioCodigoPostal.TabIndex = 20;
            // 
            // labelDomicilioDepartamento
            // 
            labelDomicilioDepartamento.AutoSize = true;
            labelDomicilioDepartamento.Location = new System.Drawing.Point(222, 62);
            labelDomicilioDepartamento.Name = "labelDomicilioDepartamento";
            labelDomicilioDepartamento.Size = new System.Drawing.Size(54, 13);
            labelDomicilioDepartamento.TabIndex = 9;
            labelDomicilioDepartamento.Text = "Dto/Ofic.:";
            // 
            // textboxDomicilioDepartamento
            // 
            this.textboxDomicilioDepartamento.Location = new System.Drawing.Point(282, 59);
            this.textboxDomicilioDepartamento.MaxLength = 10;
            this.textboxDomicilioDepartamento.Name = "textboxDomicilioDepartamento";
            this.textboxDomicilioDepartamento.Size = new System.Drawing.Size(50, 20);
            this.textboxDomicilioDepartamento.TabIndex = 10;
            // 
            // labelDomicilioLocalidad
            // 
            labelDomicilioLocalidad.AutoSize = true;
            labelDomicilioLocalidad.Location = new System.Drawing.Point(8, 167);
            labelDomicilioLocalidad.Name = "labelDomicilioLocalidad";
            labelDomicilioLocalidad.Size = new System.Drawing.Size(56, 13);
            labelDomicilioLocalidad.TabIndex = 17;
            labelDomicilioLocalidad.Text = "Localidad:";
            // 
            // labelDomicilioProvincia
            // 
            labelDomicilioProvincia.AutoSize = true;
            labelDomicilioProvincia.Location = new System.Drawing.Point(8, 140);
            labelDomicilioProvincia.Name = "labelDomicilioProvincia";
            labelDomicilioProvincia.Size = new System.Drawing.Size(54, 13);
            labelDomicilioProvincia.TabIndex = 15;
            labelDomicilioProvincia.Text = "Provincia:";
            // 
            // labelDomicilioNumero
            // 
            labelDomicilioNumero.AutoSize = true;
            labelDomicilioNumero.Location = new System.Drawing.Point(8, 62);
            labelDomicilioNumero.Name = "labelDomicilioNumero";
            labelDomicilioNumero.Size = new System.Drawing.Size(47, 13);
            labelDomicilioNumero.TabIndex = 5;
            labelDomicilioNumero.Text = "Número:";
            // 
            // textboxDomicilioNumero
            // 
            this.textboxDomicilioNumero.Location = new System.Drawing.Point(74, 59);
            this.textboxDomicilioNumero.MaxLength = 10;
            this.textboxDomicilioNumero.Name = "textboxDomicilioNumero";
            this.textboxDomicilioNumero.Size = new System.Drawing.Size(50, 20);
            this.textboxDomicilioNumero.TabIndex = 6;
            // 
            // labelDomicilioPiso
            // 
            labelDomicilioPiso.AutoSize = true;
            labelDomicilioPiso.Location = new System.Drawing.Point(130, 62);
            labelDomicilioPiso.Name = "labelDomicilioPiso";
            labelDomicilioPiso.Size = new System.Drawing.Size(30, 13);
            labelDomicilioPiso.TabIndex = 7;
            labelDomicilioPiso.Text = "Piso:";
            // 
            // textboxDomicilioPiso
            // 
            this.textboxDomicilioPiso.Location = new System.Drawing.Point(166, 59);
            this.textboxDomicilioPiso.MaxLength = 10;
            this.textboxDomicilioPiso.Name = "textboxDomicilioPiso";
            this.textboxDomicilioPiso.Size = new System.Drawing.Size(50, 20);
            this.textboxDomicilioPiso.TabIndex = 8;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new System.Drawing.Point(8, 10);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new System.Drawing.Size(31, 13);
            labelTipo.TabIndex = 0;
            labelTipo.Text = "Tipo:";
            // 
            // textboxTipoOtro
            // 
            this.textboxTipoOtro.Location = new System.Drawing.Point(74, 7);
            this.textboxTipoOtro.MaxLength = 10;
            this.textboxTipoOtro.Name = "textboxTipoOtro";
            this.textboxTipoOtro.Size = new System.Drawing.Size(168, 20);
            this.textboxTipoOtro.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // checkboxEsActivo
            // 
            this.checkboxEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxEsActivo.AutoSize = true;
            this.checkboxEsActivo.Location = new System.Drawing.Point(118, 120);
            this.checkboxEsActivo.Name = "checkboxEsActivo";
            this.checkboxEsActivo.Size = new System.Drawing.Size(15, 14);
            this.checkboxEsActivo.TabIndex = 15;
            this.checkboxEsActivo.UseVisualStyleBackColor = true;
            // 
            // labelEsActivo
            // 
            labelEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelEsActivo.AutoSize = true;
            labelEsActivo.Location = new System.Drawing.Point(10, 120);
            labelEsActivo.Name = "labelEsActivo";
            labelEsActivo.Size = new System.Drawing.Size(40, 13);
            labelEsActivo.TabIndex = 14;
            labelEsActivo.Text = "Activo:";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(11, 143);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 16;
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
            this.textboxUsuarioModificacion.TabIndex = 23;
            // 
            // textboxId
            // 
            this.textboxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxId.Location = new System.Drawing.Point(118, 140);
            this.textboxId.MaxLength = 10;
            this.textboxId.Name = "textboxId";
            this.textboxId.ReadOnly = true;
            this.textboxId.Size = new System.Drawing.Size(72, 20);
            this.textboxId.TabIndex = 17;
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
            this.textboxUsuarioCreacion.TabIndex = 20;
            // 
            // textboxFechaHoraModificacion
            // 
            this.textboxFechaHoraModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxFechaHoraModificacion.Location = new System.Drawing.Point(118, 192);
            this.textboxFechaHoraModificacion.MaxLength = 0;
            this.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion";
            this.textboxFechaHoraModificacion.ReadOnly = true;
            this.textboxFechaHoraModificacion.Size = new System.Drawing.Size(121, 20);
            this.textboxFechaHoraModificacion.TabIndex = 22;
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
            this.textboxFechaHoraCreacion.TabIndex = 19;
            this.textboxFechaHoraCreacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelModificacion
            // 
            labelModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelModificacion.AutoSize = true;
            labelModificacion.Location = new System.Drawing.Point(10, 195);
            labelModificacion.Name = "labelModificacion";
            labelModificacion.Size = new System.Drawing.Size(102, 13);
            labelModificacion.TabIndex = 21;
            labelModificacion.Text = "Ultima Modificación:";
            // 
            // labelCreacion
            // 
            labelCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelCreacion.AutoSize = true;
            labelCreacion.Location = new System.Drawing.Point(11, 169);
            labelCreacion.Name = "labelCreacion";
            labelCreacion.Size = new System.Drawing.Size(52, 13);
            labelCreacion.TabIndex = 18;
            labelCreacion.Text = "Creación:";
            // 
            // labelNotas
            // 
            labelNotas.AutoSize = true;
            labelNotas.Location = new System.Drawing.Point(10, 9);
            labelNotas.Name = "labelNotas";
            labelNotas.Size = new System.Drawing.Size(38, 13);
            labelNotas.TabIndex = 12;
            labelNotas.Text = "Notas:";
            // 
            // textboxNotas
            // 
            this.textboxNotas.Location = new System.Drawing.Point(118, 6);
            this.textboxNotas.MaxLength = 0;
            this.textboxNotas.Multiline = true;
            this.textboxNotas.Name = "textboxNotas";
            this.textboxNotas.Size = new System.Drawing.Size(386, 108);
            this.textboxNotas.TabIndex = 13;
            // 
            // FormEntidadDomicilio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 288);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolstripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntidadDomicilio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Domicilio de la Entidad";
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
        internal System.Windows.Forms.TextBox textboxTipoOtro;
        internal System.Windows.Forms.TextBox textboxDomicilioCalle3;
        internal System.Windows.Forms.TextBox textboxDomicilioCalle2;
        internal System.Windows.Forms.ComboBox comboboxDomicilioLocalidad;
        internal System.Windows.Forms.ComboBox comboboxDomicilioProvincia;
        internal System.Windows.Forms.TextBox textboxDomicilioCalle1;
        internal System.Windows.Forms.TextBox textboxDomicilioCodigoPostal;
        internal System.Windows.Forms.TextBox textboxDomicilioDepartamento;
        internal System.Windows.Forms.TextBox textboxDomicilioNumero;
        internal System.Windows.Forms.TextBox textboxDomicilioPiso;
        internal System.Windows.Forms.ComboBox comboBox1;
        internal System.Windows.Forms.CheckBox checkboxEsActivo;
        internal System.Windows.Forms.Label labelId;
        internal System.Windows.Forms.TextBox textboxUsuarioModificacion;
        internal System.Windows.Forms.TextBox textboxId;
        internal System.Windows.Forms.TextBox textboxUsuarioCreacion;
        internal System.Windows.Forms.TextBox textboxFechaHoraModificacion;
        internal System.Windows.Forms.TextBox textboxFechaHoraCreacion;
        internal System.Windows.Forms.TextBox textboxNotas;
    }
}