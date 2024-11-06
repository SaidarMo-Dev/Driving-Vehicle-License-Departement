namespace DVLDWindowsForms.Applications.ReplacementForLostOrDamaged
{
    partial class frmReplacementForLostOrDamagedAplication
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
            this.ucDrivingLicenseInfoWithFilterCard1 = new DVLDWindowsForms.Applications.Licenses.Controls.ucDrivingLicenseInfoWithFilterCard();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRepLostLicene = new System.Windows.Forms.RadioButton();
            this.rbRepDamagedLicense = new System.Windows.Forms.RadioButton();
            this.linkLblShowReplacedLicense = new System.Windows.Forms.LinkLabel();
            this.linkLblShowPersonLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCreatedby = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblReplacementLicenseID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReplacementLicenseApplicationID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssueReplacement = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDrivingLicenseInfoWithFilterCard1
            // 
            this.ucDrivingLicenseInfoWithFilterCard1.FilterEnabled = true;
            this.ucDrivingLicenseInfoWithFilterCard1.Location = new System.Drawing.Point(12, 50);
            this.ucDrivingLicenseInfoWithFilterCard1.Name = "ucDrivingLicenseInfoWithFilterCard1";
            this.ucDrivingLicenseInfoWithFilterCard1.Size = new System.Drawing.Size(767, 403);
            this.ucDrivingLicenseInfoWithFilterCard1.TabIndex = 0;
            this.ucDrivingLicenseInfoWithFilterCard1.OnLicenseSelected += new System.Action<int>(this.ucDrivingLicenseInfoWithFilterCard1_OnLicenseSelected);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(165, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(438, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Replacement for Damaged License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRepLostLicene);
            this.groupBox1.Controls.Add(this.rbRepDamagedLicense);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(485, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement for";
            // 
            // rbRepLostLicene
            // 
            this.rbRepLostLicene.AutoSize = true;
            this.rbRepLostLicene.Location = new System.Drawing.Point(166, 23);
            this.rbRepLostLicene.Name = "rbRepLostLicene";
            this.rbRepLostLicene.Size = new System.Drawing.Size(94, 19);
            this.rbRepLostLicene.TabIndex = 1;
            this.rbRepLostLicene.TabStop = true;
            this.rbRepLostLicene.Text = "Lost License";
            this.rbRepLostLicene.UseVisualStyleBackColor = true;
            this.rbRepLostLicene.CheckedChanged += new System.EventHandler(this.rbRepLostLicene_CheckedChanged);
            // 
            // rbRepDamagedLicense
            // 
            this.rbRepDamagedLicense.AutoSize = true;
            this.rbRepDamagedLicense.Location = new System.Drawing.Point(24, 22);
            this.rbRepDamagedLicense.Name = "rbRepDamagedLicense";
            this.rbRepDamagedLicense.Size = new System.Drawing.Size(126, 19);
            this.rbRepDamagedLicense.TabIndex = 0;
            this.rbRepDamagedLicense.TabStop = true;
            this.rbRepDamagedLicense.Text = "Damaged License";
            this.rbRepDamagedLicense.UseVisualStyleBackColor = true;
            this.rbRepDamagedLicense.CheckedChanged += new System.EventHandler(this.rbRepDamagedLicense_CheckedChanged);
            // 
            // linkLblShowReplacedLicense
            // 
            this.linkLblShowReplacedLicense.AutoSize = true;
            this.linkLblShowReplacedLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblShowReplacedLicense.Location = new System.Drawing.Point(166, 605);
            this.linkLblShowReplacedLicense.Name = "linkLblShowReplacedLicense";
            this.linkLblShowReplacedLicense.Size = new System.Drawing.Size(115, 16);
            this.linkLblShowReplacedLicense.TabIndex = 12;
            this.linkLblShowReplacedLicense.TabStop = true;
            this.linkLblShowReplacedLicense.Text = "Show License Info";
            this.linkLblShowReplacedLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblShowLicense_LinkClicked);
            // 
            // linkLblShowPersonLicensesHistory
            // 
            this.linkLblShowPersonLicensesHistory.AutoSize = true;
            this.linkLblShowPersonLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblShowPersonLicensesHistory.Location = new System.Drawing.Point(11, 605);
            this.linkLblShowPersonLicensesHistory.Name = "linkLblShowPersonLicensesHistory";
            this.linkLblShowPersonLicensesHistory.Size = new System.Drawing.Size(143, 16);
            this.linkLblShowPersonLicensesHistory.TabIndex = 11;
            this.linkLblShowPersonLicensesHistory.TabStop = true;
            this.linkLblShowPersonLicensesHistory.Text = "Show Licenses History";
            this.linkLblShowPersonLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblShowPersonLicensesHistory_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblCreatedby);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblOldLicenseID);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblReplacementLicenseID);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblApplicationFees);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblApplicationDate);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblReplacementLicenseApplicationID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 447);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 145);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replacement License Info";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.User_32__2;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(498, 105);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 32);
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(385, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Created by :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreatedby
            // 
            this.lblCreatedby.AutoSize = true;
            this.lblCreatedby.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCreatedby.Location = new System.Drawing.Point(546, 110);
            this.lblCreatedby.Name = "lblCreatedby";
            this.lblCreatedby.Size = new System.Drawing.Size(31, 17);
            this.lblCreatedby.TabIndex = 40;
            this.lblCreatedby.Text = "N/A";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Driver_License_481;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(499, 62);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 32);
            this.pictureBox7.TabIndex = 36;
            this.pictureBox7.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(367, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Old License ID:";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblOldLicenseID.Location = new System.Drawing.Point(547, 67);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(31, 17);
            this.lblOldLicenseID.TabIndex = 35;
            this.lblOldLicenseID.Text = "N/A";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Renew_Driving_License_323;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(499, 27);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 31);
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.Location = new System.Drawing.Point(302, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Replacement License ID :";
            // 
            // lblReplacementLicenseID
            // 
            this.lblReplacementLicenseID.AutoSize = true;
            this.lblReplacementLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblReplacementLicenseID.Location = new System.Drawing.Point(547, 32);
            this.lblReplacementLicenseID.Name = "lblReplacementLicenseID";
            this.lblReplacementLicenseID.Size = new System.Drawing.Size(31, 17);
            this.lblReplacementLicenseID.TabIndex = 32;
            this.lblReplacementLicenseID.Text = "N/A";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.money_32;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(160, 105);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 32);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(96, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fees :";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblApplicationFees.Location = new System.Drawing.Point(206, 110);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(31, 17);
            this.lblApplicationFees.TabIndex = 28;
            this.lblApplicationFees.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Calendar_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(158, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Application Date :";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblApplicationDate.Location = new System.Drawing.Point(206, 67);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(31, 17);
            this.lblApplicationDate.TabIndex = 22;
            this.lblApplicationDate.Text = "N/A";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(158, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "L.R.Application ID :";
            // 
            // lblReplacementLicenseApplicationID
            // 
            this.lblReplacementLicenseApplicationID.AutoSize = true;
            this.lblReplacementLicenseApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblReplacementLicenseApplicationID.Location = new System.Drawing.Point(206, 32);
            this.lblReplacementLicenseApplicationID.Name = "lblReplacementLicenseApplicationID";
            this.lblReplacementLicenseApplicationID.Size = new System.Drawing.Size(31, 17);
            this.lblReplacementLicenseApplicationID.TabIndex = 19;
            this.lblReplacementLicenseApplicationID.Text = "N/A";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(451, 598);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssueReplacement
            // 
            this.btnIssueReplacement.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnIssueReplacement.FlatAppearance.BorderSize = 2;
            this.btnIssueReplacement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueReplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnIssueReplacement.Image = global::DVLDWindowsForms.Properties.Resources.Lost_Driving_License_321;
            this.btnIssueReplacement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueReplacement.Location = new System.Drawing.Point(567, 598);
            this.btnIssueReplacement.Name = "btnIssueReplacement";
            this.btnIssueReplacement.Size = new System.Drawing.Size(201, 35);
            this.btnIssueReplacement.TabIndex = 10;
            this.btnIssueReplacement.Text = "  Issue Replacement";
            this.btnIssueReplacement.UseVisualStyleBackColor = true;
            this.btnIssueReplacement.Click += new System.EventHandler(this.btnIssueReplacement_Click);
            // 
            // frmReplacementForLostOrDamagedAplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 640);
            this.Controls.Add(this.linkLblShowReplacedLicense);
            this.Controls.Add(this.linkLblShowPersonLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueReplacement);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ucDrivingLicenseInfoWithFilterCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplacementForLostOrDamagedAplication";
            this.Text = "frmReplacementForLostOrDamagedAplication";
            this.Load += new System.EventHandler(this.frmReplacementForLostOrDamagedAplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Controls.ucDrivingLicenseInfoWithFilterCard ucDrivingLicenseInfoWithFilterCard1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRepLostLicene;
        private System.Windows.Forms.RadioButton rbRepDamagedLicense;
        private System.Windows.Forms.LinkLabel linkLblShowReplacedLicense;
        private System.Windows.Forms.LinkLabel linkLblShowPersonLicensesHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssueReplacement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCreatedby;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblReplacementLicenseID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblReplacementLicenseApplicationID;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblOldLicenseID;
    }
}