namespace CS_Gestion
{
    partial class formMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMdi));
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
            this.statusstripMain = new System.Windows.Forms.StatusStrip();
            this.labelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelUsuarioNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.navigationDrawer1 = new Syncfusion.Windows.Forms.Tools.NavigationDrawer();
            this.drawerheaderTablas = new Syncfusion.Windows.Forms.Tools.DrawerHeader();
            this.drawermenuitemEntidad = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerHeader1 = new Syncfusion.Windows.Forms.Tools.DrawerHeader();
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
            this.menustripMain.Size = new System.Drawing.Size(768, 24);
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
            this.menuitemArchivoSalir.Click += new System.EventHandler(this.menuitemArchivoSalir_Click);
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
            this.menuitemVentanaMosaicoHorizontal.Size = new System.Drawing.Size(177, 22);
            this.menuitemVentanaMosaicoHorizontal.Text = "Mosaico &Horizontal";
            this.menuitemVentanaMosaicoHorizontal.Click += new System.EventHandler(this.menuitemVentanaMosaicoHorizontal_Click);
            // 
            // menuitemVentanaMosaicoVertical
            // 
            this.menuitemVentanaMosaicoVertical.Image = global::CS_Gestion.Properties.Resources.IMAGE_MENU_WINDOW_TILE_VERTICALLY;
            this.menuitemVentanaMosaicoVertical.Name = "menuitemVentanaMosaicoVertical";
            this.menuitemVentanaMosaicoVertical.Size = new System.Drawing.Size(177, 22);
            this.menuitemVentanaMosaicoVertical.Text = "Mosaico &Vertical";
            this.menuitemVentanaMosaicoVertical.Click += new System.EventHandler(this.menuitemVentanaMosaicoVertical_Click);
            // 
            // menuitemVentanaCascada
            // 
            this.menuitemVentanaCascada.Name = "menuitemVentanaCascada";
            this.menuitemVentanaCascada.Size = new System.Drawing.Size(177, 22);
            this.menuitemVentanaCascada.Text = "&Cascada";
            this.menuitemVentanaCascada.Click += new System.EventHandler(this.menuitemVentanaCascada_Click);
            // 
            // menuitemVentanaOrganizarIconos
            // 
            this.menuitemVentanaOrganizarIconos.Name = "menuitemVentanaOrganizarIconos";
            this.menuitemVentanaOrganizarIconos.Size = new System.Drawing.Size(177, 22);
            this.menuitemVentanaOrganizarIconos.Text = "&Organizar Íconos";
            this.menuitemVentanaOrganizarIconos.Click += new System.EventHandler(this.menuitemVentanaOrganizarIconos_Click);
            // 
            // menuitemVentanaSeparadorCerrarTodas
            // 
            this.menuitemVentanaSeparadorCerrarTodas.Name = "menuitemVentanaSeparadorCerrarTodas";
            this.menuitemVentanaSeparadorCerrarTodas.Size = new System.Drawing.Size(174, 6);
            // 
            // menuitemVentanaCerrarTodas
            // 
            this.menuitemVentanaCerrarTodas.Image = global::CS_Gestion.Properties.Resources.IMAGE_MENU_WINDOW_CLOSE_ALL;
            this.menuitemVentanaCerrarTodas.Name = "menuitemVentanaCerrarTodas";
            this.menuitemVentanaCerrarTodas.Size = new System.Drawing.Size(177, 22);
            this.menuitemVentanaCerrarTodas.Text = "Ce&rrar Todas";
            this.menuitemVentanaCerrarTodas.Click += new System.EventHandler(this.menuitemVentanaCerrarTodas_Click);
            // 
            // menuitemVentanaEncajarEnVentana
            // 
            this.menuitemVentanaEncajarEnVentana.Image = global::CS_Gestion.Properties.Resources.IMAGE_MENU_WINDOW_FIT_SIZE;
            this.menuitemVentanaEncajarEnVentana.Name = "menuitemVentanaEncajarEnVentana";
            this.menuitemVentanaEncajarEnVentana.Size = new System.Drawing.Size(177, 22);
            this.menuitemVentanaEncajarEnVentana.Text = "Encajar en ventana";
            this.menuitemVentanaEncajarEnVentana.Click += new System.EventHandler(this.menuitemVentanaEncajarEnVentana_Click);
            // 
            // menuitemVentanaSeparadorListaVentanas
            // 
            this.menuitemVentanaSeparadorListaVentanas.Name = "menuitemVentanaSeparadorListaVentanas";
            this.menuitemVentanaSeparadorListaVentanas.Size = new System.Drawing.Size(174, 6);
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
            // statusstripMain
            // 
            this.statusstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelEstado,
            this.labelUsuarioNombre});
            this.statusstripMain.Location = new System.Drawing.Point(0, 431);
            this.statusstripMain.Name = "statusstripMain";
            this.statusstripMain.Size = new System.Drawing.Size(768, 22);
            this.statusstripMain.TabIndex = 2;
            // 
            // labelEstado
            // 
            this.labelEstado.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(753, 17);
            this.labelEstado.Spring = true;
            // 
            // labelUsuarioNombre
            // 
            this.labelUsuarioNombre.Name = "labelUsuarioNombre";
            this.labelUsuarioNombre.Size = new System.Drawing.Size(0, 17);
            // 
            // navigationDrawer1
            // 
            this.navigationDrawer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.navigationDrawer1.Items.Add(this.drawerHeader1);
            this.navigationDrawer1.Items.Add(this.drawerheaderTablas);
            this.navigationDrawer1.Items.Add(this.drawermenuitemEntidad);
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 27);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.Size = new System.Drawing.Size(181, 401);
            this.navigationDrawer1.Style = Syncfusion.Windows.Forms.Tools.NavigationDrawerStyle.Office2016White;
            this.navigationDrawer1.TabIndex = 4;
            this.navigationDrawer1.Text = "navigationDrawer1";
            this.navigationDrawer1.ThemeName = "Office2016White";
            this.navigationDrawer1.Transition = Syncfusion.Windows.Forms.Tools.Transition.Push;
            // 
            // drawerheaderTablas
            // 
            this.drawerheaderTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.drawerheaderTablas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerheaderTablas.HeaderText = "drawerheaderTablas";
            this.drawerheaderTablas.ItemText = "Tablas";
            this.drawerheaderTablas.Location = new System.Drawing.Point(2, 0);
            this.drawerheaderTablas.Margin = new System.Windows.Forms.Padding(0);
            this.drawerheaderTablas.Name = "drawerheaderTablas";
            this.drawerheaderTablas.Size = new System.Drawing.Size(100, 50);
            this.drawerheaderTablas.TabIndex = 0;
            this.drawerheaderTablas.Text = "Tablas";
            this.drawerheaderTablas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // drawermenuitemEntidad
            // 
            this.drawermenuitemEntidad.BackColor = System.Drawing.Color.White;
            this.drawermenuitemEntidad.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.drawermenuitemEntidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawermenuitemEntidad.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.drawermenuitemEntidad.Location = new System.Drawing.Point(2, 50);
            this.drawermenuitemEntidad.Margin = new System.Windows.Forms.Padding(0);
            this.drawermenuitemEntidad.Name = "drawermenuitemEntidad";
            this.drawermenuitemEntidad.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.drawermenuitemEntidad.Size = new System.Drawing.Size(100, 50);
            this.drawermenuitemEntidad.TabIndex = 1;
            this.drawermenuitemEntidad.Text = "Entidades";
            this.drawermenuitemEntidad.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // drawerHeader1
            // 
            this.drawerHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(165)))), ((int)(((byte)(221)))));
            this.drawerHeader1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerHeader1.HeaderText = "drawerHeader1";
            this.drawerHeader1.Location = new System.Drawing.Point(2, 100);
            this.drawerHeader1.Margin = new System.Windows.Forms.Padding(0);
            this.drawerHeader1.Name = "drawerHeader1";
            this.drawerHeader1.Size = new System.Drawing.Size(100, 50);
            this.drawerHeader1.TabIndex = 2;
            this.drawerHeader1.Text = "drawerHeader1";
            this.drawerHeader1.TextColor = System.Drawing.Color.White;
            // 
            // formMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.navigationDrawer1);
            this.Controls.Add(this.statusstripMain);
            this.Controls.Add(this.menustripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menustripMain;
            this.Name = "formMdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Me_Closing);
            this.Resize += new System.EventHandler(this.Me_Resize);
            this.menustripMain.ResumeLayout(false);
            this.menustripMain.PerformLayout();
            this.statusstripMain.ResumeLayout(false);
            this.statusstripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menustripMain;
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
        private System.Windows.Forms.ToolStripStatusLabel labelEstado;
        private System.Windows.Forms.ToolStripStatusLabel labelUsuarioNombre;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditarDeshacer;
        private System.Windows.Forms.ToolStripSeparator menuitemVentanaSeparadorCerrarTodas;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaEncajarEnVentana;
        private System.Windows.Forms.ToolStripSeparator menuitemVentanaSeparadorListaVentanas;
        private Syncfusion.Windows.Forms.Tools.NavigationDrawer navigationDrawer1;
        private Syncfusion.Windows.Forms.Tools.DrawerHeader drawerheaderTablas;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawermenuitemEntidad;
        private Syncfusion.Windows.Forms.Tools.DrawerHeader drawerHeader1;
    }
}



