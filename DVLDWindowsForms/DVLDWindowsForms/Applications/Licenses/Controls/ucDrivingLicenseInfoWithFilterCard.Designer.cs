namespace DVLDWindowsForms.Applications.Licenses.Controls
{
    partial class ucDrivingLicenseInfoWithFilterCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFindLicense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLicenseID = new System.Windows.Forms.TextBox();
            this.ucDiverLicenseInfo1 = new DVLDWindowsForms.Applications.Licenses.Controls.ucDiverLicenseInfo();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFindLicense);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.tbLicenseID);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(439, 63);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnFindLicense
            // 
            this.btnFindLicense.BackColor = System.Drawing.Color.White;
            this.btnFindLicense.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFindLicense.FlatAppearance.BorderSize = 2;
            this.btnFindLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindLicense.Image = global::DVLDWindowsForms.Properties.Resources.License_View_322;
            this.btnFindLicense.Location = new System.Drawing.Point(367, 14);
            this.btnFindLicense.Name = "btnFindLicense";
            this.btnFindLicense.Size = new System.Drawing.Size(55, 36);
            this.btnFindLicense.TabIndex = 2;
            this.btnFindLicense.UseVisualStyleBackColor = false;
            this.btnFindLicense.Click += new System.EventHandler(this.btnFindLicense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "License ID :";
            // 
            // tbLicenseID
            // 
            this.tbLicenseID.Location = new System.Drawing.Point(108, 24);
            this.tbLicenseID.Name = "tbLicenseID";
            this.tbLicenseID.Size = new System.Drawing.Size(230, 22);
            this.tbLicenseID.TabIndex = 0;
            this.tbLicenseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLicenseID_KeyPress);
            this.tbLicenseID.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            // 
            // ucDiverLicenseInfo1
            // 
            this.ucDiverLicenseInfo1.Location = new System.Drawing.Point(0, 66);
            this.ucDiverLicenseInfo1.Name = "ucDiverLicenseInfo1";
            this.ucDiverLicenseInfo1.Size = new System.Drawing.Size(765, 332);
            this.ucDiverLicenseInfo1.TabIndex = 1;
            // 
            // ucDrivingLicenseInfoWithFilterCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucDiverLicenseInfo1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ucDrivingLicenseInfoWithFilterCard";
            this.Size = new System.Drawing.Size(767, 403);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private ucDiverLicenseInfo ucDiverLicenseInfo1;
        private System.Windows.Forms.Button btnFindLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLicenseID;
    }
}
