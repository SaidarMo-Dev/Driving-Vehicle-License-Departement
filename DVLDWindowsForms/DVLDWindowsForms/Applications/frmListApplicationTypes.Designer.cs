namespace DVLDWindowsForms.Applications
{
    partial class frmListApplicationTypes
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
            this.dgvListApplicationTypes = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleRec = new System.Windows.Forms.Label();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListApplicationTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListApplicationTypes
            // 
            this.dgvListApplicationTypes.AllowUserToAddRows = false;
            this.dgvListApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvListApplicationTypes.AllowUserToOrderColumns = true;
            this.dgvListApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListApplicationTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmTitle,
            this.clmFees});
            this.dgvListApplicationTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListApplicationTypes.Location = new System.Drawing.Point(12, 220);
            this.dgvListApplicationTypes.Name = "dgvListApplicationTypes";
            this.dgvListApplicationTypes.ReadOnly = true;
            this.dgvListApplicationTypes.Size = new System.Drawing.Size(783, 266);
            this.dgvListApplicationTypes.TabIndex = 1;
            this.dgvListApplicationTypes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListApplicationTypes_CellContentClick);
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 150;
            // 
            // clmTitle
            // 
            this.clmTitle.HeaderText = "Title";
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            this.clmTitle.Width = 400;
            // 
            // clmFees
            // 
            this.clmFees.HeaderText = "Fees";
            this.clmFees.Name = "clmFees";
            this.clmFees.ReadOnly = true;
            this.clmFees.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(255, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Application Types ";
            // 
            // lblTitleRec
            // 
            this.lblTitleRec.AutoSize = true;
            this.lblTitleRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleRec.Location = new System.Drawing.Point(13, 501);
            this.lblTitleRec.Name = "lblTitleRec";
            this.lblTitleRec.Size = new System.Drawing.Size(94, 15);
            this.lblTitleRec.TabIndex = 4;
            this.lblTitleRec.Text = "#  Record(s) :";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalRecords.Location = new System.Drawing.Point(122, 501);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(17, 17);
            this.lblTotalRecords.TabIndex = 5;
            this.lblTotalRecords.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editFeesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 36);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnClose.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(704, 494);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "     Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Application_Types_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(310, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 158);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // editFeesToolStripMenuItem
            // 
            this.editFeesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editFeesToolStripMenuItem.Image = global::DVLDWindowsForms.Properties.Resources.edit_321;
            this.editFeesToolStripMenuItem.Name = "editFeesToolStripMenuItem";
            this.editFeesToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.editFeesToolStripMenuItem.Text = "Edit Fees";
            this.editFeesToolStripMenuItem.Click += new System.EventHandler(this.editFeesToolStripMenuItem_Click);
            // 
            // frmListApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 538);
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.lblTitleRec);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListApplicationTypes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListApplicationTypes";
            this.Text = "frmListApplicationTypes";
            this.Load += new System.EventHandler(this.frmListApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListApplicationTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvListApplicationTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitleRec;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editFeesToolStripMenuItem;
    }
}