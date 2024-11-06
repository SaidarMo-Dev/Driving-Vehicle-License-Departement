
using DVLDWindowsForms;

namespace DVLDWindowsForms
{
    partial class frmAddEditPerson
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitlePersonID = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblTitleName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNationalNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linklblRemoveImage = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnSaveAddEdit = new System.Windows.Forms.Button();
            this.btnCloseAddEdit = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(306, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add New Person";
            // 
            // lblTitlePersonID
            // 
            this.lblTitlePersonID.AutoSize = true;
            this.lblTitlePersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePersonID.Location = new System.Drawing.Point(12, 63);
            this.lblTitlePersonID.Name = "lblTitlePersonID";
            this.lblTitlePersonID.Size = new System.Drawing.Size(93, 18);
            this.lblTitlePersonID.TabIndex = 3;
            this.lblTitlePersonID.Text = "Person ID :";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPersonID.Location = new System.Drawing.Point(168, 63);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(40, 18);
            this.lblPersonID.TabIndex = 5;
            this.lblPersonID.Text = "  N/A";
            // 
            // lblTitleName
            // 
            this.lblTitleName.AutoSize = true;
            this.lblTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblTitleName.Location = new System.Drawing.Point(9, 45);
            this.lblTitleName.Name = "lblTitleName";
            this.lblTitleName.Size = new System.Drawing.Size(59, 17);
            this.lblTitleName.TabIndex = 0;
            this.lblTitleName.Text = "Name :";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(167, 43);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(176, 22);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "National No :";
            // 
            // tbNationalNo
            // 
            this.tbNationalNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tbNationalNo.Location = new System.Drawing.Point(161, 73);
            this.tbNationalNo.Name = "tbNationalNo";
            this.tbNationalNo.Size = new System.Drawing.Size(176, 21);
            this.tbNationalNo.TabIndex = 7;
            this.tbNationalNo.TextChanged += new System.EventHandler(this.tbNationalNo_TextChanged);
            this.tbNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.tbNationalNo_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email :";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.tbEmail.Location = new System.Drawing.Point(161, 142);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(176, 21);
            this.tbEmail.TabIndex = 10;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbSecondName
            // 
            this.tbSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecondName.Location = new System.Drawing.Point(349, 45);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(176, 22);
            this.tbSecondName.TabIndex = 12;
            this.tbSecondName.TextChanged += new System.EventHandler(this.tbSecondName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbLastName.Location = new System.Drawing.Point(713, 46);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(176, 23);
            this.tbLastName.TabIndex = 13;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbThirdName.Location = new System.Drawing.Point(531, 45);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(176, 23);
            this.tbThirdName.TabIndex = 14;
            this.tbThirdName.TextChanged += new System.EventHandler(this.tbThirdName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(200, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "First";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(597, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Third";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(412, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Second";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(760, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Last";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Gendor :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linklblRemoveImage);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.btnSaveAddEdit);
            this.groupBox1.Controls.Add(this.btnCloseAddEdit);
            this.groupBox1.Controls.Add(this.pbPersonImage);
            this.groupBox1.Controls.Add(this.cbCountries);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbThirdName);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbSecondName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNationalNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.lblTitleName);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 338);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linklblRemoveImage
            // 
            this.linklblRemoveImage.AutoSize = true;
            this.linklblRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblRemoveImage.Location = new System.Drawing.Point(760, 300);
            this.linklblRemoveImage.Name = "linklblRemoveImage";
            this.linklblRemoveImage.Size = new System.Drawing.Size(101, 16);
            this.linklblRemoveImage.TabIndex = 42;
            this.linklblRemoveImage.TabStop = true;
            this.linklblRemoveImage.Text = "Remove Image";
            this.linklblRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblRemoveImage_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(769, 262);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 16);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Set Image";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSaveAddEdit
            // 
            this.btnSaveAddEdit.BackColor = System.Drawing.Color.White;
            this.btnSaveAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSaveAddEdit.Image = global::DVLDWindowsForms.Properties.Resources.Save_32;
            this.btnSaveAddEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAddEdit.Location = new System.Drawing.Point(593, 290);
            this.btnSaveAddEdit.Name = "btnSaveAddEdit";
            this.btnSaveAddEdit.Size = new System.Drawing.Size(117, 35);
            this.btnSaveAddEdit.TabIndex = 40;
            this.btnSaveAddEdit.Text = "  Save";
            this.btnSaveAddEdit.UseVisualStyleBackColor = false;
            this.btnSaveAddEdit.Click += new System.EventHandler(this.btnSaveAddEdit_Click);
            // 
            // btnCloseAddEdit
            // 
            this.btnCloseAddEdit.BackColor = System.Drawing.Color.White;
            this.btnCloseAddEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCloseAddEdit.Image = global::DVLDWindowsForms.Properties.Resources.Close_32;
            this.btnCloseAddEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseAddEdit.Location = new System.Drawing.Point(470, 290);
            this.btnCloseAddEdit.Name = "btnCloseAddEdit";
            this.btnCloseAddEdit.Size = new System.Drawing.Size(117, 35);
            this.btnCloseAddEdit.TabIndex = 39;
            this.btnCloseAddEdit.Text = "  Close";
            this.btnCloseAddEdit.UseVisualStyleBackColor = false;
            this.btnCloseAddEdit.Click += new System.EventHandler(this.btnCloseAddEdit_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.ErrorImage = null;
            this.pbPersonImage.Image = global::DVLDWindowsForms.Properties.Resources.Male_512;
            this.pbPersonImage.ImageLocation = "";
            this.pbPersonImage.Location = new System.Drawing.Point(717, 78);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(176, 177);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 38;
            this.pbPersonImage.TabStop = false;
            this.pbPersonImage.Click += new System.EventHandler(this.pbPerosnImage_Click);
            // 
            // cbCountries
            // 
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(531, 148);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(176, 23);
            this.cbCountries.TabIndex = 37;
            this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountries_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Image = global::DVLDWindowsForms.Properties.Resources.Country_32;
            this.label20.Location = new System.Drawing.Point(473, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 25);
            this.label20.TabIndex = 36;
            this.label20.Text = "     ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(365, 143);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 16);
            this.label21.TabIndex = 34;
            this.label21.Text = "Country :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.75F);
            this.label18.Image = global::DVLDWindowsForms.Properties.Resources.Phone_32;
            this.label18.Location = new System.Drawing.Point(473, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 29);
            this.label18.TabIndex = 33;
            this.label18.Text = "     ";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(531, 110);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(176, 22);
            this.tbPhone.TabIndex = 32;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(365, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 16);
            this.label19.TabIndex = 31;
            this.label19.Text = "Phone :";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.dtpDateOfBirth.Location = new System.Drawing.Point(531, 78);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(176, 21);
            this.dtpDateOfBirth.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Image = global::DVLDWindowsForms.Properties.Resources.Calendar_32;
            this.label16.Location = new System.Drawing.Point(474, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 25);
            this.label16.TabIndex = 29;
            this.label16.Text = "     ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(365, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "Date Of Birth :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::DVLDWindowsForms.Properties.Resources.Address_321;
            this.label14.Location = new System.Drawing.Point(114, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 29);
            this.label14.TabIndex = 26;
            this.label14.Text = "     ";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbAddress.Location = new System.Drawing.Point(162, 179);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(545, 99);
            this.tbAddress.TabIndex = 25;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 185);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "Address :";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(281, 111);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 23;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::DVLDWindowsForms.Properties.Resources.Woman_32;
            this.label13.Location = new System.Drawing.Point(230, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "     ";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(164, 111);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 21;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = global::DVLDWindowsForms.Properties.Resources.Man_32;
            this.label12.Location = new System.Drawing.Point(113, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "     ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::DVLDWindowsForms.Properties.Resources.Email_32;
            this.label5.Location = new System.Drawing.Point(112, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label3.Location = new System.Drawing.Point(113, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::DVLDWindowsForms.Properties.Resources.Person_32;
            this.label1.Location = new System.Drawing.Point(113, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::DVLDWindowsForms.Properties.Resources.Number_32;
            this.label2.Location = new System.Drawing.Point(122, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "     ";
            // 
            // epValidation
            // 
            this.epValidation.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmAddEditPerson
            // 
            this.AcceptButton = this.btnSaveAddEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseAddEdit;
            this.ClientSize = new System.Drawing.Size(926, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitlePersonID);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditPerson";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddEditFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitlePersonID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNationalNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSaveAddEdit;
        private System.Windows.Forms.Button btnCloseAddEdit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider epValidation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel linklblRemoveImage;
    }
}