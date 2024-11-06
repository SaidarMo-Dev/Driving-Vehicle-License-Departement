

using DVLDWindowsForms;

namespace DVLDWindowsForms
{
    partial class frmShowPersonDetails
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
            this.ucShowPersonInfo1 = new DVLDWindowsForms.ucShowPersonInfo();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClosee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucShowPersonInfo1
            // 
            this.ucShowPersonInfo1.Location = new System.Drawing.Point(12, 75);
            this.ucShowPersonInfo1.Name = "ucShowPersonInfo1";
          //  this.ucShowPersonInfo1.PersonID = 0;
            this.ucShowPersonInfo1.Size = new System.Drawing.Size(814, 315);
            this.ucShowPersonInfo1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(328, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Person Details";
            // 
            // btnClosee
            // 
            this.btnClosee.BackColor = System.Drawing.Color.White;
            this.btnClosee.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClosee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnClosee.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClosee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosee.Location = new System.Drawing.Point(716, 398);
            this.btnClosee.Name = "btnClosee";
            this.btnClosee.Size = new System.Drawing.Size(110, 35);
            this.btnClosee.TabIndex = 2;
            this.btnClosee.Text = "   Close";
            this.btnClosee.UseVisualStyleBackColor = false;
            this.btnClosee.Click += new System.EventHandler(this.btnClosee_Click);
            // 
            // frmShowPersonDetails
            // 
            this.ClientSize = new System.Drawing.Size(835, 447);
            this.Controls.Add(this.btnClosee);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ucShowPersonInfo1);
            this.Name = "frmShowPersonDetails";
            this.Text = "Show Details";
            this.Load += new System.EventHandler(this.frmShowPersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label lblTitlePersonDetails;
        private System.Windows.Forms.Button btnClose;
        private ucShowPersonInfo ucShowPersonInfo1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClosee;

    }
}