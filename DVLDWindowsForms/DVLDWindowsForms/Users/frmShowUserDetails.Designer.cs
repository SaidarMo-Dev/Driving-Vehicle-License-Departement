namespace DVLDWindowsForms.Users
{
    partial class frmShowUserDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.ucUserInfo1 = new DVLDWindowsForms.Controls.ucUserInfo();
            this.ucShowPersonInfo1 = new DVLDWindowsForms.ucShowPersonInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Details";
            // 
            // ucUserInfo1
            // 
            this.ucUserInfo1.Location = new System.Drawing.Point(2, 379);
            this.ucUserInfo1.Name = "ucUserInfo1";
            this.ucUserInfo1.Size = new System.Drawing.Size(815, 87);
            this.ucUserInfo1.TabIndex = 2;
            this.ucUserInfo1.UserID = 0;
            // 
            // ucShowPersonInfo1
            // 
            this.ucShowPersonInfo1.Location = new System.Drawing.Point(3, 56);
            this.ucShowPersonInfo1.Name = "ucShowPersonInfo1";
         //   this.ucShowPersonInfo1.PersonID = 0;
            this.ucShowPersonInfo1.Size = new System.Drawing.Size(814, 315);
            this.ucShowPersonInfo1.TabIndex = 0;
            // 
            // frmShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 472);
            this.Controls.Add(this.ucUserInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucShowPersonInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowUserDetails";
            this.Text = "frmShowUserDetails";
            this.Load += new System.EventHandler(this.frmShowUserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucShowPersonInfo ucShowPersonInfo1;
        private System.Windows.Forms.Label label1;
        private Controls.ucUserInfo ucUserInfo1;
    }
}