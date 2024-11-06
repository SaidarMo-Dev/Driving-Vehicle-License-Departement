namespace DVLDWindowsForms.Detain_Licenses
{
    partial class frmDetainLicense
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFineFees = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCreatedby = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSelectedLicenseID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.linkLblShowLicense = new System.Windows.Forms.LinkLabel();
            this.linkLblShowPersonLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.epFillFineFees = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucDrivingLicenseInfoWithFilterCard1 = new DVLDWindowsForms.Applications.Licenses.Controls.ucDrivingLicenseInfoWithFilterCard();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFillFineFees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(302, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detain license";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFineFees);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblCreatedby);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblSelectedLicenseID);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblDetainDate);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDetainID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 153);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detain Info";
            // 
            // tbFineFees
            // 
            this.tbFineFees.Location = new System.Drawing.Point(192, 102);
            this.tbFineFees.Multiline = true;
            this.tbFineFees.Name = "tbFineFees";
            this.tbFineFees.Size = new System.Drawing.Size(238, 38);
            this.tbFineFees.TabIndex = 42;
            this.tbFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbFineFees_Validating);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.User_32__2;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(499, 67);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 32);
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(373, 72);
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
            this.lblCreatedby.Location = new System.Drawing.Point(547, 72);
            this.lblCreatedby.Name = "lblCreatedby";
            this.lblCreatedby.Size = new System.Drawing.Size(31, 17);
            this.lblCreatedby.TabIndex = 40;
            this.lblCreatedby.Text = "N/A";
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
            this.label15.Location = new System.Drawing.Point(373, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "License ID :";
            // 
            // lblSelectedLicenseID
            // 
            this.lblSelectedLicenseID.AutoSize = true;
            this.lblSelectedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSelectedLicenseID.Location = new System.Drawing.Point(547, 32);
            this.lblSelectedLicenseID.Name = "lblSelectedLicenseID";
            this.lblSelectedLicenseID.Size = new System.Drawing.Size(31, 17);
            this.lblSelectedLicenseID.TabIndex = 32;
            this.lblSelectedLicenseID.Text = "N/A";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.money_32;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(143, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 32);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fine Fees :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Calendar_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(141, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 32);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Detain Date :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDetainDate.Location = new System.Drawing.Point(189, 67);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(31, 17);
            this.lblDetainDate.TabIndex = 22;
            this.lblDetainDate.Text = "N/A";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(140, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Detain ID :";
            // 
            // lblDetainID
            // 
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDetainID.Location = new System.Drawing.Point(188, 32);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(31, 17);
            this.lblDetainID.TabIndex = 19;
            this.lblDetainID.Text = "N/A";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(545, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDetain.FlatAppearance.BorderSize = 2;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnDetain.Image = global::DVLDWindowsForms.Properties.Resources.Lost_Driving_License_321;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(661, 599);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(109, 35);
            this.btnDetain.TabIndex = 12;
            this.btnDetain.Text = "Detain";
            this.btnDetain.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // linkLblShowLicense
            // 
            this.linkLblShowLicense.AutoSize = true;
            this.linkLblShowLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblShowLicense.Location = new System.Drawing.Point(184, 609);
            this.linkLblShowLicense.Name = "linkLblShowLicense";
            this.linkLblShowLicense.Size = new System.Drawing.Size(115, 16);
            this.linkLblShowLicense.TabIndex = 14;
            this.linkLblShowLicense.TabStop = true;
            this.linkLblShowLicense.Text = "Show License Info";
            // 
            // linkLblShowPersonLicensesHistory
            // 
            this.linkLblShowPersonLicensesHistory.AutoSize = true;
            this.linkLblShowPersonLicensesHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblShowPersonLicensesHistory.Location = new System.Drawing.Point(29, 609);
            this.linkLblShowPersonLicensesHistory.Name = "linkLblShowPersonLicensesHistory";
            this.linkLblShowPersonLicensesHistory.Size = new System.Drawing.Size(143, 16);
            this.linkLblShowPersonLicensesHistory.TabIndex = 13;
            this.linkLblShowPersonLicensesHistory.TabStop = true;
            this.linkLblShowPersonLicensesHistory.Text = "Show Licenses History";
            // 
            // epFillFineFees
            // 
            this.epFillFineFees.ContainerControl = this;
            // 
            // ucDrivingLicenseInfoWithFilterCard1
            // 
            this.ucDrivingLicenseInfoWithFilterCard1.FilterEnabled = true;
            this.ucDrivingLicenseInfoWithFilterCard1.Location = new System.Drawing.Point(12, 42);
            this.ucDrivingLicenseInfoWithFilterCard1.Name = "ucDrivingLicenseInfoWithFilterCard1";
            this.ucDrivingLicenseInfoWithFilterCard1.Size = new System.Drawing.Size(767, 403);
            this.ucDrivingLicenseInfoWithFilterCard1.TabIndex = 0;
            this.ucDrivingLicenseInfoWithFilterCard1.OnLicenseSelected += new System.Action<int>(this.ucDrivingLicenseInfoWithFilterCard1_OnLicenseSelected);
            this.ucDrivingLicenseInfoWithFilterCard1.Load += new System.EventHandler(this.ucDrivingLicenseInfoWithFilterCard1_Load);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 639);
            this.Controls.Add(this.linkLblShowLicense);
            this.Controls.Add(this.linkLblShowPersonLicensesHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucDrivingLicenseInfoWithFilterCard1);
            this.Name = "frmDetainLicense";
            this.Text = "Detain License";
            this.Load += new System.EventHandler(this.frmDetainLicense_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFillFineFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.Licenses.Controls.ucDrivingLicenseInfoWithFilterCard ucDrivingLicenseInfoWithFilterCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCreatedby;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSelectedLicenseID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.LinkLabel linkLblShowLicense;
        private System.Windows.Forms.LinkLabel linkLblShowPersonLicensesHistory;
        private System.Windows.Forms.TextBox tbFineFees;
        private System.Windows.Forms.ErrorProvider epFillFineFees;
    }
}