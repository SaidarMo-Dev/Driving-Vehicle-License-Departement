namespace DVLDWindowsForms
{
    partial class frmManageUsers
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
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStripUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showUSerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUSeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbUserFilters = new System.Windows.Forms.ComboBox();
            this.tbUsersFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.cbFilterUsersActive = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.contextMenuStripUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(339, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.AllowUserToAddRows = false;
            this.dgvListUsers.AllowUserToDeleteRows = false;
            this.dgvListUsers.AllowUserToOrderColumns = true;
            this.dgvListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvListUsers.ContextMenuStrip = this.contextMenuStripUsers;
            this.dgvListUsers.Location = new System.Drawing.Point(12, 279);
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.ReadOnly = true;
            this.dgvListUsers.RowHeadersWidth = 60;
            this.dgvListUsers.Size = new System.Drawing.Size(830, 219);
            this.dgvListUsers.TabIndex = 2;
            this.dgvListUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListUsers_CellContentClick);
            // 
            // contextMenuStripUsers
            // 
            this.contextMenuStripUsers.AutoSize = false;
            this.contextMenuStripUsers.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.contextMenuStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showUSerInfoToolStripMenuItem,
            this.toolStripSeparator2,
            this.addNewUserToolStripMenuItem,
            this.editUSeeToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.callPhoneToolStripMenuItem});
            this.contextMenuStripUsers.Name = "contextMenuStripUsers";
            this.contextMenuStripUsers.Size = new System.Drawing.Size(185, 298);
            // 
            // showUSerInfoToolStripMenuItem
            // 
            this.showUSerInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.showUSerInfoToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.PersonDetails_322;
            this.showUSerInfoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showUSerInfoToolStripMenuItem.Name = "showUSerInfoToolStripMenuItem";
            this.showUSerInfoToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.showUSerInfoToolStripMenuItem.Text = "Show Details";
            this.showUSerInfoToolStripMenuItem.Click += new System.EventHandler(this.showUSerInfoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Add_New_User_32;
            this.addNewUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.addNewUserToolStripMenuItem.Text = "AddNew User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // editUSeeToolStripMenuItem
            // 
            this.editUSeeToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Edit_User_32;
            this.editUSeeToolStripMenuItem.Name = "editUSeeToolStripMenuItem";
            this.editUSeeToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.editUSeeToolStripMenuItem.Text = "Edit User";
            this.editUSeeToolStripMenuItem.Click += new System.EventHandler(this.editUSeeToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Delete_User_32;
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // callPhoneToolStripMenuItem
            // 
            this.callPhoneToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.call_32;
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(184, 38);
            this.callPhoneToolStripMenuItem.Text = "Call Phone";
            this.callPhoneToolStripMenuItem.Click += new System.EventHandler(this.callPhoneToolStripMenuItem_Click);
            // 
            // cbUserFilters
            // 
            this.cbUserFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserFilters.FormattingEnabled = true;
            this.cbUserFilters.Items.AddRange(new object[] {
            "none",
            "User ID",
            "Person ID",
            "Full Name",
            "UserName",
            "IsActive"});
            this.cbUserFilters.Location = new System.Drawing.Point(12, 252);
            this.cbUserFilters.Name = "cbUserFilters";
            this.cbUserFilters.Size = new System.Drawing.Size(121, 21);
            this.cbUserFilters.TabIndex = 3;
            this.cbUserFilters.SelectedIndexChanged += new System.EventHandler(this.cbUserFilters_SelectedIndexChanged);
            // 
            // tbUsersFilter
            // 
            this.tbUsersFilter.Location = new System.Drawing.Point(148, 252);
            this.tbUsersFilter.Name = "tbUsersFilter";
            this.tbUsersFilter.Size = new System.Drawing.Size(136, 20);
            this.tbUsersFilter.TabIndex = 4;
            this.tbUsersFilter.TextChanged += new System.EventHandler(this.tbUsersFilter_TextChanged);
            this.tbUsersFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsersFilter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "# Record(s) :";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.Location = new System.Drawing.Point(118, 513);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(15, 15);
            this.lblTotalRecords.TabIndex = 6;
            this.lblTotalRecords.Text = "0";
            // 
            // cbFilterUsersActive
            // 
            this.cbFilterUsersActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterUsersActive.FormattingEnabled = true;
            this.cbFilterUsersActive.Items.AddRange(new object[] {
            "All",
            "yes",
            "no"});
            this.cbFilterUsersActive.Location = new System.Drawing.Point(148, 251);
            this.cbFilterUsersActive.Name = "cbFilterUsersActive";
            this.cbFilterUsersActive.Size = new System.Drawing.Size(91, 21);
            this.cbFilterUsersActive.TabIndex = 7;
            this.cbFilterUsersActive.SelectedIndexChanged += new System.EventHandler(this.cbFilterUsersActive_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(743, 504);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 34);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "   Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.White;
            this.btnAddNewUser.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Add_New_User_72;
            this.btnAddNewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Location = new System.Drawing.Point(776, 224);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(66, 49);
            this.btnAddNewUser.TabIndex = 8;
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDWindowsForms.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(344, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 546);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.cbFilterUsersActive);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsersFilter);
            this.Controls.Add(this.cbUserFilters);
            this.Controls.Add(this.dgvListUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmManageUsers";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.contextMenuStripUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.ComboBox cbUserFilters;
        private System.Windows.Forms.TextBox tbUsersFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.ComboBox cbFilterUsersActive;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUsers;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUSeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUSerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}