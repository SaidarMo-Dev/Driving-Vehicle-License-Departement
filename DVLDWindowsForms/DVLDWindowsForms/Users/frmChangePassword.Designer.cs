namespace DVLDWindowsForms.Users
{
    partial class frmChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbCurrentPasword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.epValidateOfPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucUserInfo1 = new DVLDWindowsForms.Controls.ucUserInfo();
            this.ucShowPersonInfo1 = new DVLDWindowsForms.ucShowPersonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.epValidateOfPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Password :";
            // 
            // tbCurrentPasword
            // 
            this.tbCurrentPasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tbCurrentPasword.Location = new System.Drawing.Point(209, 456);
            this.tbCurrentPasword.Name = "tbCurrentPasword";
            this.tbCurrentPasword.Size = new System.Drawing.Size(175, 21);
            this.tbCurrentPasword.TabIndex = 4;
            this.tbCurrentPasword.TextChanged += new System.EventHandler(this.tbCurrentPasword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label1.Location = new System.Drawing.Point(158, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label3.Location = new System.Drawing.Point(158, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "    ";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tbNewPassword.Location = new System.Drawing.Point(209, 498);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(175, 21);
            this.tbNewPassword.TabIndex = 7;
            this.tbNewPassword.TextChanged += new System.EventHandler(this.tbNewPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "New Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label5.Location = new System.Drawing.Point(158, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "    ";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tbConfirmPassword.Location = new System.Drawing.Point(209, 540);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(175, 21);
            this.tbConfirmPassword.TabIndex = 10;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirm Password :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSave.Image = global::DVLDWindowsForms.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(735, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "    Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(632, 576);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "      Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // epValidateOfPassword
            // 
            this.epValidateOfPassword.ContainerControl = this;
            // 
            // ucUserInfo1
            // 
            this.ucUserInfo1.Location = new System.Drawing.Point(9, 345);
            this.ucUserInfo1.Name = "ucUserInfo1";
            this.ucUserInfo1.Size = new System.Drawing.Size(815, 87);
            this.ucUserInfo1.TabIndex = 3;
            this.ucUserInfo1.UserID = 0;
            this.ucUserInfo1.Load += new System.EventHandler(this.ucUserInfo1_Load);
            // 
            // ucShowPersonInfo1
            // 
            this.ucShowPersonInfo1.Location = new System.Drawing.Point(12, 24);
            this.ucShowPersonInfo1.Name = "ucShowPersonInfo1";
            //this.ucShowPersonInfo1.PersonID = 0;
            this.ucShowPersonInfo1.Size = new System.Drawing.Size(814, 315);
            this.ucShowPersonInfo1.TabIndex = 0;
            this.ucShowPersonInfo1.Load += new System.EventHandler(this.ucShowPersonInfo1_Load);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 619);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCurrentPasword);
            this.Controls.Add(this.ucUserInfo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucShowPersonInfo1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epValidateOfPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucShowPersonInfo ucShowPersonInfo1;
        private System.Windows.Forms.Label label2;
        private Controls.ucUserInfo ucUserInfo1;
        private System.Windows.Forms.TextBox tbCurrentPasword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider epValidateOfPassword;
    }
}