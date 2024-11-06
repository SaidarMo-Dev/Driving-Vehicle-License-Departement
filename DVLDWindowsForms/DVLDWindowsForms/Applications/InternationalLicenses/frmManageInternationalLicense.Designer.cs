namespace DVLDWindowsForms.Applications.InternationalLicenses
{
    partial class frmManageInternationalLicense
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
            this.tbValue = new System.Windows.Forms.TextBox();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewInternationalLicenseApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvListInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmsApplicatoins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicneseHestoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cmsApplicatoins.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(210, 160);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 25;
            this.tbValue.TabStop = false;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalRecords.Location = new System.Drawing.Point(127, 429);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(16, 18);
            this.lblTotalRecords.TabIndex = 24;
            this.lblTotalRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(36, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "# Records :";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFilter.Items.AddRange(new object[] {
            "none",
            "Int.LicenseID",
            "DriverID",
            "ApplicationID",
            "LicenseID"});
            this.cbFilter.Location = new System.Drawing.Point(102, 159);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(92, 21);
            this.cbFilter.TabIndex = 22;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(29, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filter By :";
            // 
            // btnAddNewInternationalLicenseApplication
            // 
            this.btnAddNewInternationalLicenseApplication.BackColor = System.Drawing.Color.White;
            this.btnAddNewInternationalLicenseApplication.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.New_Application_64;
            this.btnAddNewInternationalLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewInternationalLicenseApplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddNewInternationalLicenseApplication.Location = new System.Drawing.Point(923, 129);
            this.btnAddNewInternationalLicenseApplication.Name = "btnAddNewInternationalLicenseApplication";
            this.btnAddNewInternationalLicenseApplication.Size = new System.Drawing.Size(60, 50);
            this.btnAddNewInternationalLicenseApplication.TabIndex = 20;
            this.btnAddNewInternationalLicenseApplication.UseVisualStyleBackColor = false;
            this.btnAddNewInternationalLicenseApplication.Click += new System.EventHandler(this.btnAddNewInternationalLicenseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Applications;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(460, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 123);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(872, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvListInternationalLicenses
            // 
            this.dgvListInternationalLicenses.AllowUserToAddRows = false;
            this.dgvListInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvListInternationalLicenses.AllowUserToOrderColumns = true;
            this.dgvListInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvListInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListInternationalLicenses.ContextMenuStrip = this.cmsApplicatoins;
            this.dgvListInternationalLicenses.Location = new System.Drawing.Point(32, 185);
            this.dgvListInternationalLicenses.Name = "dgvListInternationalLicenses";
            this.dgvListInternationalLicenses.ReadOnly = true;
            this.dgvListInternationalLicenses.Size = new System.Drawing.Size(951, 230);
            this.dgvListInternationalLicenses.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(411, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "International Licenses";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.International_32;
            this.pictureBox2.Location = new System.Drawing.Point(566, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // cmsApplicatoins
            // 
            this.cmsApplicatoins.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsApplicatoins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicneseHestoryToolStripMenuItem});
            this.cmsApplicatoins.Name = "contextMenuStrip1";
            this.cmsApplicatoins.Size = new System.Drawing.Size(238, 100);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.PersonDetails_323;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(237, 32);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.License_View_321;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(237, 32);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicneseHestoryToolStripMenuItem
            // 
            this.showPersonLicneseHestoryToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.PersonLicenseHistory_512;
            this.showPersonLicneseHestoryToolStripMenuItem.Name = "showPersonLicneseHestoryToolStripMenuItem";
            this.showPersonLicneseHestoryToolStripMenuItem.Size = new System.Drawing.Size(237, 32);
            this.showPersonLicneseHestoryToolStripMenuItem.Text = "Show Person Licnese Hestory";
            this.showPersonLicneseHestoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicneseHestoryToolStripMenuItem_Click);
            // 
            // frmManageInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 463);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewInternationalLicenseApplication);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvListInternationalLicenses);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageInternationalLicense";
            this.Text = "frmManageInternationalLicense";
            this.Load += new System.EventHandler(this.frmManageInternationalLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInternationalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cmsApplicatoins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewInternationalLicenseApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvListInternationalLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip cmsApplicatoins;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicneseHestoryToolStripMenuItem;
    }
}