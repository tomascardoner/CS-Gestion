namespace CS_Gestion
{
    partial class FormEntidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntidades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelToolbars = new System.Windows.Forms.FlowLayoutPanel();
            this.toolstripButtons = new System.Windows.Forms.ToolStrip();
            this.buttonAgregar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonBorrar = new System.Windows.Forms.ToolStripButton();
            this.buttonImprimir = new System.Windows.Forms.ToolStripSplitButton();
            this.toolstripBuscar = new System.Windows.Forms.ToolStrip();
            this.labelBuscar = new System.Windows.Forms.ToolStripLabel();
            this.textboxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.buttonBuscarBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolstripActivo = new System.Windows.Forms.ToolStrip();
            this.labelActivo = new System.Windows.Forms.ToolStripLabel();
            this.comboboxActivo = new System.Windows.Forms.ToolStripComboBox();
            this.toolstripCategorias = new System.Windows.Forms.ToolStrip();
            this.labelCategorias = new System.Windows.Forms.ToolStripLabel();
            this.textboxCategorias = new System.Windows.Forms.ToolStripTextBox();
            this.buttonCategorias = new System.Windows.Forms.ToolStripButton();
            this.statusstripMain = new System.Windows.Forms.StatusStrip();
            this.statuslabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.datagridviewMain = new System.Windows.Forms.DataGridView();
            this.columnNombreParaMostrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCategorias = new System.Windows.Forms.TableLayoutPanel();
            this.checkedlistboxCategorias = new System.Windows.Forms.CheckedListBox();
            this.panelCategoriasBotones = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCategoriasCancelar = new System.Windows.Forms.Button();
            this.buttonCategoriasAceptar = new System.Windows.Forms.Button();
            this.buttonCategoriasSeleccionarTodas = new System.Windows.Forms.Button();
            this.buttonCategoriasSeleccionarNinguna = new System.Windows.Forms.Button();
            this.panelToolbars.SuspendLayout();
            this.toolstripButtons.SuspendLayout();
            this.toolstripBuscar.SuspendLayout();
            this.toolstripActivo.SuspendLayout();
            this.toolstripCategorias.SuspendLayout();
            this.statusstripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMain)).BeginInit();
            this.panelCategorias.SuspendLayout();
            this.panelCategoriasBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelToolbars
            // 
            this.panelToolbars.AutoSize = true;
            this.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelToolbars.Controls.Add(this.toolstripButtons);
            this.panelToolbars.Controls.Add(this.toolstripBuscar);
            this.panelToolbars.Controls.Add(this.toolstripActivo);
            this.panelToolbars.Controls.Add(this.toolstripCategorias);
            this.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbars.Location = new System.Drawing.Point(0, 0);
            this.panelToolbars.Name = "panelToolbars";
            this.panelToolbars.Size = new System.Drawing.Size(859, 64);
            this.panelToolbars.TabIndex = 3;
            // 
            // toolstripButtons
            // 
            this.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAgregar,
            this.buttonEditar,
            this.buttonBorrar,
            this.buttonImprimir});
            this.toolstripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripButtons.Location = new System.Drawing.Point(0, 0);
            this.toolstripButtons.Name = "toolstripButtons";
            this.toolstripButtons.Size = new System.Drawing.Size(337, 39);
            this.toolstripButtons.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = global::CS_Gestion.Properties.Resources.ImageItemAdd32;
            this.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(85, 36);
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Image = global::CS_Gestion.Properties.Resources.ImageItemEdit32;
            this.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(73, 36);
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Image = global::CS_Gestion.Properties.Resources.ImageItemDelete32;
            this.buttonBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 36);
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Image = global::CS_Gestion.Properties.Resources.ImagePrint32;
            this.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(101, 36);
            this.buttonImprimir.Text = "Imprimir";
            // 
            // toolstripBuscar
            // 
            this.toolstripBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripBuscar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelBuscar,
            this.textboxBuscar,
            this.buttonBuscarBorrar});
            this.toolstripBuscar.Location = new System.Drawing.Point(337, 0);
            this.toolstripBuscar.Name = "toolstripBuscar";
            this.toolstripBuscar.Size = new System.Drawing.Size(193, 39);
            this.toolstripBuscar.TabIndex = 2;
            // 
            // labelBuscar
            // 
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(45, 36);
            this.labelBuscar.Text = "Buscar:";
            // 
            // textboxBuscar
            // 
            this.textboxBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxBuscar.MaxLength = 100;
            this.textboxBuscar.Name = "textboxBuscar";
            this.textboxBuscar.Size = new System.Drawing.Size(120, 39);
            this.textboxBuscar.Enter += new System.EventHandler(this.TextBoxs_Enter);
            this.textboxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buscar_KeyPress);
            // 
            // buttonBuscarBorrar
            // 
            this.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBuscarBorrar.Image = global::CS_Gestion.Properties.Resources.ImageClose16;
            this.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBuscarBorrar.Name = "buttonBuscarBorrar";
            this.buttonBuscarBorrar.Size = new System.Drawing.Size(23, 36);
            this.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda";
            this.buttonBuscarBorrar.Click += new System.EventHandler(this.BuscarBorrar_Click);
            // 
            // toolstripActivo
            // 
            this.toolstripActivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripActivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelActivo,
            this.comboboxActivo});
            this.toolstripActivo.Location = new System.Drawing.Point(530, 0);
            this.toolstripActivo.Name = "toolstripActivo";
            this.toolstripActivo.Size = new System.Drawing.Size(124, 39);
            this.toolstripActivo.TabIndex = 13;
            // 
            // labelActivo
            // 
            this.labelActivo.Name = "labelActivo";
            this.labelActivo.Size = new System.Drawing.Size(44, 36);
            this.labelActivo.Text = "Activo:";
            // 
            // comboboxActivo
            // 
            this.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxActivo.Name = "comboboxActivo";
            this.comboboxActivo.Size = new System.Drawing.Size(75, 39);
            this.comboboxActivo.SelectedIndexChanged += new System.EventHandler(this.Activo_SelectedIndexChanged);
            // 
            // toolstripCategorias
            // 
            this.toolstripCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripCategorias.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripCategorias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelCategorias,
            this.textboxCategorias,
            this.buttonCategorias});
            this.toolstripCategorias.Location = new System.Drawing.Point(0, 39);
            this.toolstripCategorias.Name = "toolstripCategorias";
            this.toolstripCategorias.Size = new System.Drawing.Size(225, 25);
            this.toolstripCategorias.TabIndex = 14;
            // 
            // labelCategorias
            // 
            this.labelCategorias.Name = "labelCategorias";
            this.labelCategorias.Size = new System.Drawing.Size(66, 22);
            this.labelCategorias.Text = "Categorías:";
            // 
            // textboxCategorias
            // 
            this.textboxCategorias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxCategorias.Name = "textboxCategorias";
            this.textboxCategorias.ReadOnly = true;
            this.textboxCategorias.Size = new System.Drawing.Size(100, 25);
            // 
            // buttonCategorias
            // 
            this.buttonCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonCategorias.Image = ((System.Drawing.Image)(resources.GetObject("buttonCategorias.Image")));
            this.buttonCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCategorias.Name = "buttonCategorias";
            this.buttonCategorias.Size = new System.Drawing.Size(23, 22);
            this.buttonCategorias.Text = "...";
            this.buttonCategorias.Click += new System.EventHandler(this.Categorias);
            // 
            // statusstripMain
            // 
            this.statusstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabelMain});
            this.statusstripMain.Location = new System.Drawing.Point(0, 351);
            this.statusstripMain.Name = "statusstripMain";
            this.statusstripMain.Size = new System.Drawing.Size(859, 22);
            this.statusstripMain.TabIndex = 4;
            // 
            // statuslabelMain
            // 
            this.statuslabelMain.Name = "statuslabelMain";
            this.statuslabelMain.Size = new System.Drawing.Size(844, 17);
            this.statuslabelMain.Spring = true;
            this.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datagridviewMain
            // 
            this.datagridviewMain.AllowUserToAddRows = false;
            this.datagridviewMain.AllowUserToDeleteRows = false;
            this.datagridviewMain.AllowUserToOrderColumns = true;
            this.datagridviewMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.datagridviewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNombreParaMostrar,
            this.columnCuit});
            this.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewMain.Location = new System.Drawing.Point(0, 64);
            this.datagridviewMain.MultiSelect = false;
            this.datagridviewMain.Name = "datagridviewMain";
            this.datagridviewMain.ReadOnly = true;
            this.datagridviewMain.RowHeadersVisible = false;
            this.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewMain.Size = new System.Drawing.Size(859, 287);
            this.datagridviewMain.TabIndex = 5;
            this.datagridviewMain.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_ColumnHeaderMouseClick);
            this.datagridviewMain.DoubleClick += new System.EventHandler(this.Ver_Click);
            // 
            // columnNombreParaMostrar
            // 
            this.columnNombreParaMostrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnNombreParaMostrar.DataPropertyName = "NombreParaMostrar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.columnNombreParaMostrar.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnNombreParaMostrar.HeaderText = "Nombre";
            this.columnNombreParaMostrar.Name = "columnNombreParaMostrar";
            this.columnNombreParaMostrar.ReadOnly = true;
            this.columnNombreParaMostrar.Width = 69;
            // 
            // columnCuit
            // 
            this.columnCuit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnCuit.DataPropertyName = "CUIT";
            this.columnCuit.HeaderText = "CUIT";
            this.columnCuit.Name = "columnCuit";
            this.columnCuit.ReadOnly = true;
            this.columnCuit.Width = 57;
            // 
            // panelCategorias
            // 
            this.panelCategorias.ColumnCount = 1;
            this.panelCategorias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelCategorias.Controls.Add(this.checkedlistboxCategorias, 0, 1);
            this.panelCategorias.Controls.Add(this.panelCategoriasBotones, 0, 0);
            this.panelCategorias.Location = new System.Drawing.Point(687, 45);
            this.panelCategorias.Margin = new System.Windows.Forms.Padding(0);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.RowCount = 2;
            this.panelCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.panelCategorias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelCategorias.Size = new System.Drawing.Size(160, 264);
            this.panelCategorias.TabIndex = 7;
            // 
            // checkedlistboxCategorias
            // 
            this.checkedlistboxCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedlistboxCategorias.FormattingEnabled = true;
            this.checkedlistboxCategorias.Location = new System.Drawing.Point(3, 73);
            this.checkedlistboxCategorias.Name = "checkedlistboxCategorias";
            this.checkedlistboxCategorias.Size = new System.Drawing.Size(154, 188);
            this.checkedlistboxCategorias.TabIndex = 7;
            // 
            // panelCategoriasBotones
            // 
            this.panelCategoriasBotones.ColumnCount = 2;
            this.panelCategoriasBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCategoriasBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCategoriasBotones.Controls.Add(this.buttonCategoriasCancelar, 1, 0);
            this.panelCategoriasBotones.Controls.Add(this.buttonCategoriasAceptar, 0, 0);
            this.panelCategoriasBotones.Controls.Add(this.buttonCategoriasSeleccionarTodas, 0, 1);
            this.panelCategoriasBotones.Controls.Add(this.buttonCategoriasSeleccionarNinguna, 1, 1);
            this.panelCategoriasBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategoriasBotones.Location = new System.Drawing.Point(0, 0);
            this.panelCategoriasBotones.Margin = new System.Windows.Forms.Padding(0);
            this.panelCategoriasBotones.Name = "panelCategoriasBotones";
            this.panelCategoriasBotones.RowCount = 2;
            this.panelCategoriasBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCategoriasBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelCategoriasBotones.Size = new System.Drawing.Size(160, 70);
            this.panelCategoriasBotones.TabIndex = 0;
            // 
            // buttonCategoriasCancelar
            // 
            this.buttonCategoriasCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCategoriasCancelar.Image = global::CS_Gestion.Properties.Resources.ImageCancel16;
            this.buttonCategoriasCancelar.Location = new System.Drawing.Point(83, 3);
            this.buttonCategoriasCancelar.Name = "buttonCategoriasCancelar";
            this.buttonCategoriasCancelar.Size = new System.Drawing.Size(74, 29);
            this.buttonCategoriasCancelar.TabIndex = 3;
            this.buttonCategoriasCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonCategoriasAceptar
            // 
            this.buttonCategoriasAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCategoriasAceptar.Image = global::CS_Gestion.Properties.Resources.ImageOk16;
            this.buttonCategoriasAceptar.Location = new System.Drawing.Point(3, 3);
            this.buttonCategoriasAceptar.Name = "buttonCategoriasAceptar";
            this.buttonCategoriasAceptar.Size = new System.Drawing.Size(74, 29);
            this.buttonCategoriasAceptar.TabIndex = 2;
            this.buttonCategoriasAceptar.UseVisualStyleBackColor = true;
            // 
            // buttonCategoriasSeleccionarTodas
            // 
            this.buttonCategoriasSeleccionarTodas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCategoriasSeleccionarTodas.Location = new System.Drawing.Point(3, 38);
            this.buttonCategoriasSeleccionarTodas.Name = "buttonCategoriasSeleccionarTodas";
            this.buttonCategoriasSeleccionarTodas.Size = new System.Drawing.Size(74, 29);
            this.buttonCategoriasSeleccionarTodas.TabIndex = 0;
            this.buttonCategoriasSeleccionarTodas.Text = "All";
            this.buttonCategoriasSeleccionarTodas.UseVisualStyleBackColor = true;
            // 
            // buttonCategoriasSeleccionarNinguna
            // 
            this.buttonCategoriasSeleccionarNinguna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCategoriasSeleccionarNinguna.Location = new System.Drawing.Point(83, 38);
            this.buttonCategoriasSeleccionarNinguna.Name = "buttonCategoriasSeleccionarNinguna";
            this.buttonCategoriasSeleccionarNinguna.Size = new System.Drawing.Size(74, 29);
            this.buttonCategoriasSeleccionarNinguna.TabIndex = 1;
            this.buttonCategoriasSeleccionarNinguna.Text = "None";
            this.buttonCategoriasSeleccionarNinguna.UseVisualStyleBackColor = true;
            // 
            // FormEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 373);
            this.Controls.Add(this.panelCategorias);
            this.Controls.Add(this.datagridviewMain);
            this.Controls.Add(this.statusstripMain);
            this.Controls.Add(this.panelToolbars);
            this.KeyPreview = true;
            this.Name = "FormEntidades";
            this.Text = "Entidades";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.this_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.this_KeyPress);
            this.panelToolbars.ResumeLayout(false);
            this.panelToolbars.PerformLayout();
            this.toolstripButtons.ResumeLayout(false);
            this.toolstripButtons.PerformLayout();
            this.toolstripBuscar.ResumeLayout(false);
            this.toolstripBuscar.PerformLayout();
            this.toolstripActivo.ResumeLayout(false);
            this.toolstripActivo.PerformLayout();
            this.toolstripCategorias.ResumeLayout(false);
            this.toolstripCategorias.PerformLayout();
            this.statusstripMain.ResumeLayout(false);
            this.statusstripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMain)).EndInit();
            this.panelCategorias.ResumeLayout(false);
            this.panelCategoriasBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel panelToolbars;
        internal System.Windows.Forms.ToolStrip toolstripButtons;
        internal System.Windows.Forms.ToolStripButton buttonAgregar;
        internal System.Windows.Forms.ToolStripButton buttonEditar;
        internal System.Windows.Forms.ToolStripButton buttonBorrar;
        internal System.Windows.Forms.ToolStripSplitButton buttonImprimir;
        internal System.Windows.Forms.ToolStrip toolstripBuscar;
        internal System.Windows.Forms.ToolStripLabel labelBuscar;
        internal System.Windows.Forms.ToolStripTextBox textboxBuscar;
        internal System.Windows.Forms.ToolStripButton buttonBuscarBorrar;
        internal System.Windows.Forms.StatusStrip statusstripMain;
        internal System.Windows.Forms.ToolStripStatusLabel statuslabelMain;
        internal System.Windows.Forms.DataGridView datagridviewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombreParaMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuit;
        internal System.Windows.Forms.ToolStrip toolstripActivo;
        internal System.Windows.Forms.ToolStripLabel labelActivo;
        internal System.Windows.Forms.ToolStripComboBox comboboxActivo;
        internal System.Windows.Forms.ToolStrip toolstripCategorias;
        internal System.Windows.Forms.ToolStripLabel labelCategorias;
        private System.Windows.Forms.ToolStripTextBox textboxCategorias;
        private System.Windows.Forms.ToolStripButton buttonCategorias;
        private System.Windows.Forms.TableLayoutPanel panelCategorias;
        private System.Windows.Forms.CheckedListBox checkedlistboxCategorias;
        private System.Windows.Forms.TableLayoutPanel panelCategoriasBotones;
        private System.Windows.Forms.Button buttonCategoriasSeleccionarTodas;
        private System.Windows.Forms.Button buttonCategoriasSeleccionarNinguna;
        private System.Windows.Forms.Button buttonCategoriasCancelar;
        private System.Windows.Forms.Button buttonCategoriasAceptar;
    }
}