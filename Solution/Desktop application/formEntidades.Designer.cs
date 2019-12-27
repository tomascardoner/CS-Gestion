namespace CS_Gestion
{
    partial class formEntidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelToolbars = new System.Windows.Forms.FlowLayoutPanel();
            this.toolstripButtons = new System.Windows.Forms.ToolStrip();
            this.buttonAgregar = new System.Windows.Forms.ToolStripButton();
            this.buttonEditar = new System.Windows.Forms.ToolStripButton();
            this.buttonEliminar = new System.Windows.Forms.ToolStripButton();
            this.buttonImprimir = new System.Windows.Forms.ToolStripSplitButton();
            this.menuitemImprimirFichaPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripBuscar = new System.Windows.Forms.ToolStrip();
            this.labelBuscar = new System.Windows.Forms.ToolStripLabel();
            this.textboxBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.buttonBuscarBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolstripCuartel = new System.Windows.Forms.ToolStrip();
            this.labelCuartel = new System.Windows.Forms.ToolStripLabel();
            this.comboboxCuartel = new System.Windows.Forms.ToolStripComboBox();
            this.toolstripEstado = new System.Windows.Forms.ToolStrip();
            this.labelEstadoActual = new System.Windows.Forms.ToolStripLabel();
            this.comboboxEstadoActual = new System.Windows.Forms.ToolStripComboBox();
            this.statusstripMain = new System.Windows.Forms.StatusStrip();
            this.statuslabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.datagridviewMain = new System.Windows.Forms.DataGridView();
            this.columnNombreParaMostrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelToolbars.SuspendLayout();
            this.toolstripButtons.SuspendLayout();
            this.toolstripBuscar.SuspendLayout();
            this.toolstripCuartel.SuspendLayout();
            this.toolstripEstado.SuspendLayout();
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
            this.panelToolbars.Controls.Add(this.toolstripCuartel);
            this.panelToolbars.Controls.Add(this.toolstripEstado);
            this.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbars.Location = new System.Drawing.Point(0, 0);
            this.panelToolbars.Name = "panelToolbars";
            this.panelToolbars.Size = new System.Drawing.Size(969, 39);
            this.panelToolbars.TabIndex = 3;
            // 
            // toolstripButtons
            // 
            this.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAgregar,
            this.buttonEditar,
            this.buttonEliminar,
            this.buttonImprimir});
            this.toolstripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripButtons.Location = new System.Drawing.Point(0, 0);
            this.toolstripButtons.Name = "toolstripButtons";
            this.toolstripButtons.Size = new System.Drawing.Size(348, 39);
            this.toolstripButtons.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = global::CS_Gestion.Properties.Resources.IMAGE_ITEM_ADD_32;
            this.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(85, 36);
            this.buttonAgregar.Text = "Agregar";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Image = global::CS_Gestion.Properties.Resources.IMAGE_ITEM_EDIT_32;
            this.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(73, 36);
            this.buttonEditar.Text = "Editar";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::CS_Gestion.Properties.Resources.IMAGE_ITEM_DELETE_32;
            this.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(86, 36);
            this.buttonEliminar.Text = "Eliminar";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemImprimirFichaPersonal});
            this.buttonImprimir.Image = global::CS_Gestion.Properties.Resources.IMAGE_PRINT_32;
            this.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(101, 36);
            this.buttonImprimir.Text = "Imprimir";
            // 
            // menuitemImprimirFichaPersonal
            // 
            this.menuitemImprimirFichaPersonal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuitemImprimirFichaPersonal.Name = "menuitemImprimirFichaPersonal";
            this.menuitemImprimirFichaPersonal.Size = new System.Drawing.Size(180, 22);
            this.menuitemImprimirFichaPersonal.Text = "Ficha Personal";
            // 
            // toolstripBuscar
            // 
            this.toolstripBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripBuscar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelBuscar,
            this.textboxBuscar,
            this.buttonBuscarBorrar});
            this.toolstripBuscar.Location = new System.Drawing.Point(348, 0);
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
            // 
            // buttonBuscarBorrar
            // 
            this.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBuscarBorrar.Image = global::CS_Gestion.Properties.Resources.IMAGE_CLOSE_16;
            this.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBuscarBorrar.Name = "buttonBuscarBorrar";
            this.buttonBuscarBorrar.Size = new System.Drawing.Size(23, 36);
            this.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda";
            // 
            // toolstripCuartel
            // 
            this.toolstripCuartel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripCuartel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripCuartel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelCuartel,
            this.comboboxCuartel});
            this.toolstripCuartel.Location = new System.Drawing.Point(541, 0);
            this.toolstripCuartel.Name = "toolstripCuartel";
            this.toolstripCuartel.Size = new System.Drawing.Size(183, 39);
            this.toolstripCuartel.TabIndex = 4;
            // 
            // labelCuartel
            // 
            this.labelCuartel.Name = "labelCuartel";
            this.labelCuartel.Size = new System.Drawing.Size(48, 36);
            this.labelCuartel.Text = "Cuartel:";
            // 
            // comboboxCuartel
            // 
            this.comboboxCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCuartel.Name = "comboboxCuartel";
            this.comboboxCuartel.Size = new System.Drawing.Size(130, 39);
            // 
            // toolstripEstado
            // 
            this.toolstripEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolstripEstado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelEstadoActual,
            this.comboboxEstadoActual});
            this.toolstripEstado.Location = new System.Drawing.Point(724, 0);
            this.toolstripEstado.Name = "toolstripEstado";
            this.toolstripEstado.Size = new System.Drawing.Size(235, 39);
            this.toolstripEstado.TabIndex = 3;
            // 
            // labelEstadoActual
            // 
            this.labelEstadoActual.Name = "labelEstadoActual";
            this.labelEstadoActual.Size = new System.Drawing.Size(80, 36);
            this.labelEstadoActual.Text = "Estado actual:";
            // 
            // comboboxEstadoActual
            // 
            this.comboboxEstadoActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxEstadoActual.Name = "comboboxEstadoActual";
            this.comboboxEstadoActual.Size = new System.Drawing.Size(150, 39);
            // 
            // statusstripMain
            // 
            this.statusstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabelMain});
            this.statusstripMain.Location = new System.Drawing.Point(0, 351);
            this.statusstripMain.Name = "statusstripMain";
            this.statusstripMain.Size = new System.Drawing.Size(969, 22);
            this.statusstripMain.TabIndex = 4;
            // 
            // statuslabelMain
            // 
            this.statuslabelMain.Name = "statuslabelMain";
            this.statuslabelMain.Size = new System.Drawing.Size(954, 17);
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
            this.datagridviewMain.Location = new System.Drawing.Point(0, 39);
            this.datagridviewMain.MultiSelect = false;
            this.datagridviewMain.Name = "datagridviewMain";
            this.datagridviewMain.ReadOnly = true;
            this.datagridviewMain.RowHeadersVisible = false;
            this.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewMain.Size = new System.Drawing.Size(969, 312);
            this.datagridviewMain.TabIndex = 5;
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
            // formEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 373);
            this.Controls.Add(this.datagridviewMain);
            this.Controls.Add(this.statusstripMain);
            this.Controls.Add(this.panelToolbars);
            this.Name = "formEntidades";
            this.Text = "Entidades";
            this.panelToolbars.ResumeLayout(false);
            this.panelToolbars.PerformLayout();
            this.toolstripButtons.ResumeLayout(false);
            this.toolstripButtons.PerformLayout();
            this.toolstripBuscar.ResumeLayout(false);
            this.toolstripBuscar.PerformLayout();
            this.toolstripCuartel.ResumeLayout(false);
            this.toolstripCuartel.PerformLayout();
            this.toolstripEstado.ResumeLayout(false);
            this.toolstripEstado.PerformLayout();
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
        internal System.Windows.Forms.ToolStripButton buttonEliminar;
        internal System.Windows.Forms.ToolStripSplitButton buttonImprimir;
        internal System.Windows.Forms.ToolStripMenuItem menuitemImprimirFichaPersonal;
        internal System.Windows.Forms.ToolStrip toolstripBuscar;
        internal System.Windows.Forms.ToolStripLabel labelBuscar;
        internal System.Windows.Forms.ToolStripTextBox textboxBuscar;
        internal System.Windows.Forms.ToolStripButton buttonBuscarBorrar;
        internal System.Windows.Forms.ToolStrip toolstripCuartel;
        internal System.Windows.Forms.ToolStripLabel labelCuartel;
        internal System.Windows.Forms.ToolStripComboBox comboboxCuartel;
        internal System.Windows.Forms.ToolStrip toolstripEstado;
        internal System.Windows.Forms.ToolStripLabel labelEstadoActual;
        internal System.Windows.Forms.ToolStripComboBox comboboxEstadoActual;
        internal System.Windows.Forms.StatusStrip statusstripMain;
        internal System.Windows.Forms.ToolStripStatusLabel statuslabelMain;
        internal System.Windows.Forms.DataGridView datagridviewMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombreParaMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCuit;
    }
}