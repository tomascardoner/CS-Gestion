namespace CS_Gestion
{
    partial class FormEntidadCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntidadCategorias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelToolbars = new System.Windows.Forms.FlowLayoutPanel();
            this.toolstripButtons = new System.Windows.Forms.ToolStrip();
            this.buttonAgregar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonBorrar = new System.Windows.Forms.ToolStripButton();
            this.buttonSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.toolstripBuscar = new System.Windows.Forms.ToolStrip();
            this.labelBuscar = new System.Windows.Forms.ToolStripLabel();
            this.textboxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.buttonBuscarBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolstripActivo = new System.Windows.Forms.ToolStrip();
            this.labelActivo = new System.Windows.Forms.ToolStripLabel();
            this.comboboxActivo = new System.Windows.Forms.ToolStripComboBox();
            this.statusstripMain = new System.Windows.Forms.StatusStrip();
            this.statuslabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.datagridviewMain = new System.Windows.Forms.DataGridView();
            this.columnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolbars.SuspendLayout();
            this.toolstripButtons.SuspendLayout();
            this.toolstripBuscar.SuspendLayout();
            this.toolstripActivo.SuspendLayout();
            this.statusstripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelToolbars
            // 
            this.panelToolbars.AutoSize = true;
            this.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelToolbars.Controls.Add(this.toolstripButtons);
            this.panelToolbars.Controls.Add(this.toolstripBuscar);
            this.panelToolbars.Controls.Add(this.toolstripActivo);
            this.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbars.Location = new System.Drawing.Point(0, 0);
            this.panelToolbars.Name = "panelToolbars";
            this.panelToolbars.Size = new System.Drawing.Size(354, 64);
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
            this.buttonSeleccionar});
            this.toolstripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripButtons.Location = new System.Drawing.Point(0, 0);
            this.toolstripButtons.Name = "toolstripButtons";
            this.toolstripButtons.Size = new System.Drawing.Size(339, 39);
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
            this.buttonAgregar.Click += new System.EventHandler(this.Agregar);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Image = global::CS_Gestion.Properties.Resources.ImageItemEdit32;
            this.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(73, 36);
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.Click += new System.EventHandler(this.Editar);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrar.Image")));
            this.buttonBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 36);
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.Click += new System.EventHandler(this.Seleccionar);
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Image = global::CS_Gestion.Properties.Resources.ImageItemSelect32;
            this.buttonSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(103, 36);
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.Click += new System.EventHandler(this.Seleccionar);
            // 
            // toolstripBuscar
            // 
            this.toolstripBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripBuscar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelBuscar,
            this.textboxBuscar,
            this.buttonBuscarBorrar});
            this.toolstripBuscar.Location = new System.Drawing.Point(0, 39);
            this.toolstripBuscar.Name = "toolstripBuscar";
            this.toolstripBuscar.Size = new System.Drawing.Size(193, 25);
            this.toolstripBuscar.TabIndex = 2;
            // 
            // labelBuscar
            // 
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(45, 22);
            this.labelBuscar.Text = "Buscar:";
            // 
            // textboxBuscar
            // 
            this.textboxBuscar.MaxLength = 100;
            this.textboxBuscar.Name = "textboxBuscar";
            this.textboxBuscar.Size = new System.Drawing.Size(120, 25);
            this.textboxBuscar.Enter += new System.EventHandler(this.TextBoxs_Enter);
            this.textboxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buscar_KeyPress);
            // 
            // buttonBuscarBorrar
            // 
            this.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBuscarBorrar.Image = global::CS_Gestion.Properties.Resources.ImageClose16;
            this.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBuscarBorrar.Name = "buttonBuscarBorrar";
            this.buttonBuscarBorrar.Size = new System.Drawing.Size(23, 22);
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
            this.toolstripActivo.Location = new System.Drawing.Point(193, 39);
            this.toolstripActivo.Name = "toolstripActivo";
            this.toolstripActivo.Size = new System.Drawing.Size(124, 25);
            this.toolstripActivo.TabIndex = 13;
            // 
            // labelActivo
            // 
            this.labelActivo.Name = "labelActivo";
            this.labelActivo.Size = new System.Drawing.Size(44, 22);
            this.labelActivo.Text = "Activo:";
            // 
            // comboboxActivo
            // 
            this.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxActivo.Name = "comboboxActivo";
            this.comboboxActivo.Size = new System.Drawing.Size(75, 25);
            this.comboboxActivo.SelectedIndexChanged += new System.EventHandler(this.Activo_SelectedIndexChanged);
            // 
            // statusstripMain
            // 
            this.statusstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabelMain});
            this.statusstripMain.Location = new System.Drawing.Point(0, 351);
            this.statusstripMain.Name = "statusstripMain";
            this.statusstripMain.Size = new System.Drawing.Size(354, 22);
            this.statusstripMain.TabIndex = 4;
            // 
            // statuslabelMain
            // 
            this.statuslabelMain.Name = "statuslabelMain";
            this.statuslabelMain.Size = new System.Drawing.Size(339, 17);
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
            this.columnNombre});
            this.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewMain.Location = new System.Drawing.Point(0, 64);
            this.datagridviewMain.MultiSelect = false;
            this.datagridviewMain.Name = "datagridviewMain";
            this.datagridviewMain.ReadOnly = true;
            this.datagridviewMain.RowHeadersVisible = false;
            this.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewMain.Size = new System.Drawing.Size(354, 287);
            this.datagridviewMain.TabIndex = 5;
            this.datagridviewMain.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_ColumnHeaderMouseClick);
            // 
            // columnNombre
            // 
            this.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.columnNombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.columnNombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnNombre.HeaderText = "Nombre";
            this.columnNombre.Name = "columnNombre";
            this.columnNombre.ReadOnly = true;
            this.columnNombre.Width = 69;
            // 
            // FormEntidadCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 373);
            this.Controls.Add(this.datagridviewMain);
            this.Controls.Add(this.statusstripMain);
            this.Controls.Add(this.panelToolbars);
            this.KeyPreview = true;
            this.Name = "FormEntidadCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Categorías";
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
            this.statusstripMain.ResumeLayout(false);
            this.statusstripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel panelToolbars;
        internal System.Windows.Forms.ToolStrip toolstripButtons;
        internal System.Windows.Forms.ToolStripButton buttonAgregar;
        internal System.Windows.Forms.ToolStripButton buttonEditar;
        internal System.Windows.Forms.ToolStripButton buttonBorrar;
        internal System.Windows.Forms.ToolStrip toolstripBuscar;
        internal System.Windows.Forms.ToolStripLabel labelBuscar;
        internal System.Windows.Forms.ToolStripTextBox textboxBuscar;
        internal System.Windows.Forms.ToolStripButton buttonBuscarBorrar;
        internal System.Windows.Forms.StatusStrip statusstripMain;
        internal System.Windows.Forms.ToolStripStatusLabel statuslabelMain;
        internal System.Windows.Forms.DataGridView datagridviewMain;
        internal System.Windows.Forms.ToolStrip toolstripActivo;
        internal System.Windows.Forms.ToolStripLabel labelActivo;
        internal System.Windows.Forms.ToolStripComboBox comboboxActivo;
        internal System.Windows.Forms.ToolStripButton buttonSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombre;
    }
}