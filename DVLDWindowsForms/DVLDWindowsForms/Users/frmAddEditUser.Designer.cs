namespace DVLDWindowsForms
{
    partial class frmAddEditUser
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
            this.tabCUserInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucFindPerson1 = new DVLDWindowsForms.ucFindPerson();
            this.btnNext = new System.Windows.Forms.Button();
            this.tabLoginInfoPage = new System.Windows.Forms.TabPage();
            this.ckbIsActive = new System.Windows.Forms.CheckBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabCUserInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabLoginInfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCUserInfo
            // 
            this.tabCUserInfo.Controls.Add(this.tabPage1);
            this.tabCUserInfo.Controls.Add(this.tabLoginInfoPage);
            this.tabCUserInfo.Location = new System.Drawing.Point(12, 77);
            this.tabCUserInfo.Name = "tabCUserInfo";
            this.tabCUserInfo.SelectedIndex = 0;
            this.tabCUserInfo.Size = new System.Drawing.Size(870, 502);
            this.tabCUserInfo.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.ucFindPerson1);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal info";
            // 
            // ucFindPerson1
            // 
            this.ucFindPerson1.Location = new System.Drawing.Point(10, 6);
            this.ucFindPerson1.Name = "ucFindPerson1";
          //  this.ucFindPerson1.PersonID = 0;
            this.ucFindPerson1.Size = new System.Drawing.Size(831, 416);
            this.ucFindPerson1.TabIndex = 2;
            this.ucFindPerson1.UserID = 0;
            this.ucFindPerson1.OnPersonSelected += new System.Action<int>(this.ucFindPerson1_OnPersonSelected_1);
            this.ucFindPerson1.Load += new System.EventHandler(this.ucFindPerson1_Load_1);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNext.Image = global::DVLDWindowsForms.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(730, 427);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 43);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tabLoginInfoPage
            // 
            this.tabLoginInfoPage.BackColor = System.Drawing.SystemColors.Control;
            this.tabLoginInfoPage.Controls.Add(this.ckbIsActive);
            this.tabLoginInfoPage.Controls.Add(this.tbConfirmPassword);
            this.tabLoginInfoPage.Controls.Add(this.label10);
            this.tabLoginInfoPage.Controls.Add(this.tbPassword);
            this.tabLoginInfoPage.Controls.Add(this.label8);
            this.tabLoginInfoPage.Controls.Add(this.tbUserName);
            this.tabLoginInfoPage.Controls.Add(this.label7);
            this.tabLoginInfoPage.Controls.Add(this.lblUserID);
            this.tabLoginInfoPage.Controls.Add(this.label2);
            this.tabLoginInfoPage.Controls.Add(this.label9);
            this.tabLoginInfoPage.Controls.Add(this.label5);
            this.tabLoginInfoPage.Controls.Add(this.label6);
            this.tabLoginInfoPage.Controls.Add(this.label3);
            this.tabLoginInfoPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLoginInfoPage.Location = new System.Drawing.Point(4, 22);
            this.tabLoginInfoPage.Name = "tabLoginInfoPage";
            this.tabLoginInfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginInfoPage.Size = new System.Drawing.Size(862, 476);
            this.tabLoginInfoPage.TabIndex = 1;
            this.tabLoginInfoPage.Text = "Login Info";
            this.tabLoginInfoPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ckbIsActive
            // 
            this.ckbIsActive.AutoSize = true;
            this.ckbIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIsActive.Location = new System.Drawing.Point(213, 277);
            this.ckbIsActive.Name = "ckbIsActive";
            this.ckbIsActive.Size = new System.Drawing.Size(77, 20);
            this.ckbIsActive.TabIndex = 12;
            this.ckbIsActive.Text = "Is Active";
            this.ckbIsActive.UseVisualStyleBackColor = true;
            this.ckbIsActive.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.Location = new System.Drawing.Point(213, 230);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(170, 22);
            this.tbConfirmPassword.TabIndex = 11;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Confirm Password :";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(215, 178);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(168, 22);
            this.tbPassword.TabIndex = 8;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Password :";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(215, 131);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(168, 22);
            this.tbUserName.TabIndex = 5;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "UserName :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(211, 88);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(42, 24);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "User ID :";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label9.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label9.Location = new System.Drawing.Point(154, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "     ";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label5.Image = global::DVLDWindowsForms.Properties.Resources.Number_321;
            this.label5.Location = new System.Drawing.Point(156, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "     ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label6.Image = global::DVLDWindowsForms.Properties.Resources.Person_32;
            this.label6.Location = new System.Drawing.Point(156, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "     ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label3.Location = new System.Drawing.Point(156, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "     ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(334, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New User";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Save_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClose.Location = new System.Drawing.Point(619, 586);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "  Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnSave.Image = global::DVLDWindowsForms.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSave.Location = new System.Drawing.Point(749, 586);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "  Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epConfirmPassword
            // 
            this.epConfirmPassword.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 638);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabCUserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.tabCUserInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabLoginInfoPage.ResumeLayout(false);
            this.tabLoginInfoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCUserInfo;
        private System.Windows.Forms.TabPage tabLoginInfoPage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbIsActive;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNext;
        private ucFindPerson ucFindPerson1;
        private System.Windows.Forms.ErrorProvider epConfirmPassword;

    }
}