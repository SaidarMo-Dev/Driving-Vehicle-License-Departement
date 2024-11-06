namespace DVLDWindowsForms.Applications
{
    partial class frmAddEditLocalDrivingLicenseApplication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucFindPerson1 = new DVLDWindowsForms.ucFindPerson();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucPersonInfo = new DVLDWindowsForms.ucFindPerson();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucFindPerson1);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Person Info ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ucFindPerson1
            // 
            this.ucFindPerson1.FilterEnabled = true;
            this.ucFindPerson1.Location = new System.Drawing.Point(6, 11);
            this.ucFindPerson1.Name = "ucFindPerson1";
            this.ucFindPerson1.Size = new System.Drawing.Size(831, 416);
            this.ucFindPerson1.TabIndex = 2;
            this.ucFindPerson1.UserID = 0;
            this.ucFindPerson1.OnPersonSelected += new System.Action<int>(this.ucFindPerson1_OnPersonSelected);
            this.ucFindPerson1.Load += new System.EventHandler(this.ucFindPerson1_Load);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnNext.Image = global::DVLDWindowsForms.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(712, 443);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "   Next ";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCreatedByUser);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lblFees);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cbLicenseClasses);
            this.tabPage2.Controls.Add(this.lblApplicationDate);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblApplicationID);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.Location = new System.Drawing.Point(270, 265);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(42, 24);
            this.lblCreatedByUser.TabIndex = 28;
            this.lblCreatedByUser.Text = "N/A";
            this.lblCreatedByUser.Click += new System.EventHandler(this.lblCreatedByUser_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(56, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Created By :";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(269, 218);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(42, 24);
            this.lblFees.TabIndex = 25;
            this.lblFees.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(55, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Application Fees :";
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(273, 173);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(235, 21);
            this.cbLicenseClasses.TabIndex = 22;
            this.cbLicenseClasses.SelectedIndexChanged += new System.EventHandler(this.cbLicenseClass_SelectedIndexChanged);
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(269, 117);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(42, 24);
            this.lblApplicationDate.TabIndex = 21;
            this.lblApplicationDate.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(55, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Application Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(55, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "License Class :";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(269, 64);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(50, 24);
            this.lblApplicationID.TabIndex = 15;
            this.lblApplicationID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "D.L Application ID :";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label13.Image = global::DVLDWindowsForms.Properties.Resources.User_32__2;
            this.label13.Location = new System.Drawing.Point(215, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 31);
            this.label13.TabIndex = 27;
            this.label13.Text = "     ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label10.Image = global::DVLDWindowsForms.Properties.Resources.money_32;
            this.label10.Location = new System.Drawing.Point(214, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "     ";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label9.Image = global::DVLDWindowsForms.Properties.Resources.Calendar_32;
            this.label9.Location = new System.Drawing.Point(214, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "     ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label6.Image = global::DVLDWindowsForms.Properties.Resources.Renew_Driving_License_321;
            this.label6.Location = new System.Drawing.Point(214, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "     ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label3.Location = new System.Drawing.Point(214, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "     ";
            // 
            // ucPersonInfo
            // 
            this.ucPersonInfo.FilterEnabled = true;
            this.ucPersonInfo.Location = new System.Drawing.Point(9, 9);
            this.ucPersonInfo.Name = "ucPersonInfo";
            this.ucPersonInfo.Size = new System.Drawing.Size(831, 416);
            this.ucPersonInfo.TabIndex = 0;
            this.ucPersonInfo.UserID = 0;
            this.ucPersonInfo.Load += new System.EventHandler(this.ucGetPersonForApplication_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Local Driving License Applicartion";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(652, 587);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSave.Image = global::DVLDWindowsForms.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(778, 587);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "  Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEditLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 634);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddEditLocalDrivingLicenseApplication";
            this.Text = "frmNewLocalDrivingLicense";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicense_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private ucFindPerson ucPersonInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private ucFindPerson ucFindPerson1;
    }
}