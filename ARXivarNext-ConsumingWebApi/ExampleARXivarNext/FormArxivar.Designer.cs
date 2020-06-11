﻿namespace ExampleARXivarNext
{
    partial class FormArxivar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnLogin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._txtClientSecret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtClientId = new System.Windows.Forms.TextBox();
            this._txtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this._txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ComboAoo = new System.Windows.Forms.ComboBox();
            this.BtnListDocumentType = new System.Windows.Forms.Button();
            this.BtnListAoo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnPredefinedProfileDetails = new System.Windows.Forms.Button();
            this.ComboPredefinedProfile = new System.Windows.Forms.ComboBox();
            this.BtnPredefinedProfileList = new System.Windows.Forms.Button();
            this.BtnMaskDetails = new System.Windows.Forms.Button();
            this.ComboMask = new System.Windows.Forms.ComboBox();
            this.BtnMaskList = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ComboAddressBookItems = new System.Windows.Forms.ComboBox();
            this.ComboAddressBookCategory = new System.Windows.Forms.ComboBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button16 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ComboDocNumbers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ComboTasks = new System.Windows.Forms.ComboBox();
            this.ComboWf = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.button18 = new System.Windows.Forms.Button();
            this.ComboSignCert = new System.Windows.Forms.ComboBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this._txtLogonToken = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this._txtLog = new System.Windows.Forms.TextBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this._btnLoginWindows = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._btnLoginWindows);
            this.groupBox1.Controls.Add(this._btnLogin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._txtClientSecret);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._txtClientId);
            this.groupBox1.Controls.Add(this._txtUrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtPassword);
            this.groupBox1.Controls.Add(this._txtUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connessione Web Api";
            // 
            // _btnLogin
            // 
            this._btnLogin.Location = new System.Drawing.Point(572, 60);
            this._btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._btnLogin.Name = "_btnLogin";
            this._btnLogin.Size = new System.Drawing.Size(112, 25);
            this._btnLogin.TabIndex = 10;
            this._btnLogin.Text = "Login";
            this._btnLogin.UseVisualStyleBackColor = true;
            this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Client Secret";
            // 
            // _txtClientSecret
            // 
            this._txtClientSecret.Location = new System.Drawing.Point(380, 63);
            this._txtClientSecret.Name = "_txtClientSecret";
            this._txtClientSecret.Size = new System.Drawing.Size(174, 20);
            this._txtClientSecret.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Client ID";
            // 
            // _txtClientId
            // 
            this._txtClientId.Location = new System.Drawing.Point(75, 65);
            this._txtClientId.Name = "_txtClientId";
            this._txtClientId.Size = new System.Drawing.Size(177, 20);
            this._txtClientId.TabIndex = 6;
            // 
            // _txtUrl
            // 
            this._txtUrl.Location = new System.Drawing.Point(75, 18);
            this._txtUrl.Name = "_txtUrl";
            this._txtUrl.Size = new System.Drawing.Size(480, 20);
            this._txtUrl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // _txtPassword
            // 
            this._txtPassword.Location = new System.Drawing.Point(380, 40);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.PasswordChar = '*';
            this._txtPassword.Size = new System.Drawing.Size(174, 20);
            this._txtPassword.TabIndex = 4;
            // 
            // _txtUsername
            // 
            this._txtUsername.Location = new System.Drawing.Point(75, 41);
            this._txtUsername.Name = "_txtUsername";
            this._txtUsername.Size = new System.Drawing.Size(177, 20);
            this._txtUsername.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url Web Api";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(10, 108);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(278, 397);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ComboAoo);
            this.tabPage1.Controls.Add(this.BtnListDocumentType);
            this.tabPage1.Controls.Add(this.BtnListAoo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(270, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anagrafiche";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ComboAoo
            // 
            this.ComboAoo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAoo.FormattingEnabled = true;
            this.ComboAoo.Location = new System.Drawing.Point(4, 29);
            this.ComboAoo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboAoo.Name = "ComboAoo";
            this.ComboAoo.Size = new System.Drawing.Size(157, 21);
            this.ComboAoo.TabIndex = 2;
            // 
            // BtnListDocumentType
            // 
            this.BtnListDocumentType.Location = new System.Drawing.Point(4, 73);
            this.BtnListDocumentType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnListDocumentType.Name = "BtnListDocumentType";
            this.BtnListDocumentType.Size = new System.Drawing.Size(156, 19);
            this.BtnListDocumentType.TabIndex = 1;
            this.BtnListDocumentType.Text = "DocumentType List";
            this.BtnListDocumentType.UseVisualStyleBackColor = true;
            this.BtnListDocumentType.Click += new System.EventHandler(this.BtnListDocumentType_Click);
            // 
            // BtnListAoo
            // 
            this.BtnListAoo.Location = new System.Drawing.Point(4, 5);
            this.BtnListAoo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnListAoo.Name = "BtnListAoo";
            this.BtnListAoo.Size = new System.Drawing.Size(156, 19);
            this.BtnListAoo.TabIndex = 0;
            this.BtnListAoo.Text = "Aoo List";
            this.BtnListAoo.UseVisualStyleBackColor = true;
            this.BtnListAoo.Click += new System.EventHandler(this.BtnListAoo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnPredefinedProfileDetails);
            this.tabPage2.Controls.Add(this.ComboPredefinedProfile);
            this.tabPage2.Controls.Add(this.BtnPredefinedProfileList);
            this.tabPage2.Controls.Add(this.BtnMaskDetails);
            this.tabPage2.Controls.Add(this.ComboMask);
            this.tabPage2.Controls.Add(this.BtnMaskList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(270, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archiviazione";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnPredefinedProfileDetails
            // 
            this.BtnPredefinedProfileDetails.Location = new System.Drawing.Point(8, 144);
            this.BtnPredefinedProfileDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPredefinedProfileDetails.Name = "BtnPredefinedProfileDetails";
            this.BtnPredefinedProfileDetails.Size = new System.Drawing.Size(156, 19);
            this.BtnPredefinedProfileDetails.TabIndex = 8;
            this.BtnPredefinedProfileDetails.Text = "PredefinedProfile Details";
            this.BtnPredefinedProfileDetails.UseVisualStyleBackColor = true;
            this.BtnPredefinedProfileDetails.Click += new System.EventHandler(this.BtnPredefinedProfileDetails_Click);
            // 
            // ComboPredefinedProfile
            // 
            this.ComboPredefinedProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPredefinedProfile.FormattingEnabled = true;
            this.ComboPredefinedProfile.Location = new System.Drawing.Point(6, 119);
            this.ComboPredefinedProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboPredefinedProfile.Name = "ComboPredefinedProfile";
            this.ComboPredefinedProfile.Size = new System.Drawing.Size(157, 21);
            this.ComboPredefinedProfile.TabIndex = 7;
            // 
            // BtnPredefinedProfileList
            // 
            this.BtnPredefinedProfileList.Location = new System.Drawing.Point(6, 95);
            this.BtnPredefinedProfileList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPredefinedProfileList.Name = "BtnPredefinedProfileList";
            this.BtnPredefinedProfileList.Size = new System.Drawing.Size(156, 19);
            this.BtnPredefinedProfileList.TabIndex = 6;
            this.BtnPredefinedProfileList.Text = "PredefinedProfile List";
            this.BtnPredefinedProfileList.UseVisualStyleBackColor = true;
            this.BtnPredefinedProfileList.Click += new System.EventHandler(this.BtnPredefinedProfileList_Click);
            // 
            // BtnMaskDetails
            // 
            this.BtnMaskDetails.Location = new System.Drawing.Point(6, 54);
            this.BtnMaskDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMaskDetails.Name = "BtnMaskDetails";
            this.BtnMaskDetails.Size = new System.Drawing.Size(156, 19);
            this.BtnMaskDetails.TabIndex = 5;
            this.BtnMaskDetails.Text = "Mask Details";
            this.BtnMaskDetails.UseVisualStyleBackColor = true;
            this.BtnMaskDetails.Click += new System.EventHandler(this.BtnMaskDetails_Click);
            // 
            // ComboMask
            // 
            this.ComboMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMask.FormattingEnabled = true;
            this.ComboMask.Location = new System.Drawing.Point(4, 29);
            this.ComboMask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboMask.Name = "ComboMask";
            this.ComboMask.Size = new System.Drawing.Size(157, 21);
            this.ComboMask.TabIndex = 4;
            // 
            // BtnMaskList
            // 
            this.BtnMaskList.Location = new System.Drawing.Point(4, 5);
            this.BtnMaskList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMaskList.Name = "BtnMaskList";
            this.BtnMaskList.Size = new System.Drawing.Size(156, 19);
            this.BtnMaskList.TabIndex = 3;
            this.BtnMaskList.Text = "Mask List";
            this.BtnMaskList.UseVisualStyleBackColor = true;
            this.BtnMaskList.Click += new System.EventHandler(this.BtnMaskList_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ComboAddressBookItems);
            this.tabPage3.Controls.Add(this.ComboAddressBookCategory);
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(270, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Address Book";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ComboAddressBookItems
            // 
            this.ComboAddressBookItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAddressBookItems.FormattingEnabled = true;
            this.ComboAddressBookItems.Location = new System.Drawing.Point(6, 88);
            this.ComboAddressBookItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboAddressBookItems.Name = "ComboAddressBookItems";
            this.ComboAddressBookItems.Size = new System.Drawing.Size(167, 21);
            this.ComboAddressBookItems.TabIndex = 7;
            // 
            // ComboAddressBookCategory
            // 
            this.ComboAddressBookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAddressBookCategory.FormattingEnabled = true;
            this.ComboAddressBookCategory.Location = new System.Drawing.Point(6, 34);
            this.ComboAddressBookCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboAddressBookCategory.Name = "ComboAddressBookCategory";
            this.ComboAddressBookCategory.Size = new System.Drawing.Size(167, 21);
            this.ComboAddressBookCategory.TabIndex = 6;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 129);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(166, 23);
            this.button12.TabIndex = 5;
            this.button12.Text = "EditAddressBook";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 59);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(166, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "GetAddressBook";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(166, 23);
            this.button10.TabIndex = 3;
            this.button10.Text = "GetAddressBookCategory";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button16);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.ComboDocNumbers);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(270, 371);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ricerca";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(128, 6);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(116, 23);
            this.button16.TabIndex = 12;
            this.button16.Text = "Search senza filtri";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 154);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Crea vista";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Search OR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ComboDocNumbers
            // 
            this.ComboDocNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDocNumbers.FormattingEnabled = true;
            this.ComboDocNumbers.Location = new System.Drawing.Point(6, 34);
            this.ComboDocNumbers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboDocNumbers.Name = "ComboDocNumbers";
            this.ComboDocNumbers.Size = new System.Drawing.Size(167, 21);
            this.ComboDocNumbers.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Download Document";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button14);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Size = new System.Drawing.Size(270, 371);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Import";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(6, 224);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(166, 23);
            this.button14.TabIndex = 10;
            this.button14.Text = "Import File 2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(166, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Update Profile";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(166, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Import File";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ComboTasks);
            this.tabPage6.Controls.Add(this.ComboWf);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.button8);
            this.tabPage6.Controls.Add(this.button9);
            this.tabPage6.Controls.Add(this.button13);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Size = new System.Drawing.Size(270, 371);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Workflow";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ComboTasks
            // 
            this.ComboTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTasks.FormattingEnabled = true;
            this.ComboTasks.Location = new System.Drawing.Point(6, 119);
            this.ComboTasks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboTasks.Name = "ComboTasks";
            this.ComboTasks.Size = new System.Drawing.Size(191, 21);
            this.ComboTasks.TabIndex = 11;
            // 
            // ComboWf
            // 
            this.ComboWf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboWf.FormattingEnabled = true;
            this.ComboWf.Location = new System.Drawing.Point(6, 34);
            this.ComboWf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboWf.Name = "ComboWf";
            this.ComboWf.Size = new System.Drawing.Size(191, 21);
            this.ComboWf.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 144);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Get Esiti";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 90);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Get Tasks";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 61);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(190, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Avvia Wf";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 6);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(190, 23);
            this.button13.TabIndex = 4;
            this.button13.Text = "Get Wf";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.button18);
            this.tabPage7.Controls.Add(this.ComboSignCert);
            this.tabPage7.Controls.Add(this.button17);
            this.tabPage7.Controls.Add(this.button15);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage7.Size = new System.Drawing.Size(270, 371);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Firma";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(5, 103);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(205, 23);
            this.button18.TabIndex = 11;
            this.button18.Text = "Esegui firma";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // ComboSignCert
            // 
            this.ComboSignCert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSignCert.FormattingEnabled = true;
            this.ComboSignCert.Location = new System.Drawing.Point(5, 78);
            this.ComboSignCert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboSignCert.Name = "ComboSignCert";
            this.ComboSignCert.Size = new System.Drawing.Size(206, 21);
            this.ComboSignCert.TabIndex = 10;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(5, 50);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(205, 23);
            this.button17.TabIndex = 6;
            this.button17.Text = "Recupera elenco certificati firma utente";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(6, 6);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(205, 23);
            this.button15.TabIndex = 5;
            this.button15.Text = "Verifica firma by docnumber";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this._txtLogonToken);
            this.tabPage8.Controls.Add(this.button20);
            this.tabPage8.Controls.Add(this.button19);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage8.Size = new System.Drawing.Size(270, 371);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Logon ticket";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // _txtLogonToken
            // 
            this._txtLogonToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtLogonToken.Location = new System.Drawing.Point(6, 64);
            this._txtLogonToken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtLogonToken.Name = "_txtLogonToken";
            this._txtLogonToken.ReadOnly = true;
            this._txtLogonToken.Size = new System.Drawing.Size(263, 20);
            this._txtLogonToken.TabIndex = 8;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(6, 35);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(205, 23);
            this.button20.TabIndex = 7;
            this.button20.Text = "Logon token - 10 minuti";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(5, 6);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(205, 23);
            this.button19.TabIndex = 6;
            this.button19.Text = "Logon token - One shot";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.splitter1);
            this.groupBox2.Controls.Add(this._txtLog);
            this.groupBox2.Controls.Add(this.Table);
            this.groupBox2.Location = new System.Drawing.Point(290, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(555, 400);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(2, 292);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(551, 2);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // _txtLog
            // 
            this._txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._txtLog.Location = new System.Drawing.Point(2, 294);
            this._txtLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._txtLog.Multiline = true;
            this._txtLog.Name = "_txtLog";
            this._txtLog.ReadOnly = true;
            this._txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._txtLog.Size = new System.Drawing.Size(551, 104);
            this._txtLog.TabIndex = 5;
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(2, 15);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.Size = new System.Drawing.Size(551, 383);
            this.Table.TabIndex = 1;
            // 
            // _btnLoginWindows
            // 
            this._btnLoginWindows.Location = new System.Drawing.Point(688, 60);
            this._btnLoginWindows.Margin = new System.Windows.Forms.Padding(2);
            this._btnLoginWindows.Name = "_btnLoginWindows";
            this._btnLoginWindows.Size = new System.Drawing.Size(112, 25);
            this._btnLoginWindows.TabIndex = 11;
            this._btnLoginWindows.Text = "Login Windows";
            this._btnLoginWindows.UseVisualStyleBackColor = true;
            this._btnLoginWindows.Click += new System.EventHandler(this._btnLoginWindows_Click);
            // 
            // FormArxivar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(604, 332);
            this.Name = "FormArxivar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormARXivar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtPassword;
        private System.Windows.Forms.TextBox _txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _txtClientSecret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtClientId;
        private System.Windows.Forms.Button _btnLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnListAoo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox _txtLog;
        private System.Windows.Forms.Button BtnListDocumentType;
        private System.Windows.Forms.ComboBox ComboAoo;
        private System.Windows.Forms.ComboBox ComboMask;
        private System.Windows.Forms.Button BtnMaskList;
        private System.Windows.Forms.Button BtnMaskDetails;
        private System.Windows.Forms.Button BtnPredefinedProfileDetails;
        private System.Windows.Forms.ComboBox ComboPredefinedProfile;
        private System.Windows.Forms.Button BtnPredefinedProfileList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox ComboAddressBookCategory;
        private System.Windows.Forms.ComboBox ComboAddressBookItems;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ComboDocNumbers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox ComboWf;
        private System.Windows.Forms.ComboBox ComboTasks;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ComboBox ComboSignCert;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox _txtLogonToken;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button _btnLoginWindows;
    }
}

