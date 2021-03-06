﻿namespace CS_Gestion
{
    partial class FormMdi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMdi));
            this.menuitemVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaMosaicoHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaMosaicoVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaOrganizarIconos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaSeparadorCerrarTodas = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemVentanaCerrarTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaEncajarEnVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemVentanaSeparadorListaVentanas = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemArchivoOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemArchivoSeparadorCerrarSesion = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemArchivoCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemArchivoSeparadorSalir = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemAyudaAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusstripMain = new System.Windows.Forms.StatusStrip();
            this.labelEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelUsuarioNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupbarMain = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupviewPrincipal = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.imagelistMain = new System.Windows.Forms.ImageList(this.components);
            this.groupviewReportes = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupviewTablas = new Syncfusion.Windows.Forms.Tools.GroupView();
            this.groupbaritemEntidades = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupbaritemTablas = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupbaritemReportes = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.menustripMain = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.groupbarMain)).BeginInit();
            this.groupbarMain.SuspendLayout();
            this.menustripMain.SuspendLayout();
            this.SuspendLayout();
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
            this.menuitemVentanaMosaicoHorizontal.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaMosaicoHorizontal.Text = "Mosaico &Horizontal";
            this.menuitemVentanaMosaicoHorizontal.Click += new System.EventHandler(this.menuitemVentanaMosaicoHorizontal_Click);
            // 
            // menuitemVentanaMosaicoVertical
            // 
            this.menuitemVentanaMosaicoVertical.Image = global::CS_Gestion.Properties.Resources.ImageWindowTileVertically;
            this.menuitemVentanaMosaicoVertical.Name = "menuitemVentanaMosaicoVertical";
            this.menuitemVentanaMosaicoVertical.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaMosaicoVertical.Text = "Mosaico &Vertical";
            this.menuitemVentanaMosaicoVertical.Click += new System.EventHandler(this.menuitemVentanaMosaicoVertical_Click);
            // 
            // menuitemVentanaCascada
            // 
            this.menuitemVentanaCascada.Name = "menuitemVentanaCascada";
            this.menuitemVentanaCascada.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaCascada.Text = "&Cascada";
            this.menuitemVentanaCascada.Click += new System.EventHandler(this.menuitemVentanaCascada_Click);
            // 
            // menuitemVentanaOrganizarIconos
            // 
            this.menuitemVentanaOrganizarIconos.Name = "menuitemVentanaOrganizarIconos";
            this.menuitemVentanaOrganizarIconos.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaOrganizarIconos.Text = "&Organizar Íconos";
            this.menuitemVentanaOrganizarIconos.Click += new System.EventHandler(this.menuitemVentanaOrganizarIconos_Click);
            // 
            // menuitemVentanaSeparadorCerrarTodas
            // 
            this.menuitemVentanaSeparadorCerrarTodas.Name = "menuitemVentanaSeparadorCerrarTodas";
            this.menuitemVentanaSeparadorCerrarTodas.Size = new System.Drawing.Size(177, 6);
            // 
            // menuitemVentanaCerrarTodas
            // 
            this.menuitemVentanaCerrarTodas.Image = global::CS_Gestion.Properties.Resources.ImageWindowCloseAll;
            this.menuitemVentanaCerrarTodas.Name = "menuitemVentanaCerrarTodas";
            this.menuitemVentanaCerrarTodas.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaCerrarTodas.Text = "Ce&rrar Todas";
            this.menuitemVentanaCerrarTodas.Click += new System.EventHandler(this.menuitemVentanaCerrarTodas_Click);
            // 
            // menuitemVentanaEncajarEnVentana
            // 
            this.menuitemVentanaEncajarEnVentana.Image = global::CS_Gestion.Properties.Resources.ImageWindowFitToSize;
            this.menuitemVentanaEncajarEnVentana.Name = "menuitemVentanaEncajarEnVentana";
            this.menuitemVentanaEncajarEnVentana.Size = new System.Drawing.Size(180, 22);
            this.menuitemVentanaEncajarEnVentana.Text = "Encajar en ventana";
            this.menuitemVentanaEncajarEnVentana.Click += new System.EventHandler(this.menuitemVentanaEncajarEnVentana_Click);
            // 
            // menuitemVentanaSeparadorListaVentanas
            // 
            this.menuitemVentanaSeparadorListaVentanas.Name = "menuitemVentanaSeparadorListaVentanas";
            this.menuitemVentanaSeparadorListaVentanas.Size = new System.Drawing.Size(177, 6);
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
            // menuitemDebug
            // 
            this.menuitemDebug.Name = "menuitemDebug";
            this.menuitemDebug.Size = new System.Drawing.Size(54, 20);
            this.menuitemDebug.Text = "&Debug";
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
            this.menuitemAyudaAcercaDe.Click += new System.EventHandler(this.menuitemAyudaAcercaDe_Click);
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
            this.groupbarMain.Controls.Add(this.groupviewPrincipal);
            this.groupbarMain.Controls.Add(this.groupviewReportes);
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
            // groupviewPrincipal
            // 
            this.groupviewPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupviewPrincipal.BeforeTouchSize = new System.Drawing.Size(117, 339);
            this.groupviewPrincipal.LargeImageList = this.imagelistMain;
            this.groupviewPrincipal.Location = new System.Drawing.Point(1, 23);
            this.groupviewPrincipal.Name = "groupviewPrincipal";
            this.groupviewPrincipal.Size = new System.Drawing.Size(117, 339);
            this.groupviewPrincipal.TabIndex = 1;
            this.groupviewPrincipal.Text = "Entidades";
            this.groupviewPrincipal.TextSpacing = 16;
            this.groupviewPrincipal.ThemeName = "Default";
            this.groupviewPrincipal.ThemesEnabled = true;
            this.groupviewPrincipal.ThemeStyle.BorderThickness = 1;
            this.groupviewPrincipal.ThemeStyle.ItemStyle.BorderThickness = 1;
            this.groupviewPrincipal.GroupViewItemSelected += new System.EventHandler(this.ComandosPrincipales_ItemSelected);
            // 
            // imagelistMain
            // 
            this.imagelistMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagelistMain.ImageSize = new System.Drawing.Size(48, 48);
            this.imagelistMain.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupviewReportes
            // 
            this.groupviewReportes.BeforeTouchSize = new System.Drawing.Size(218, 1);
            this.groupviewReportes.Location = new System.Drawing.Point(1, 299);
            this.groupviewReportes.Name = "groupviewReportes";
            this.groupviewReportes.Size = new System.Drawing.Size(218, 1);
            this.groupviewReportes.TabIndex = 2;
            this.groupviewReportes.Text = "Tablas";
            this.groupviewReportes.TextWrap = true;
            // 
            // groupviewTablas
            // 
            this.groupviewTablas.BeforeTouchSize = new System.Drawing.Size(117, 0);
            this.groupviewTablas.Location = new System.Drawing.Point(1, 384);
            this.groupviewTablas.Name = "groupviewTablas";
            this.groupviewTablas.Size = new System.Drawing.Size(117, 0);
            this.groupviewTablas.TabIndex = 0;
            this.groupviewTablas.Text = "Tablas";
            this.groupviewTablas.TextWrap = true;
            this.groupviewTablas.GroupViewItemSelected += new System.EventHandler(this.ComandosTablas_ItemSelected);
            // 
            // groupbaritemEntidades
            // 
            this.groupbaritemEntidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.groupbaritemEntidades.Client = this.groupviewPrincipal;
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
            this.groupbaritemReportes.Client = this.groupviewReportes;
            this.groupbaritemReportes.Text = "Reportes";
            // 
            // menustripMain
            // 
            this.menustripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemArchivo,
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
            // FormMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 453);
            this.Controls.Add(this.groupbarMain);
            this.Controls.Add(this.statusstripMain);
            this.Controls.Add(this.menustripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menustripMain;
            this.Name = "FormMdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Me_Closing);
            this.Resize += new System.EventHandler(this.Me_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.groupbarMain)).EndInit();
            this.groupbarMain.ResumeLayout(false);
            this.menustripMain.ResumeLayout(false);
            this.menustripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusstripMain;
        private System.Windows.Forms.ToolStripSeparator menuitemArchivoSeparadorCerrarSesion;
        private System.Windows.Forms.ToolStripSeparator menuitemArchivoSeparadorSalir;
        private System.Windows.Forms.ToolStripMenuItem menuitemAyudaAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaMosaicoHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuitemArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuitemArchivoOpciones;
        private System.Windows.Forms.ToolStripMenuItem menuitemArchivoCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem menuitemArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentana;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaCascada;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaMosaicoVertical;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaCerrarTodas;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaOrganizarIconos;
        private System.Windows.Forms.ToolStripMenuItem menuitemAyuda;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel labelEstado;
        private System.Windows.Forms.ToolStripSeparator menuitemVentanaSeparadorCerrarTodas;
        private System.Windows.Forms.ToolStripMenuItem menuitemVentanaEncajarEnVentana;
        private System.Windows.Forms.ToolStripSeparator menuitemVentanaSeparadorListaVentanas;
        internal System.Windows.Forms.ToolStripMenuItem menuitemDebug;
        internal System.Windows.Forms.ToolStripStatusLabel labelUsuarioNombre;
        private Syncfusion.Windows.Forms.Tools.GroupBar groupbarMain;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupbaritemEntidades;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupbaritemTablas;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupbaritemReportes;
        private System.Windows.Forms.ImageList imagelistMain;
        internal Syncfusion.Windows.Forms.Tools.GroupView groupviewTablas;
        internal Syncfusion.Windows.Forms.Tools.GroupView groupviewPrincipal;
        internal Syncfusion.Windows.Forms.Tools.GroupView groupviewReportes;
        private System.Windows.Forms.MenuStrip menustripMain;
    }
}



