namespace DVLDWindowsForms
{
    partial class frManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frManagePeople));
            this.lblManagePeople = new System.Windows.Forms.Label();
            this.dgvListPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.tbfilter = new System.Windows.Forms.TextBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblManagePeople
            // 
            resources.ApplyResources(this.lblManagePeople, "lblManagePeople");
            this.lblManagePeople.ForeColor = System.Drawing.Color.Red;
            this.lblManagePeople.Name = "lblManagePeople";
            // 
            // dgvListPeople
            // 
            resources.ApplyResources(this.dgvListPeople, "dgvListPeople");
            this.dgvListPeople.AllowUserToAddRows = false;
            this.dgvListPeople.AllowUserToDeleteRows = false;
            this.dgvListPeople.AllowUserToOrderColumns = true;
            this.dgvListPeople.BackgroundColor = System.Drawing.Color.White;
            this.dgvListPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListPeople.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvListPeople.Name = "dgvListPeople";
            this.dgvListPeople.ReadOnly = true;
            this.dgvListPeople.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.callPhoneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Image = global::DVLDWindowsForms.Properties.Resources.PersonDetails_32;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // addNewToolStripMenuItem
            // 
            resources.ApplyResources(this.addNewToolStripMenuItem, "addNewToolStripMenuItem");
            this.addNewToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Add_Person_40;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            this.editToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.Delete_32_2;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // sendEmailToolStripMenuItem
            // 
            resources.ApplyResources(this.sendEmailToolStripMenuItem, "sendEmailToolStripMenuItem");
            this.sendEmailToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click_1);
            // 
            // callPhoneToolStripMenuItem
            // 
            resources.ApplyResources(this.callPhoneToolStripMenuItem, "callPhoneToolStripMenuItem");
            this.callPhoneToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.call_32;
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Click += new System.EventHandler(this.callPhoneToolStripMenuItem_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // cbFilter
            // 
            resources.ApplyResources(this.cbFilter, "cbFilter");
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            resources.GetString("cbFilter.Items"),
            resources.GetString("cbFilter.Items1"),
            resources.GetString("cbFilter.Items2"),
            resources.GetString("cbFilter.Items3"),
            resources.GetString("cbFilter.Items4"),
            resources.GetString("cbFilter.Items5"),
            resources.GetString("cbFilter.Items6"),
            resources.GetString("cbFilter.Items7"),
            resources.GetString("cbFilter.Items8"),
            resources.GetString("cbFilter.Items9"),
            resources.GetString("cbFilter.Items10")});
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblTotalRecords
            // 
            resources.ApplyResources(this.lblTotalRecords, "lblTotalRecords");
            this.lblTotalRecords.Name = "lblTotalRecords";
            // 
            // tbfilter
            // 
            resources.ApplyResources(this.tbfilter, "tbfilter");
            this.tbfilter.Name = "tbfilter";
            this.tbfilter.TextChanged += new System.EventHandler(this.tbfilter_TextChanged);
            this.tbfilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbfilter_KeyPress);
            // 
            // btnAddNewPerson
            // 
            resources.ApplyResources(this.btnAddNewPerson, "btnAddNewPerson");
            this.btnAddNewPerson.BackColor = System.Drawing.Color.Silver;
            this.btnAddNewPerson.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Add_Person_72;
            this.btnAddNewPerson.FlatAppearance.BorderSize = 0;
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.People_4001;
            this.panel1.Name = "panel1";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frManagePeople
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbfilter);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListPeople);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblManagePeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frManagePeople";
            this.Load += new System.EventHandler(this.frManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManagePeople;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvListPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.TextBox tbfilter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
    }
}