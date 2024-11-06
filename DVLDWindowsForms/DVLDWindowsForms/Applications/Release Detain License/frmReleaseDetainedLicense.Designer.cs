namespace DVLDWindowsForms.Applications.Release_Detain_License
{
    partial class frmReleaseDetainedLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblShowDetainedLicene = new System.Windows.Forms.LinkLabel();
            this.linkLblShowPersonLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReleaseAppID = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFineFeesFees = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCreatedby = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDetainedLicenseID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDrivingLicenseInfoWithFilterCard1
            // 
            this.ucDrivingLicenseInfoWithFilterCard1.FilterEnabled = true;
            this.ucDrivingLicenseInfoWithFilterCard1.Location = new System.Drawing.Point(12, 47);
            this.ucDrivingLicenseInfoWithFilterCard1.Name = "ucDrivingLicenseInfoWithFilterCard1";
            this.ucDrivingLicenseInfoWithFilterCard1.Size = new System.Drawing.Size(767, 403);
            this.ucDrivingLicenseInfoWithFilterCard1.TabIndex = 0;
            this.ucDrivingLicenseInfoWithFilterCard1.OnLicenseSelected += new System.Action<int>(this.ucDrivingLicenseInfoWithFilterCard1_OnLicenseSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Release Detain license ";
            // 
            // linkLblShowDetainedLicene
            // 
            this.linkLblShowDetainedLicene.AutoSize = true;
            this.linkLblShowDetainedLicene.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblShowDetainedLicene.Location = new System.Drawing.Point(201, 637);
            this.linkLblShowDetainedLicene.Name = "linkLblShowDetainedLicene";
            this.linkLblShowDetainedLicene.Size = new System.Drawing.Size(115, 16);
            this.linkLblShowDetainedLicene.TabIndex = 16;
            this.linkLblShowDetainedLicene.TabStop = true;
            this.linkLblShowDetainedLicene.Text = "Show License Info";
            this.linkLblShowDetainedLicene.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblShowDetainedLicene_LinkClicked);
            // 
            // linkLblShowPersonLicensesHistory
            // 
            this.linkLblShowPersonLicensesHistory.AutoSize = true;
            this.linkLblShowPersonLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblShowPersonLicensesHistory.Location = new System.Drawing.Point(40, 638);
            this.linkLblShowPersonLicensesHistory.Name = "linkLblShowPersonLicensesHistory";
            this.linkLblShowPersonLicensesHistory.Size = new System.Drawing.Size(143, 16);
            this.linkLblShowPersonLicensesHistory.TabIndex = 15;
            this.linkLblShowPersonLicensesHistory.TabStop = true;
            this.linkLblShowPersonLicensesHistory.Text = "Show Licenses History";
            this.linkLblShowPersonLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblShowPersonLicensesHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(537, 627);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRelease.FlatAppearance.BorderSize = 2;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnRelease.Image = global::DVLDWindowsForms.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(657, 627);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(110, 35);
            this.btnRelease.TabIndex = 14;
            this.btnRelease.Text = "Release";
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblReleaseAppID);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblFineFeesFees);
            this.groupBox1.Controls.Add(this.pictureBox9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotalFees);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblCreatedby);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblDetainedLicenseID);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblApplicationFees);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDetainDate);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblDetainID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 175);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(564, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(357, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Release Application ID :";
            // 
            // lblReleaseAppID
            // 
            this.lblReleaseAppID.AutoSize = true;
            this.lblReleaseAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblReleaseAppID.Location = new System.Drawing.Point(612, 139);
            this.lblReleaseAppID.Name = "lblReleaseAppID";
            this.lblReleaseAppID.Size = new System.Drawing.Size(31, 17);
            this.lblReleaseAppID.TabIndex = 50;
            this.lblReleaseAppID.Text = "N/A";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.money_32;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(564, 96);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(31, 32);
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(430, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Fine Fees :";
            // 
            // lblFineFeesFees
            // 
            this.lblFineFeesFees.AutoSize = true;
            this.lblFineFeesFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFineFeesFees.Location = new System.Drawing.Point(611, 101);
            this.lblFineFeesFees.Name = "lblFineFeesFees";
            this.lblFineFeesFees.Size = new System.Drawing.Size(31, 17);
            this.lblFineFeesFees.TabIndex = 47;
            this.lblFineFeesFees.Text = "N/A";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.money_32;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(160, 134);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(31, 32);
            this.pictureBox9.TabIndex = 45;
            this.pictureBox9.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(23, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total Fees :";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTotalFees.Location = new System.Drawing.Point(208, 139);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(31, 17);
            this.lblTotalFees.TabIndex = 44;
            this.lblTotalFees.Text = "N/A";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.User_32__2;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(564, 59);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 32);
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(423, 68);
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
            this.lblCreatedby.Location = new System.Drawing.Point(612, 63);
            this.lblCreatedby.Name = "lblCreatedby";
            this.lblCreatedby.Size = new System.Drawing.Size(31, 17);
            this.lblCreatedby.TabIndex = 40;
            this.lblCreatedby.Text = "N/A";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(564, 28);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 31);
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label15.Location = new System.Drawing.Point(423, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "License ID :";
            // 
            // lblDetainedLicenseID
            // 
            this.lblDetainedLicenseID.AutoSize = true;
            this.lblDetainedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDetainedLicenseID.Location = new System.Drawing.Point(612, 35);
            this.lblDetainedLicenseID.Name = "lblDetainedLicenseID";
            this.lblDetainedLicenseID.Size = new System.Drawing.Size(31, 17);
            this.lblDetainedLicenseID.TabIndex = 32;
            this.lblDetainedLicenseID.Text = "N/A";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.money_32;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(160, 96);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 32);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(23, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "ApplicationFees :";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblApplicationFees.Location = new System.Drawing.Point(208, 101);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(31, 17);
            this.lblApplicationFees.TabIndex = 28;
            this.lblApplicationFees.Text = "N/A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Calendar_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(160, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Detain Date :";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDetainDate.Location = new System.Drawing.Point(208, 63);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(31, 17);
            this.lblDetainDate.TabIndex = 22;
            this.lblDetainDate.Text = "N/A";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(160, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Detain ID :";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDetainID.Location = new System.Drawing.Point(208, 35);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(31, 17);
            this.lblDetainID.TabIndex = 19;
            this.lblDetainID.Text = "N/A";
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 667);
            this.Controls.Add(this.linkLblShowDetainedLicene);
            this.Controls.Add(this.linkLblShowPersonLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucDrivingLicenseInfoWithFilterCard1);
            this.Name = "frmReleaseDetainedLicense";
            this.Text = "Release Detain License";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.Controls.ucDrivingLicenseInfoWithFilterCard ucDrivingLicenseInfoWithFilterCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLblShowDetainedLicene;
        private System.Windows.Forms.LinkLabel linkLblShowPersonLicensesHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReleaseAppID;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFineFeesFees;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCreatedby;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDetainedLicenseID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetainID;
    }
}