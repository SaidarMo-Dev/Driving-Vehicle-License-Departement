namespace DVLDWindowsForms.Detain_Licenses
{
    partial class frmManageDetainLicenses
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
            this.dgvListDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.cmsApplicatoins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicneseHestoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReleseLicense = new System.Windows.Forms.Button();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbIsReleased = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetainedLicenses)).BeginInit();
            this.cmsApplicatoins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(213, 165);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 36;
            this.tbValue.TabStop = false;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            this.tbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValue_KeyPress);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalRecords.Location = new System.Drawing.Point(102, 434);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(16, 18);
            this.lblTotalRecords.TabIndex = 35;
            this.lblTotalRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(11, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "# Records :";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFilter.Items.AddRange(new object[] {
            "none",
            "Detain ID",
            "Is Released",
            "National.No",
            "Full Name",
            "Release Application ID"});
            this.cbFilter.Location = new System.Drawing.Point(74, 164);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(130, 21);
            this.cbFilter.TabIndex = 33;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(4, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Filter By :";
            // 
            // dgvListDetainedLicenses
            // 
            this.dgvListDetainedLicenses.AllowUserToAddRows = false;
            this.dgvListDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvListDetainedLicenses.AllowUserToOrderColumns = true;
            this.dgvListDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDetainedLicenses.ContextMenuStrip = this.cmsApplicatoins;
            this.dgvListDetainedLicenses.Location = new System.Drawing.Point(7, 190);
            this.dgvListDetainedLicenses.Name = "dgvListDetainedLicenses";
            this.dgvListDetainedLicenses.ReadOnly = true;
            this.dgvListDetainedLicenses.Size = new System.Drawing.Size(951, 230);
            this.dgvListDetainedLicenses.TabIndex = 29;
            // 
            // cmsApplicatoins
            // 
            this.cmsApplicatoins.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsApplicatoins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicneseHestoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.cmsApplicatoins.Name = "contextMenuStrip1";
            this.cmsApplicatoins.Size = new System.Drawing.Size(238, 138);
            this.cmsApplicatoins.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplicatoins_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.PersonDetails_323;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(237, 32);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Person Details";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(237, 32);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(386, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "List Detained Licenses";
            // 
            // btnReleseLicense
            // 
            this.btnReleseLicense.BackColor = System.Drawing.Color.White;
            this.btnReleseLicense.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Release_Detained_License_64;
            this.btnReleseLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReleseLicense.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReleseLicense.Location = new System.Drawing.Point(818, 144);
            this.btnReleseLicense.Name = "btnReleseLicense";
            this.btnReleseLicense.Size = new System.Drawing.Size(67, 41);
            this.btnReleseLicense.TabIndex = 37;
            this.btnReleseLicense.UseVisualStyleBackColor = false;
            this.btnReleseLicense.Click += new System.EventHandler(this.btnReleseLicense_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackColor = System.Drawing.Color.White;
            this.btnDetainLicense.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Detain_641;
            this.btnDetainLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetainLicense.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDetainLicense.Location = new System.Drawing.Point(891, 144);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(67, 40);
            this.btnDetainLicense.TabIndex = 31;
            this.btnDetainLicense.UseVisualStyleBackColor = false;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnAddNewInternationalLicenseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Detain_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(435, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 123);
            this.pictureBox1.TabIndex = 27;
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
            this.btnClose.Location = new System.Drawing.Point(847, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.AllowDrop = true;
            this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(215, 163);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(53, 21);
            this.cbIsReleased.TabIndex = 38;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // frmManageDetainLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 466);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.btnReleseLicense);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvListDetainedLicenses);
            this.Controls.Add(this.label1);
            this.Name = "frmManageDetainLicenses";
            this.Text = "Manage Detain Licenses";
            this.Load += new System.EventHandler(this.frmManageDetainLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDetainedLicenses)).EndInit();
            this.cmsApplicatoins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvListDetainedLicenses;
        private System.Windows.Forms.ContextMenuStrip cmsApplicatoins;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicneseHestoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReleseLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbIsReleased;
    }
}