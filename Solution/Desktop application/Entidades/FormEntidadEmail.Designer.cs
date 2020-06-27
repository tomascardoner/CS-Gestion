namespace CS_Gestion
{
    partial class FormEntidadEmail
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
            System.Windows.Forms.Label labelNombre;
            System.Windows.Forms.Label labelEmail;
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
            this.comboboxTipo = new System.Windows.Forms.ComboBox();
            this.textboxTipoOtro = new System.Windows.Forms.TextBox();
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.tabpageNotasAuditoria = new System.Windows.Forms.TabPage();
            this.checkboxEsActivo = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.textboxUsuarioModificacion = new System.Windows.Forms.TextBox();
            this.textboxId = new System.Windows.Forms.TextBox();
            this.textboxUsuarioCreacion = new System.Windows.Forms.TextBox();
            this.textboxFechaHoraModificacion = new System.Windows.Forms.TextBox();
            this.textboxFechaHoraCreacion = new System.Windows.Forms.TextBox();
            this.textboxNotas = new System.Windows.Forms.TextBox();
            this.buttonEmailEnviar = new System.Windows.Forms.Button();
            labelNombre = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
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
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new System.Drawing.Point(8, 62);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new System.Drawing.Size(47, 13);
            labelNombre.TabIndex = 6;
            labelNombre.Text = "Nombre:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(8, 36);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(38, 13);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "e-Mail:";
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
            // labelEsActivo
            // 
            labelEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelEsActivo.AutoSize = true;
            labelEsActivo.Location = new System.Drawing.Point(10, 79);
            labelEsActivo.Name = "labelEsActivo";
            labelEsActivo.Size = new System.Drawing.Size(40, 13);
            labelEsActivo.TabIndex = 2;
            labelEsActivo.Text = "Activo:";
            // 
            // labelModificacion
            // 
            labelModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelModificacion.AutoSize = true;
            labelModificacion.Location = new System.Drawing.Point(10, 154);
            labelModificacion.Name = "labelModificacion";
            labelModificacion.Size = new System.Drawing.Size(102, 13);
            labelModificacion.TabIndex = 9;
            labelModificacion.Text = "Ultima Modificación:";
            // 
            // labelCreacion
            // 
            labelCreacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            labelCreacion.AutoSize = true;
            labelCreacion.Location = new System.Drawing.Point(11, 128);
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
            this.tabMain.Size = new System.Drawing.Size(520, 208);
            this.tabMain.TabIndex = 0;
            // 
            // tabpageGeneral
            // 
            this.tabpageGeneral.Controls.Add(this.buttonEmailEnviar);
            this.tabpageGeneral.Controls.Add(this.comboboxTipo);
            this.tabpageGeneral.Controls.Add(this.textboxTipoOtro);
            this.tabpageGeneral.Controls.Add(labelTipo);
            this.tabpageGeneral.Controls.Add(labelNombre);
            this.tabpageGeneral.Controls.Add(this.textboxNombre);
            this.tabpageGeneral.Controls.Add(labelEmail);
            this.tabpageGeneral.Controls.Add(this.textboxEmail);
            this.tabpageGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabpageGeneral.Name = "tabpageGeneral";
            this.tabpageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageGeneral.Size = new System.Drawing.Size(512, 179);
            this.tabpageGeneral.TabIndex = 0;
            this.tabpageGeneral.Text = "General";
            this.tabpageGeneral.UseVisualStyleBackColor = true;
            // 
            // comboboxTipo
            // 
            this.comboboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxTipo.FormattingEnabled = true;
            this.comboboxTipo.Location = new System.Drawing.Point(74, 6);
            this.comboboxTipo.Name = "comboboxTipo";
            this.comboboxTipo.Size = new System.Drawing.Size(224, 21);
            this.comboboxTipo.TabIndex = 1;
            this.comboboxTipo.SelectedValueChanged += new System.EventHandler(this.Tipo_Cambio);
            // 
            // textboxTipoOtro
            // 
            this.textboxTipoOtro.Location = new System.Drawing.Point(304, 6);
            this.textboxTipoOtro.MaxLength = 50;
            this.textboxTipoOtro.Name = "textboxTipoOtro";
            this.textboxTipoOtro.Size = new System.Drawing.Size(200, 20);
            this.textboxTipoOtro.TabIndex = 2;
            this.textboxTipoOtro.Visible = false;
            this.textboxTipoOtro.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // textboxNombre
            // 
            this.textboxNombre.Location = new System.Drawing.Point(74, 59);
            this.textboxNombre.MaxLength = 50;
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(289, 20);
            this.textboxNombre.TabIndex = 7;
            this.textboxNombre.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // textboxEmail
            // 
            this.textboxEmail.Location = new System.Drawing.Point(74, 33);
            this.textboxEmail.MaxLength = 50;
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(289, 20);
            this.textboxEmail.TabIndex = 4;
            this.textboxEmail.Enter += new System.EventHandler(this.TextBoxs_Enter);
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
            this.tabpageNotasAuditoria.Size = new System.Drawing.Size(512, 179);
            this.tabpageNotasAuditoria.TabIndex = 1;
            this.tabpageNotasAuditoria.Text = "Notas y Auditoría";
            this.tabpageNotasAuditoria.UseVisualStyleBackColor = true;
            // 
            // checkboxEsActivo
            // 
            this.checkboxEsActivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxEsActivo.AutoSize = true;
            this.checkboxEsActivo.Location = new System.Drawing.Point(118, 79);
            this.checkboxEsActivo.Name = "checkboxEsActivo";
            this.checkboxEsActivo.Size = new System.Drawing.Size(15, 14);
            this.checkboxEsActivo.TabIndex = 3;
            this.checkboxEsActivo.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(11, 102);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "Id:";
            // 
            // textboxUsuarioModificacion
            // 
            this.textboxUsuarioModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxUsuarioModificacion.Location = new System.Drawing.Point(245, 151);
            this.textboxUsuarioModificacion.MaxLength = 50;
            this.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion";
            this.textboxUsuarioModificacion.ReadOnly = true;
            this.textboxUsuarioModificacion.Size = new System.Drawing.Size(259, 20);
            this.textboxUsuarioModificacion.TabIndex = 11;
            // 
            // textboxId
            // 
            this.textboxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxId.Location = new System.Drawing.Point(118, 99);
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
            this.textboxUsuarioCreacion.Location = new System.Drawing.Point(245, 125);
            this.textboxUsuarioCreacion.MaxLength = 50;
            this.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion";
            this.textboxUsuarioCreacion.ReadOnly = true;
            this.textboxUsuarioCreacion.Size = new System.Drawing.Size(259, 20);
            this.textboxUsuarioCreacion.TabIndex = 8;
            // 
            // textboxFechaHoraModificacion
            // 
            this.textboxFechaHoraModificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textboxFechaHoraModificacion.Location = new System.Drawing.Point(118, 151);
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
            this.textboxFechaHoraCreacion.Location = new System.Drawing.Point(118, 125);
            this.textboxFechaHoraCreacion.MaxLength = 0;
            this.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion";
            this.textboxFechaHoraCreacion.ReadOnly = true;
            this.textboxFechaHoraCreacion.Size = new System.Drawing.Size(121, 20);
            this.textboxFechaHoraCreacion.TabIndex = 7;
            this.textboxFechaHoraCreacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textboxNotas
            // 
            this.textboxNotas.Location = new System.Drawing.Point(118, 6);
            this.textboxNotas.MaxLength = 0;
            this.textboxNotas.Multiline = true;
            this.textboxNotas.Name = "textboxNotas";
            this.textboxNotas.Size = new System.Drawing.Size(386, 66);
            this.textboxNotas.TabIndex = 1;
            this.textboxNotas.Enter += new System.EventHandler(this.TextBoxs_Enter);
            // 
            // buttonEmailEnviar
            // 
            this.buttonEmailEnviar.Image = global::CS_Gestion.Properties.Resources.ImageEmail24;
            this.buttonEmailEnviar.Location = new System.Drawing.Point(369, 32);
            this.buttonEmailEnviar.Name = "buttonEmailEnviar";
            this.buttonEmailEnviar.Size = new System.Drawing.Size(28, 22);
            this.buttonEmailEnviar.TabIndex = 5;
            this.buttonEmailEnviar.UseVisualStyleBackColor = true;
            this.buttonEmailEnviar.Click += new System.EventHandler(this.buttonEmailEnviar_Click);
            // 
            // FormEntidadEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 247);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolstripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntidadEmail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "e-Mail de la Entidad";
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
        internal System.Windows.Forms.TextBox textboxTipoOtro;
        internal System.Windows.Forms.TextBox textboxNombre;
        internal System.Windows.Forms.TextBox textboxEmail;
        internal System.Windows.Forms.ComboBox comboboxTipo;
        internal System.Windows.Forms.CheckBox checkboxEsActivo;
        internal System.Windows.Forms.Label labelId;
        internal System.Windows.Forms.TextBox textboxUsuarioModificacion;
        internal System.Windows.Forms.TextBox textboxId;
        internal System.Windows.Forms.TextBox textboxUsuarioCreacion;
        internal System.Windows.Forms.TextBox textboxFechaHoraModificacion;
        internal System.Windows.Forms.TextBox textboxFechaHoraCreacion;
        internal System.Windows.Forms.TextBox textboxNotas;
        private System.Windows.Forms.Button buttonEmailEnviar;
    }
}