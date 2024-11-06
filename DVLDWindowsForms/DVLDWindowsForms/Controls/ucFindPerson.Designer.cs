namespace DVLDWindowsForms
{
    partial class ucFindPerson
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
            this.gbAddPerson = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucShowPersonInfo1 = new DVLDWindowsForms.ucShowPersonInfo();
            this.gbAddPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddPerson
            // 
            this.gbAddPerson.Controls.Add(this.btnAddNewPerson);
            this.gbAddPerson.Controls.Add(this.btnSearchPerson);
            this.gbAddPerson.Controls.Add(this.cbFilters);
            this.gbAddPerson.Controls.Add(this.tbValue);
            this.gbAddPerson.Controls.Add(this.label1);
            this.gbAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.gbAddPerson.Location = new System.Drawing.Point(7, 7);
            this.gbAddPerson.Name = "gbAddPerson";
            this.gbAddPerson.Size = new System.Drawing.Size(801, 71);
            this.gbAddPerson.TabIndex = 1;
            this.gbAddPerson.TabStop = false;
            this.gbAddPerson.Text = "Filter ";
            this.gbAddPerson.Enter += new System.EventHandler(this.gbFIlter_Enter);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackColor = System.Drawing.Color.White;
            this.btnAddNewPerson.BackgroundImage = global::DVLDWindowsForms.Properties.Resources.Add_Person_40;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPerson.Location = new System.Drawing.Point(484, 14);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(46, 41);
            this.btnAddNewPerson.TabIndex = 4;
            this.btnAddNewPerson.UseVisualStyleBackColor = false;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.BackColor = System.Drawing.Color.White;
            this.btnSearchPerson.Image = global::DVLDWindowsForms.Properties.Resources.SearchPerson;
            this.btnSearchPerson.Location = new System.Drawing.Point(432, 14);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(46, 41);
            this.btnSearchPerson.TabIndex = 3;
            this.btnSearchPerson.UseVisualStyleBackColor = false;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // cbFilters
            // 
            this.cbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "National No",
            "Person ID"});
            this.cbFilters.Location = new System.Drawing.Point(82, 20);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(157, 23);
            this.cbFilters.TabIndex = 1;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbValue.Location = new System.Drawing.Point(245, 20);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(178, 23);
            this.tbValue.TabIndex = 2;
            this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
            this.tbValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbValue_KeyDown);
            this.tbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By :";
            // 
            // ucShowPersonInfo1
            // 
            this.ucShowPersonInfo1.Location = new System.Drawing.Point(7, 84);
            this.ucShowPersonInfo1.Name = "ucShowPersonInfo1";
          //  this.ucShowPersonInfo1.personID = 0;
            this.ucShowPersonInfo1.Size = new System.Drawing.Size(814, 315);
            this.ucShowPersonInfo1.TabIndex = 0;
            this.ucShowPersonInfo1.Load += new System.EventHandler(this.ucShowPersonInfo1_Load);
            // 
            // ucFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAddPerson);
            this.Controls.Add(this.ucShowPersonInfo1);
            this.Name = "ucFindPerson";
            this.Size = new System.Drawing.Size(831, 416);
            this.Load += new System.EventHandler(this.ucFindPerson_Load);
            this.gbAddPerson.ResumeLayout(false);
            this.gbAddPerson.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ucShowPersonInfo ucShowPersonInfo1;
        private System.Windows.Forms.GroupBox gbAddPerson;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label1;
    }
}
