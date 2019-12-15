namespace CS_Gestion
{
    partial class formMDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMDI));
            this.menustripMain = new System.Windows.Forms.MenuStrip();
            this.menuitemArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemArchivoOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemArchivoSeparadorCerrarSesion = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemArchivoCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemArchivoSeparadorSalir = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditarDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditarRehacer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditarSeparadorCortar = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemEditarCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditarPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEditarSeparadorSeleccionarTodo = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemEditarSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaOrganizarIconos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaSeparadorCerrarTodas = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemVentanaCerrarTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaEncajarEnVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaSeparadorListaVentanas = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemAyudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMain = new System.Windows.Forms.ToolStrip();
            this.statusstripMain = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menustripMain.SuspendLayout();
            this.statusstripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustripMain
            // 
            this.menustripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemArchivo,
            this.menuitemEditar,
            this.menuitemDebug,
            this.menuitemVentana,
            this.menuitemAyuda});
            this.menustripMain.Location = new System.Drawing.Point(0, 0);
            this.menustripMain.MdiWindowListItem = this.menuitemVentana;
            this.menustripMain.Name = "menustripMain";
            this.menustripMain.Size = new System.Drawing.Size(632, 24);
            this.menustripMain.TabIndex = 0;
            this.menustripMain.Text = "MenuStrip";
            // 
            // menuitemArchivo
            // 
            this.menuitemArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemArchivoOpciones,
            this.menuitemArchivoSeparadorCerrarSesion,
            this.menuitemArchivoCerrarSesion,
            this.menuitemArchivoSeparadorSalir,
            this.menuitemArchivoSalir});
            this.menuitemArchivo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuitemArchivo.Name = "menuitemArchivo";
            this.menuitemArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuitemArchivo.Text = "&Archivo";
            // 
            // menuitemArchivoOpciones
            // 
            this.menuitemArchivoOpciones.Name = "menuitemArchivoOpciones";
            this.menuitemArchivoOpciones.Size = new System.Drawing.Size(244, 22);
            this.menuitemArchivoOpciones.Text = "Opciones";
            this.menuitemArchivoOpciones.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // menuitemArchivoSeparadorCerrarSesion
            // 
            this.menuitemArchivoSeparadorCerrarSesion.Name = "menuitemArchivoSeparadorCerrarSesion";
            this.menuitemArchivoSeparadorCerrarSesion.Size = new System.Drawing.Size(241, 6);
            // 
            // menuitemArchivoCerrarSesion
            // 
            this.menuitemArchivoCerrarSesion.Name = "menuitemArchivoCerrarSesion";
            this.menuitemArchivoCerrarSesion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuitemArchivoCerrarSesion.Size = new System.Drawing.Size(244, 22);
            this.menuitemArchivoCerrarSesion.Text = "Cerrar sesión del Usuario";
            // 
            // menuitemArchivoSeparadorSalir
            // 
            this.menuitemArchivoSeparadorSalir.Name = "menuitemArchivoSeparadorSalir";
            this.menuitemArchivoSeparadorSalir.Size = new System.Drawing.Size(241, 6);
            // 
            // menuitemArchivoSalir
            // 
            this.menuitemArchivoSalir.Name = "menuitemArchivoSalir";
            this.menuitemArchivoSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuitemArchivoSalir.Size = new System.Drawing.Size(244, 22);
            this.menuitemArchivoSalir.Text = "&Salir";
            // 
            // menuitemEditar
            // 
            this.menuitemEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemEditarDeshacer,
            this.menuitemEditarRehacer,
            this.menuitemEditarSeparadorCortar,
            this.menuitemEditarCortar,
            this.menuitemEditarCopiar,
            this.menuitemEditarPegar,
            this.menuitemEditarSeparadorSeleccionarTodo,
            this.menuitemEditarSeleccionarTodo});
            this.menuitemEditar.Name = "menuitemEditar";
            this.menuitemEditar.Size = new System.Drawing.Size(49, 20);
            this.menuitemEditar.Text = "&Editar";
            // 
            // menuitemEditarDeshacer
            // 
            this.menuitemEditarDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("menuitemEditarDeshacer.Image")));
            this.menuitemEditarDeshacer.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuitemEditarDeshacer.Name = "menuitemEditarDeshacer";
            this.menuitemEditarDeshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuitemEditarDeshacer.Size = new System.Drawing.Size(204, 22);
            this.menuitemEditarDeshacer.Text = "&Deshacer";
            // 
            // menuitemEditarRehacer
            // 
            this.menuitemEditarRehacer.Image = ((System.Drawing.Image)(resources.GetObject("menuitemEditarRehacer.Image")));
            this.menuitemEditarRehacer.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuitemEditarRehacer.Name = "menuitemEditarRehacer";
            this.menuitemEditarRehacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuitemEditarRehacer.Size = new System.Drawing.Size(204, 22);
            this.menuitemEditarRehacer.Text = "&Rehacer";
            // 
            // menuitemEditarSeparadorCortar
            // 
            this.menuitemEditarSeparadorCortar.Name = "menuitemEditarSeparadorCortar";
            this.menuitemEditarSeparadorCortar.Size = new System.Drawing.Size(201, 6);
            // 
            // menuitemEditarCortar
            // 
            this.menuitemEditarCortar.Image = ((System.Drawing.Image)(resources.GetObject("menuitemEditarCortar.Image")));
            this.menuitemEditarCortar.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuitemEditarCortar.Name = "menuitemEditarCortar";
            this.menuitemEditarCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuitemEditarCortar.Size = new System.Drawing.Size(204, 22);
            this.menuitemEditarCortar.Text = "C&ortar";
            this.menuitemEditarCortar.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // menuitemEditarCopiar
            // 
            this.menuitemEditarCopiar.Image = ((System.Drawing.Image)(resources.GetObject("menuitemEditarCopiar.Image")));
            this.menuitemEditarCopiar.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuitemEditarCopiar.Name = "menuitemEditarCopiar";
            this.menuitemEditarCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuitemEditarCopiar.Size = new System.Drawing.Size(204, 22);
            this.menuitemEditarCopiar.Text = "&Copiar";
            this.menuitemEditarCopiar.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // menuitemEditarPegar
            // 
            this.menuitemEditarPegar.Image = ((System.Drawing.Image)(resources.GetObject("menuitemEditarPegar.Image")));
            this.menuitemEditarPegar.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuitemEditarPegar.Name = "menuitemEditarPegar";
            this.menuitemEditarPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuitemEditarPegar.Size = new System.Drawing.Size(204, 22);
            this.menuitemEditarPegar.Text = "&Pegar";
            this.menuitemEditarPegar.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // menuitemEditarSeparadorSeleccionarTodo
            // 
            this.menuitemEditarSeparadorSeleccionarTodo.Name = "menuitemEditarSeparadorSeleccionarTodo";
            this.menuitemEditarSeparadorSeleccionarTodo.Size = new System.Drawing.Size(201, 6);
            // 
            // menuitemEditarSeleccionarTodo
            // 
            this.menuitemEditarSeleccionarTodo.Name = "menuitemEditarSeleccionarTodo";
            this.menuitemEditarSeleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuitemEditarSeleccionarTodo.Size = new System.Drawing.Size(204, 22);
            this.menuitemEditarSeleccionarTodo.Text = "Seleccionar &todo";
            // 
            // menuitemDebug
            // 
            this.menuitemDebug.Name = "menuitemDebug";
            this.menuitemDebug.Size = new System.Drawing.Size(54, 20);
            this.menuitemDebug.Text = "&Debug";
            // 
            // menuitemVentana
            // 
            this.menuitemVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemVentanaMosaicoHorizontal,
            this.menuitemVentanaMosaicoVertical,
            this.menuitemVentanaCascada,
            this.menuitemVentanaOrganizarIconos,
            this.menuitemVentanaSeparadorCerrarTodas,
            this.menuitemVentanaCerrarTodas,
            this.menuitemVentanaEncajarEnVentana,
            this.menuitemVentanaSeparadorListaVentanas});
            this.menuitemVentana.Name = "menuitemVentana";
            this.menuitemVentana.Size = new System.Drawing.Size(61, 20);
            this.menuitemVentana.Text = "&Ventana";
            // 
            // menuitemVentanaMosaicoHorizontal
            // 
            this.menuitemVentanaMosaicoHorizontal.Image = global::CS_Gestion.Properties.Resources.IMAGE_MENU_WINDOW_TILE_HORIZONTALLY;
            this.menuitemVentanaMosaicoHorizontal.Name = "menuitemVentanaMosaicoHorizontal";
            this.menuitemVentanaMosaicoHorizontal.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaMosaicoHorizontal.Text = "Mosaico &Horizontal";
            this.menuitemVentanaMosaicoHorizontal.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // menuitemVentanaMosaicoVertical
            // 
            this.menuitemVentanaMosaicoVertical.Image = global::CS_Gestion.Properties.Resources.IMAGE_MENU_WINDOW_TILE_VERTICALLY;
            this.menuitemVentanaMosaicoVertical.Name = "menuitemVentanaMosaicoVertical";
            this.menuitemVentanaMosaicoVertical.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaMosaicoVertical.Text = "Mosaico &Vertical";
            this.menuitemVentanaMosaicoVertical.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // menuitemVentanaCascada
            // 
            this.menuitemVentanaCascada.Name = "menuitemVentanaCascada";
            this.menuitemVentanaCascada.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaCascada.Text = "&Cascada";
            this.menuitemVentanaCascada.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // menuitemVentanaOrganizarIconos
            // 
            this.menuitemVentanaOrganizarIconos.Name = "menuitemVentanaOrganizarIconos";
            this.menuitemVentanaOrganizarIconos.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaOrganizarIconos.Text = "&Organizar Íconos";
            this.menuitemVentanaOrganizarIconos.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // menuitemVentanaSeparadorCerrarTodas
            // 
            this.menuitemVentanaSeparadorCerrarTodas.Name = "menuitemVentanaSeparadorCerrarTodas";
            this.menuitemVentanaSeparadorCerrarTodas.Size = new System.Drawing.Size(177, 6);
            // 
            // menuitemVentanaCerrarTodas
            // 
            this.menuitemVentanaCerrarTodas.Image = global::CS_Gestion.Properties.Resources.IMAGE_MENU_WINDOW_CLOSE_ALL;
            this.menuitemVentanaCerrarTodas.Name = "menuitemVentanaCerrarTodas";
            this.menuitemVentanaCerrarTodas.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaCerrarTodas.Text = "Ce&rrar Todas";
            this.menuitemVentanaCerrarTodas.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // menuitemVentanaEncajarEnVentana
            // 
            this.menuitemVentanaEncajarEnVentana.Image = global::CS_Gestion.Properties.Resources.IMAGE_MENU_WINDOW_FIT_SIZE;
            this.menuitemVentanaEncajarEnVentana.Name = "menuitemVentanaEncajarEnVentana";
            this.menuitemVentanaEncajarEnVentana.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaEncajarEnVentana.Text = "Encajar en ventana";
            // 
            // menuitemVentanaSeparadorListaVentanas
            // 
            this.menuitemVentanaSeparadorListaVentanas.Name = "menuitemVentanaSeparadorListaVentanas";
            this.menuitemVentanaSeparadorListaVentanas.Size = new System.Drawing.Size(177, 6);
            // 
            // menuitemAyuda
            // 
            this.menuitemAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemAyudaAcercaDe});
            this.menuitemAyuda.Name = "menuitemAyuda";
            this.menuitemAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuitemAyuda.Text = "A&yuda";
            // 
            // menuitemAyudaAcercaDe
            // 
            this.menuitemAyudaAcercaDe.Name = "menuitemAyudaAcercaDe";
            this.menuitemAyudaAcercaDe.Size = new System.Drawing.Size(135, 22);
            this.menuitemAyudaAcercaDe.Text = "&Acerca de...";
            // 
            // toolstripMain
            // 
            this.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolstripMain.Location = new System.Drawing.Point(0, 24);
            this.toolstripMain.Name = "toolstripMain";
            this.toolstripMain.Size = new System.Drawing.Size(632, 0);
            this.toolstripMain.TabIndex = 1;
            this.toolstripMain.Text = "Principal";
            // 
            // statusstripMain
            // 
            this.statusstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus,
            this.toolStripStatusLabel1});
            this.statusstripMain.Location = new System.Drawing.Point(0, 431);
            this.statusstripMain.Name = "statusstripMain";
            this.statusstripMain.Size = new System.Drawing.Size(632, 22);
            this.statusstripMain.TabIndex = 2;
            // 
            // labelStatus
            // 
            this.labelStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(617, 17);
            this.labelStatus.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // formMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusstripMain);
            this.Controls.Add(this.toolstripMain);
            this.Controls.Add(this.menustripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menustripMain;
            this.Name = "formMDI";
            this.Text = "Title";
            this.menustripMain.ResumeLayout(false);
            this.menustripMain.PerformLayout();
            this.statusstripMain.ResumeLayout(false);
            this.statusstripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menustripMain;
        private System.Windows.Forms.ToolStrip toolstripMain;
        private System.Windows.Forms.StatusStrip statusstripMain;
        private System.Windows.Forms.ToolStripSeparator menuitemArchivoSeparadorCerrarSesion;
        private System.Windows.Forms.ToolStripSeparator menuitemArchivoSeparadorSalir;
        private System.Windows.Forms.ToolStripSeparator menuitemEditarSeparadorCortar;
        private System.Windows.Forms.ToolStripSeparator menuitemEditarSeparadorSeleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem menuitemAyudaAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaMosaicoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuitemArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuitemArchivoOpciones;
        private System.Windows.Forms.ToolStripMenuItem menuitemArchivoCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem menuitemArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditar;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditarRehacer;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditarCortar;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditarPegar;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditarSeleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem menuitemDebug;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentana;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaCascada;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaMosaicoVertical;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaCerrarTodas;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaOrganizarIconos;
        private System.Windows.Forms.ToolStripMenuItem menuitemAyuda;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditarDeshacer;
        private System.Windows.Forms.ToolStripSeparator menuitemVentanaSeparadorCerrarTodas;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaEncajarEnVentana;
        private System.Windows.Forms.ToolStripSeparator menuitemVentanaSeparadorListaVentanas;
    }
}



