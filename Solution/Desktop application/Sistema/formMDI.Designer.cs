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
            this.groupbarMain = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupviewEntidades = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.imagelistMain = new System.Windows.Forms.ImageList(this.components);
            this.groupviewTablas = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupbaritemEntidades = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupbaritemTablas = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupbaritemReportes = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.menustripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupbarMain)).BeginInit();
            this.groupbarMain.SuspendLayout();
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
            this.menuitemVentanaMosaicoHorizontal.Image = global::CS_Gestion.Properties.Resources.ImageWindowTileHorizontally;
            this.menuitemVentanaMosaicoHorizontal.Name = "menuitemVentanaMosaicoHorizontal";
            this.menuitemVentanaMosaicoHorizontal.Size = new System.Drawing.Size(177, 22);
            this.menuitemVentanaMosaicoHorizontal.Text = "Mosaico &Horizontal";
            this.menuitemVentanaMosaicoHorizontal.Click += new System.EventHandler(this.menuitemVentanaMosaicoHorizontal_Click);
            // 
            // menuitemVentanaMosaicoVertical
            // 
            this.menuitemVentanaMosaicoVertical.Image = global::CS_Gestion.Properties.Resources.ImageWindowTileVertically;
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
            this.menuitemVentanaCerrarTodas.Image = global::CS_Gestion.Properties.Resources.ImageWindowCloseAll;
            this.menuitemVentanaCerrarTodas.Name = "menuitemVentanaCerrarTodas";
            this.menuitemVentanaCerrarTodas.Size = new System.Drawing.Size(177, 22);
            this.menuitemVentanaCerrarTodas.Text = "Ce&rrar Todas";
            this.menuitemVentanaCerrarTodas.Click += new System.EventHandler(this.menuitemVentanaCerrarTodas_Click);
            // 
            // menuitemVentanaEncajarEnVentana
            // 
            this.menuitemVentanaEncajarEnVentana.Image = global::CS_Gestion.Properties.Resources.ImageWindowFitToSize;
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
            // groupbarMain
            // 
            this.groupbarMain.AllowDrop = true;
            this.groupbarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupbarMain.BeforeTouchSize = new System.Drawing.Size(119, 407);
            this.groupbarMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.groupbarMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupbarMain.CollapseImage = ((System.Drawing.Image)(resources.GetObject("groupbarMain.CollapseImage")));
            this.groupbarMain.Controls.Add(this.groupviewEntidades);
            this.groupbarMain.Controls.Add(this.groupviewTablas);
            this.groupbarMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupbarMain.ExpandButtonToolTip = null;
            this.groupbarMain.ExpandImage = ((System.Drawing.Image)(resources.GetObject("groupbarMain.ExpandImage")));
            this.groupbarMain.FlatLook = true;
            this.groupbarMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupbarMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.groupbarMain.GroupBarDropDownToolTip = null;
            this.groupbarMain.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupbaritemEntidades,
            this.groupbaritemTablas,
            this.groupbaritemReportes});
            this.groupbarMain.IndexOnVisibleItems = true;
            this.groupbarMain.Location = new System.Drawing.Point(0, 24);
            this.groupbarMain.MinimizeButtonToolTip = null;
            this.groupbarMain.Name = "groupbarMain";
            this.groupbarMain.NavigationPaneTooltip = null;
            this.groupbarMain.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupbarMain.SelectedItem = 0;
            this.groupbarMain.Size = new System.Drawing.Size(119, 407);
            this.groupbarMain.SmartSizeBox = false;
            this.groupbarMain.Splittercolor = System.Drawing.Color.Red;
            this.groupbarMain.TabIndex = 6;
            this.groupbarMain.ThemeName = "Office2016Colorful";
            this.groupbarMain.ThemeStyle.CollapsedViewStyle.ItemStyle.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupbarMain.ThemeStyle.ItemStyle.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupbarMain.ThemeStyle.StackedViewStyle.CollapsedItemStyle.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.groupbarMain.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2016Colorful;
            // 
            // groupviewEntidades
            // 
            this.groupviewEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupviewEntidades.BeforeTouchSize = new System.Drawing.Size(117, 339);
            this.groupviewEntidades.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Entidades", 0, true, null, "Entidades")});
            this.groupviewEntidades.LargeImageList = this.imagelistMain;
            this.groupviewEntidades.Location = new System.Drawing.Point(1, 23);
            this.groupviewEntidades.Name = "groupviewEntidades";
            this.groupviewEntidades.Size = new System.Drawing.Size(117, 339);
            this.groupviewEntidades.TabIndex = 1;
            this.groupviewEntidades.Text = "groupviewEntidades";
            this.groupviewEntidades.TextSpacing = 16;
            this.groupviewEntidades.ThemeName = "Default";
            this.groupviewEntidades.ThemesEnabled = true;
            this.groupviewEntidades.ThemeStyle.BorderThickness = 1;
            this.groupviewEntidades.ThemeStyle.ItemStyle.BorderThickness = 1;
            this.groupviewEntidades.GroupViewItemSelected += new System.EventHandler(this.groupviewEntidades_GroupViewItemSelected);
            // 
            // imagelistMain
            // 
            this.imagelistMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagelistMain.ImageSize = new System.Drawing.Size(48, 48);
            this.imagelistMain.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupviewTablas
            // 
            this.groupviewTablas.BeforeTouchSize = new System.Drawing.Size(151, 361);
            this.groupviewTablas.GroupViewItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Bancos", -1, true, null, "Bancos"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Sucursales bancos", -1, true, null, "Sucursales bancos"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Tipos de documento", -1, true, null, "Tipos de documento"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Tipos de domicilio", -1, true, null, "Tipos de domicilio"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Tipos de email", -1, true, null, "Tipos de email"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Tipos de cuenta bancaria", -1, true, null, "Tipos de cuenta bancaria"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Tipos de movimiento", -1, true, null, "Tipos de movimiento"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Tipos de teléfono", -1, true, null, "Tipos de teléfono"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Grupos de usuarios", -1, true, null, "Grupos de usuarios"),
            new Syncfusion.Windows.Forms.Tools.GroupViewItem("Usuarios", -1, true, null, "Usuarios")});
            this.groupviewTablas.Location = new System.Drawing.Point(1, 45);
            this.groupviewTablas.Name = "groupviewTablas";
            this.groupviewTablas.Size = new System.Drawing.Size(151, 361);
            this.groupviewTablas.TabIndex = 0;
            this.groupviewTablas.Text = "groupView1";
            this.groupviewTablas.TextWrap = true;
            // 
            // groupbaritemEntidades
            // 
            this.groupbaritemEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupbaritemEntidades.Client = this.groupviewEntidades;
            this.groupbaritemEntidades.Text = "Principal";
            // 
            // groupbaritemTablas
            // 
            this.groupbaritemTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupbaritemTablas.Client = this.groupviewTablas;
            this.groupbaritemTablas.Text = "Tablas";
            // 
            // groupbaritemReportes
            // 
            this.groupbaritemReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupbaritemReportes.Client = null;
            this.groupbaritemReportes.Text = "Reportes";
            // 
            // formMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.groupbarMain);
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
            ((System.ComponentModel.ISupportInitialize)(this.groupbarMain)).EndInit();
            this.groupbarMain.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem menuitemVentana;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaCascada;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaMosaicoVertical;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaCerrarTodas;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaOrganizarIconos;
        private System.Windows.Forms.ToolStripMenuItem menuitemAyuda;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel labelEstado;
        private System.Windows.Forms.ToolStripMenuItem menuitemEditarDeshacer;
        private System.Windows.Forms.ToolStripSeparator menuitemVentanaSeparadorCerrarTodas;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaEncajarEnVentana;
        private System.Windows.Forms.ToolStripSeparator menuitemVentanaSeparadorListaVentanas;
        internal System.Windows.Forms.ToolStripMenuItem menuitemDebug;
        internal System.Windows.Forms.ToolStripStatusLabel labelUsuarioNombre;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupbarMain;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupbaritemEntidades;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupbaritemTablas;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupbaritemReportes;
        private Syncfusion.Windows.Forms.Tools.GroupView groupviewTablas;
        private Syncfusion.Windows.Forms.Tools.GroupView groupviewEntidades;
        private System.Windows.Forms.ImageList imagelistMain;
    }
}



