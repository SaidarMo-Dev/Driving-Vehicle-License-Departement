namespace DVLDWindowsForms.Applications
{
    partial class frmManageLocaleDrinvingLicenseAppplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListLocalDrivingLicenseApplications = new System.Windows.Forms.DataGridView();
            this.cmsApplicatoins = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sechduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleWritenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schduleStretTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicneseHestoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.btnAddNewLocalDrivingLicenseApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLocalDrivingLicenseApplications)).BeginInit();
            this.cmsApplicatoins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(286, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Driving License Applications";
            // 
            // dgvListLocalDrivingLicenseApplications
            // 
            this.dgvListLocalDrivingLicenseApplications.AllowUserToAddRows = false;
            this.dgvListLocalDrivingLicenseApplications.AllowUserToDeleteRows = false;
            this.dgvListLocalDrivingLicenseApplications.AllowUserToOrderColumns = true;
            this.dgvListLocalDrivingLicenseApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvListLocalDrivingLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLocalDrivingLicenseApplications.ContextMenuStrip = this.cmsApplicatoins;
            this.dgvListLocalDrivingLicenseApplications.Location = new System.Drawing.Point(8, 213);
            this.dgvListLocalDrivingLicenseApplications.Name = "dgvListLocalDrivingLicenseApplications";
            this.dgvListLocalDrivingLicenseApplications.ReadOnly = true;
            this.dgvListLocalDrivingLicenseApplications.Size = new System.Drawing.Size(951, 230);
            this.dgvListLocalDrivingLicenseApplications.TabIndex = 2;
            this.dgvListLocalDrivingLicenseApplications.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListLocalDrivingLicenseApplications_CellMouseDown);
            // 
            // cmsApplicatoins
            // 
            this.cmsApplicatoins.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsApplicatoins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.editApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.sechduleTestToolStripMenuItem,
            this.toolStripSeparator4,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator5,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator6,
            this.showPersonLicneseHestoryToolStripMenuItem});
            this.cmsApplicatoins.Name = "contextMenuStrip1";
            this.cmsApplicatoins.Size = new System.Drawing.Size(255, 296);
            this.cmsApplicatoins.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplicatoins_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.PersonDetails_323;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.edit_322;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(251, 6);
            // 
            // sechduleTestToolStripMenuItem
            // 
            this.sechduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schduleVisionTestToolStripMenuItem,
            this.schduleWritenTestToolStripMenuItem,
            this.schduleStretTestToolStripMenuItem});
            this.sechduleTestToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Schedule_Test_512;
            this.sechduleTestToolStripMenuItem.Name = "sechduleTestToolStripMenuItem";
            this.sechduleTestToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.sechduleTestToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // schduleVisionTestToolStripMenuItem
            // 
            this.schduleVisionTestToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Vision_Test_32;
            this.schduleVisionTestToolStripMenuItem.Name = "schduleVisionTestToolStripMenuItem";
            this.schduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.schduleVisionTestToolStripMenuItem.Text = "Schdule Vision Test";
            this.schduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.schduleVisionTestToolStripMenuItem_Click);
            // 
            // schduleWritenTestToolStripMenuItem
            // 
            this.schduleWritenTestToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Written_Test_32_Sechdule;
            this.schduleWritenTestToolStripMenuItem.Name = "schduleWritenTestToolStripMenuItem";
            this.schduleWritenTestToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.schduleWritenTestToolStripMenuItem.Text = "Schdule Writen Test";
            this.schduleWritenTestToolStripMenuItem.Click += new System.EventHandler(this.schduleWritenTestToolStripMenuItem_Click);
            // 
            // schduleStretTestToolStripMenuItem
            // 
            this.schduleStretTestToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Street_Test_32;
            this.schduleStretTestToolStripMenuItem.Name = "schduleStretTestToolStripMenuItem";
            this.schduleStretTestToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.schduleStretTestToolStripMenuItem.Text = "Schdule Street Test";
            this.schduleStretTestToolStripMenuItem.Click += new System.EventHandler(this.schduleStretTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(251, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(251, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.License_View_321;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(251, 6);
            // 
            // showPersonLicneseHestoryToolStripMenuItem
            // 
            this.showPersonLicneseHestoryToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.PersonLicenseHistory_512;
            this.showPersonLicneseHestoryToolStripMenuItem.Name = "showPersonLicneseHestoryToolStripMenuItem";
            this.showPersonLicneseHestoryToolStripMenuItem.Size = new System.Drawing.Size(254, 32);
            this.showPersonLicneseHestoryToolStripMenuItem.Text = "Show Person Licnese Hestory";
            this.showPersonLicneseHestoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicneseHestoryToolStripMenuItem_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFilter.Items.AddRange(new object[] {
            "none",
            "National.No",
            "L.D.L.AppID",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(78, 187);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(92, 21);
            this.cbFilter.TabIndex = 12;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(5, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Filter By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "# Records :";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTotalRecords.Location = new System.Drawing.Point(103, 457);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(16, 18);
            this.lblTotalRecords.TabIndex = 14;
            this.lblTotalRecords.Text = "0";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(186, 188);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(100, 20);
            this.tbValue.TabIndex = 15;
            this.tbValue.TabStop = false;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            // 
            // btnAddNewLocalDrivingLicenseApplication
            // 
            this.btnAddNewLocalDrivingLicenseApplication.BackColor = System.Drawing.Color.White;
            this.btnAddNewLocalDrivingLicenseApplication.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.New_Application_64;
            this.btnAddNewLocalDrivingLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewLocalDrivingLicenseApplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddNewLocalDrivingLicenseApplication.Location = new System.Drawing.Point(899, 157);
            this.btnAddNewLocalDrivingLicenseApplication.Name = "btnAddNewLocalDrivingLicenseApplication";
            this.btnAddNewLocalDrivingLicenseApplication.Size = new System.Drawing.Size(60, 50);
            this.btnAddNewLocalDrivingLicenseApplication.TabIndex = 8;
            this.btnAddNewLocalDrivingLicenseApplication.UseVisualStyleBackColor = false;
            this.btnAddNewLocalDrivingLicenseApplication.Click += new System.EventHandler(this.btnAddNewLocalDrivingLicenseApplication_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(848, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Applications;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(398, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageLocaleDrinvingLicenseAppplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 489);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewLocalDrivingLicenseApplication);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvListLocalDrivingLicenseApplications);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageLocaleDrinvingLicenseAppplication";
            this.Text = "frmManageLocaleDrinvingLicenseAppplication";
            this.Load += new System.EventHandler(this.frmManageLocaleDrinvingLicenseAppplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLocalDrivingLicenseApplications)).EndInit();
            this.cmsApplicatoins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListLocalDrivingLicenseApplications;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddNewLocalDrivingLicenseApplication;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsApplicatoins;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicneseHestoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleWritenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schduleStretTestToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.TextBox tbValue;
    }
}