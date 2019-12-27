namespace CS_Gestion
{
    partial class formSplash
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelLicensedTo = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(13, 257);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(474, 16);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLicensedTo
            // 
            this.labelLicensedTo.BackColor = System.Drawing.Color.Transparent;
            this.labelLicensedTo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicensedTo.ForeColor = System.Drawing.Color.White;
            this.labelLicensedTo.Location = new System.Drawing.Point(13, 215);
            this.labelLicensedTo.Name = "labelLicensedTo";
            this.labelLicensedTo.Size = new System.Drawing.Size(474, 31);
            this.labelLicensedTo.TabIndex = 9;
            this.labelLicensedTo.Text = "LicensedTo";
            this.labelLicensedTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCopyright
            // 
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(13, 283);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(474, 16);
            this.labelCopyright.TabIndex = 8;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.labelCompanyName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.ForeColor = System.Drawing.Color.Gold;
            this.labelCompanyName.Location = new System.Drawing.Point(61, 33);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(426, 23);
            this.labelCompanyName.TabIndex = 7;
            this.labelCompanyName.Text = "CompanyName";
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAppTitle.Font = new System.Drawing.Font("Tahoma", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppTitle.ForeColor = System.Drawing.Color.White;
            this.labelAppTitle.Location = new System.Drawing.Point(18, 48);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(469, 71);
            this.labelAppTitle.TabIndex = 6;
            this.labelAppTitle.Text = "Title";
            // 
            // formSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.ControlBox = false;
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelLicensedTo);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelAppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App.Title";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label labelStatus;
        internal System.Windows.Forms.Label labelLicensedTo;
        internal System.Windows.Forms.Label labelCopyright;
        internal System.Windows.Forms.Label labelCompanyName;
        internal System.Windows.Forms.Label labelAppTitle;
    }
}