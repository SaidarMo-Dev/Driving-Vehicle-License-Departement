namespace DVLDWindowsForms.Controls
{
    partial class ucDrivingLicenseApplicationInfo
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
            this.lblLocalDrivingLicenseApplicationID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPassedTests = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLicenseTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucApplicationBasicInfo1 = new DVLDWindowsForms.Controls.ucApplicationBasicInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocalDrivingLicenseApplicationID
            // 
            this.lblLocalDrivingLicenseApplicationID.AutoSize = true;
            this.lblLocalDrivingLicenseApplicationID.Location = new System.Drawing.Point(190, 28);
            this.lblLocalDrivingLicenseApplicationID.Name = "lblLocalDrivingLicenseApplicationID";
            this.lblLocalDrivingLicenseApplicationID.Size = new System.Drawing.Size(31, 17);
            this.lblLocalDrivingLicenseApplicationID.TabIndex = 4;
            this.lblLocalDrivingLicenseApplicationID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "D.L.App ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblPassedTests);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblLicenseTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblLocalDrivingLicenseApplicationID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driving License Info ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(362, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Passed Tests :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label7.Image = global::DVLDWindowsForms.Properties.Resources.PassedTests_32;
            this.label7.Location = new System.Drawing.Point(480, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "     ";
            // 
            // lblPassedTests
            // 
            this.lblPassedTests.AutoSize = true;
            this.lblPassedTests.Location = new System.Drawing.Point(531, 59);
            this.lblPassedTests.Name = "lblPassedTests";
            this.lblPassedTests.Size = new System.Drawing.Size(31, 17);
            this.lblPassedTests.TabIndex = 10;
            this.lblPassedTests.Text = "N/A";
            this.lblPassedTests.Click += new System.EventHandler(this.lblPassedTests_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(327, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Applied For License :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Image = global::DVLDWindowsForms.Properties.Resources.License_Type_321;
            this.label4.Location = new System.Drawing.Point(480, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "    ";
            // 
            // lblLicenseTitle
            // 
            this.lblLicenseTitle.AutoSize = true;
            this.lblLicenseTitle.Location = new System.Drawing.Point(531, 28);
            this.lblLicenseTitle.Name = "lblLicenseTitle";
            this.lblLicenseTitle.Size = new System.Drawing.Size(31, 17);
            this.lblLicenseTitle.TabIndex = 7;
            this.lblLicenseTitle.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label3.Location = new System.Drawing.Point(139, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "     ";
            // 
            // ucApplicationBasicInfo1
            // 
            this.ucApplicationBasicInfo1.Location = new System.Drawing.Point(3, 103);
            this.ucApplicationBasicInfo1.Name = "ucApplicationBasicInfo1";
            this.ucApplicationBasicInfo1.Size = new System.Drawing.Size(742, 194);
            this.ucApplicationBasicInfo1.TabIndex = 7;
            // 
            // ucDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucApplicationBasicInfo1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucDrivingLicenseApplicationInfo";
            this.Size = new System.Drawing.Size(752, 293);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPassedTests;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLicenseTitle;
        private ucApplicationBasicInfo ucApplicationBasicInfo1;

    }
}
