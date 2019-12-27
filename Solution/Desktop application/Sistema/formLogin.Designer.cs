namespace CS_Gestion
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.toolstripMain = new System.Windows.Forms.ToolStrip();
            this.buttonCancelar = new System.Windows.Forms.ToolStripButton();
            this.buttonAceptar = new System.Windows.Forms.ToolStripButton();
            this.pictureboxMain = new System.Windows.Forms.PictureBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textboxNombre = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.toolstripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // toolstripMain
            // 
            this.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonCancelar,
            this.buttonAceptar});
            this.toolstripMain.Location = new System.Drawing.Point(0, 0);
            this.toolstripMain.Name = "toolstripMain";
            this.toolstripMain.Size = new System.Drawing.Size(310, 39);
            this.toolstripMain.TabIndex = 5;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonCancelar.Image = global::CS_Gestion.Properties.Resources.IMAGE_CANCEL_32;
            this.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 36);
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAceptar.Image = global::CS_Gestion.Properties.Resources.IMAGE_OK_32;
            this.buttonAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(84, 36);
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // pictureboxMain
            // 
            this.pictureboxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxMain.Image")));
            this.pictureboxMain.Location = new System.Drawing.Point(12, 42);
            this.pictureboxMain.Name = "pictureboxMain";
            this.pictureboxMain.Size = new System.Drawing.Size(48, 48);
            this.pictureboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureboxMain.TabIndex = 6;
            this.pictureboxMain.TabStop = false;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(140, 93);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(158, 20);
            this.textboxPassword.TabIndex = 10;
            this.textboxPassword.UseSystemPasswordChar = true;
            this.textboxPassword.Enter += new System.EventHandler(this.TextBoxs_GotFocus);
            // 
            // textboxNombre
            // 
            this.textboxNombre.Location = new System.Drawing.Point(140, 60);
            this.textboxNombre.MaxLength = 30;
            this.textboxNombre.Name = "textboxNombre";
            this.textboxNombre.Size = new System.Drawing.Size(158, 20);
            this.textboxNombre.TabIndex = 8;
            this.textboxNombre.Enter += new System.EventHandler(this.TextBoxs_GotFocus);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(66, 96);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 13);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Contraseña:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(66, 63);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(46, 13);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Usuario:";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 125);
            this.ControlBox = false;
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxNombre);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureboxMain);
            this.Controls.Add(this.toolstripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inicio de sesión";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Me_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Me_KeyPress);
            this.toolstripMain.ResumeLayout(false);
            this.toolstripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textboxNombre;
        private System.Windows.Forms.ToolStrip toolstripMain;
        private System.Windows.Forms.ToolStripButton buttonCancelar;
        private System.Windows.Forms.ToolStripButton buttonAceptar;
        private System.Windows.Forms.PictureBox pictureboxMain;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelNombre;
    }
}