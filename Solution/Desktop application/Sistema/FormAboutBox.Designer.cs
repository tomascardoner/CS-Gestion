namespace CS_Gestion
{
    partial class FormAboutBox
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
            this.pictureboxCompanyLogo = new System.Windows.Forms.PictureBox();
            this.labelLicensedTo = new System.Windows.Forms.Label();
            this.pictureboxIcon = new System.Windows.Forms.PictureBox();
            this.labelApplicationTitle = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.listviewPropiedades = new System.Windows.Forms.ListView();
            this.columnPropiedad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OKButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxCompanyLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxCompanyLogo
            // 
            this.pictureboxCompanyLogo.Image = global::CS_Gestion.Properties.Resources.ImageCardonerSistemas;
            this.pictureboxCompanyLogo.Location = new System.Drawing.Point(302, 63);
            this.pictureboxCompanyLogo.Name = "pictureboxCompanyLogo";
            this.pictureboxCompanyLogo.Size = new System.Drawing.Size(128, 38);
            this.pictureboxCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxCompanyLogo.TabIndex = 16;
            this.pictureboxCompanyLogo.TabStop = false;
            // 
            // labelLicensedTo
            // 
            this.labelLicensedTo.BackColor = System.Drawing.Color.Transparent;
            this.labelLicensedTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLicensedTo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicensedTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLicensedTo.Location = new System.Drawing.Point(12, 111);
            this.labelLicensedTo.Name = "labelLicensedTo";
            this.labelLicensedTo.Size = new System.Drawing.Size(418, 31);
            this.labelLicensedTo.TabIndex = 15;
            this.labelLicensedTo.Text = "LicensedTo";
            this.labelLicensedTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureboxIcon
            // 
            this.pictureboxIcon.Image = global::CS_Gestion.Properties.Resources.ImageApplication256;
            this.pictureboxIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureboxIcon.Name = "pictureboxIcon";
            this.pictureboxIcon.Size = new System.Drawing.Size(90, 96);
            this.pictureboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxIcon.TabIndex = 9;
            this.pictureboxIcon.TabStop = false;
            // 
            // labelApplicationTitle
            // 
            this.labelApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplicationTitle.Location = new System.Drawing.Point(111, 12);
            this.labelApplicationTitle.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelApplicationTitle.Name = "labelApplicationTitle";
            this.labelApplicationTitle.Size = new System.Drawing.Size(319, 29);
            this.labelApplicationTitle.TabIndex = 10;
            this.labelApplicationTitle.Text = "Application Title";
            this.labelApplicationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(111, 41);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(319, 18);
            this.labelVersion.TabIndex = 11;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Location = new System.Drawing.Point(111, 70);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(185, 38);
            this.labelCopyright.TabIndex = 12;
            this.labelCopyright.Text = "Copyright";
            // 
            // listviewPropiedades
            // 
            this.listviewPropiedades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPropiedad,
            this.columnValor});
            this.listviewPropiedades.FullRowSelect = true;
            this.listviewPropiedades.GridLines = true;
            this.listviewPropiedades.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listviewPropiedades.HideSelection = false;
            this.listviewPropiedades.Location = new System.Drawing.Point(12, 145);
            this.listviewPropiedades.MultiSelect = false;
            this.listviewPropiedades.Name = "listviewPropiedades";
            this.listviewPropiedades.ShowGroups = false;
            this.listviewPropiedades.ShowItemToolTips = true;
            this.listviewPropiedades.Size = new System.Drawing.Size(418, 116);
            this.listviewPropiedades.TabIndex = 14;
            this.listviewPropiedades.UseCompatibleStateImageBehavior = false;
            this.listviewPropiedades.View = System.Windows.Forms.View.Details;
            // 
            // columnPropiedad
            // 
            this.columnPropiedad.Text = "Propiedad";
            this.columnPropiedad.Width = 95;
            // 
            // columnValor
            // 
            this.columnValor.Text = "Valor";
            this.columnValor.Width = 315;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKButton.Location = new System.Drawing.Point(355, 267);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 13;
            this.OKButton.Text = "&OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // FormAboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 302);
            this.Controls.Add(this.pictureboxCompanyLogo);
            this.Controls.Add(this.labelLicensedTo);
            this.Controls.Add(this.pictureboxIcon);
            this.Controls.Add(this.labelApplicationTitle);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.listviewPropiedades);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAboutBox";
            this.Load += new System.EventHandler(this.this_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxCompanyLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox pictureboxCompanyLogo;
        internal System.Windows.Forms.Label labelLicensedTo;
        internal System.Windows.Forms.PictureBox pictureboxIcon;
        internal System.Windows.Forms.Label labelApplicationTitle;
        internal System.Windows.Forms.Label labelVersion;
        internal System.Windows.Forms.Label labelCopyright;
        internal System.Windows.Forms.ListView listviewPropiedades;
        internal System.Windows.Forms.ColumnHeader columnPropiedad;
        internal System.Windows.Forms.ColumnHeader columnValor;
        internal System.Windows.Forms.Button OKButton;
    }
}