namespace FastPie
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPgContact = new System.Windows.Forms.TabPage();
            this.cmbBXState = new System.Windows.Forms.ComboBox();
            this.txBxPhone = new System.Windows.Forms.TextBox();
            this.txBxZip = new System.Windows.Forms.TextBox();
            this.txBxCity = new System.Windows.Forms.TextBox();
            this.txBxStreet = new System.Windows.Forms.TextBox();
            this.txBxName = new System.Windows.Forms.TextBox();
            this.btnContactSubmit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPgSize = new System.Windows.Forms.TabPage();
            this.grpBxSize = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radBtnSizeXLarge = new System.Windows.Forms.RadioButton();
            this.radBtnSizeLarge = new System.Windows.Forms.RadioButton();
            this.radBtnSizeMedium = new System.Windows.Forms.RadioButton();
            this.radBtnSizeSmall = new System.Windows.Forms.RadioButton();
            this.radBtnSizeXSmall = new System.Windows.Forms.RadioButton();
            this.tabPgCrust = new System.Windows.Forms.TabPage();
            this.grpBxCrust = new System.Windows.Forms.GroupBox();
            this.radBtnCrustGluten = new System.Windows.Forms.RadioButton();
            this.radBtnCrustCrunchyThin = new System.Windows.Forms.RadioButton();
            this.radBtnCrustChicago = new System.Windows.Forms.RadioButton();
            this.radBtnCrustNewYork = new System.Windows.Forms.RadioButton();
            this.radBtnCrustHand = new System.Windows.Forms.RadioButton();
            this.tabPgMeat = new System.Windows.Forms.TabPage();
            this.btnChangeTabMeat = new System.Windows.Forms.Button();
            this.lblMeatPrice = new System.Windows.Forms.Label();
            this.chLstBxMeat = new System.Windows.Forms.CheckedListBox();
            this.tabPgVeggie = new System.Windows.Forms.TabPage();
            this.lblVeggiePrice = new System.Windows.Forms.Label();
            this.chLstBxVeggie = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txBxCurrentTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txBxPizzaCnt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txBxDiscount = new System.Windows.Forms.TextBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPgContact.SuspendLayout();
            this.tabPgSize.SuspendLayout();
            this.grpBxSize.SuspendLayout();
            this.tabPgCrust.SuspendLayout();
            this.grpBxCrust.SuspendLayout();
            this.tabPgMeat.SuspendLayout();
            this.tabPgVeggie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(769, 537);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(273, 55);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Finnish current Pizza";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPgContact);
            this.tabControl1.Controls.Add(this.tabPgSize);
            this.tabControl1.Controls.Add(this.tabPgCrust);
            this.tabControl1.Controls.Add(this.tabPgMeat);
            this.tabControl1.Controls.Add(this.tabPgVeggie);
            this.tabControl1.Location = new System.Drawing.Point(36, 105);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 413);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPgContact
            // 
            this.tabPgContact.Controls.Add(this.cmbBXState);
            this.tabPgContact.Controls.Add(this.txBxPhone);
            this.tabPgContact.Controls.Add(this.txBxZip);
            this.tabPgContact.Controls.Add(this.txBxCity);
            this.tabPgContact.Controls.Add(this.txBxStreet);
            this.tabPgContact.Controls.Add(this.txBxName);
            this.tabPgContact.Controls.Add(this.btnContactSubmit);
            this.tabPgContact.Controls.Add(this.label9);
            this.tabPgContact.Controls.Add(this.label8);
            this.tabPgContact.Controls.Add(this.label7);
            this.tabPgContact.Controls.Add(this.label6);
            this.tabPgContact.Controls.Add(this.label5);
            this.tabPgContact.Controls.Add(this.label4);
            this.tabPgContact.Location = new System.Drawing.Point(4, 38);
            this.tabPgContact.Name = "tabPgContact";
            this.tabPgContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgContact.Size = new System.Drawing.Size(615, 371);
            this.tabPgContact.TabIndex = 4;
            this.tabPgContact.Text = "Contact";
            this.tabPgContact.UseVisualStyleBackColor = true;
            // 
            // cmbBXState
            // 
            this.cmbBXState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBXState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBXState.FormattingEnabled = true;
            this.cmbBXState.Items.AddRange(new object[] {
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY",
            "AS",
            "GU",
            "MP",
            "PR",
            "VI"});
            this.cmbBXState.Location = new System.Drawing.Point(224, 189);
            this.cmbBXState.Name = "cmbBXState";
            this.cmbBXState.Size = new System.Drawing.Size(85, 37);
            this.cmbBXState.TabIndex = 10;
            // 
            // txBxPhone
            // 
            this.txBxPhone.Location = new System.Drawing.Point(224, 237);
            this.txBxPhone.Name = "txBxPhone";
            this.txBxPhone.Size = new System.Drawing.Size(331, 35);
            this.txBxPhone.TabIndex = 12;
            // 
            // txBxZip
            // 
            this.txBxZip.Location = new System.Drawing.Point(377, 186);
            this.txBxZip.Name = "txBxZip";
            this.txBxZip.Size = new System.Drawing.Size(178, 35);
            this.txBxZip.TabIndex = 11;
            // 
            // txBxCity
            // 
            this.txBxCity.Location = new System.Drawing.Point(224, 135);
            this.txBxCity.Name = "txBxCity";
            this.txBxCity.Size = new System.Drawing.Size(330, 35);
            this.txBxCity.TabIndex = 9;
            // 
            // txBxStreet
            // 
            this.txBxStreet.Location = new System.Drawing.Point(225, 84);
            this.txBxStreet.Name = "txBxStreet";
            this.txBxStreet.Size = new System.Drawing.Size(330, 35);
            this.txBxStreet.TabIndex = 8;
            // 
            // txBxName
            // 
            this.txBxName.Location = new System.Drawing.Point(224, 33);
            this.txBxName.Name = "txBxName";
            this.txBxName.Size = new System.Drawing.Size(330, 35);
            this.txBxName.TabIndex = 7;
            // 
            // btnContactSubmit
            // 
            this.btnContactSubmit.BackgroundImage = global::FastPie.Properties.Resources.arrow;
            this.btnContactSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContactSubmit.Location = new System.Drawing.Point(407, 285);
            this.btnContactSubmit.Name = "btnContactSubmit";
            this.btnContactSubmit.Size = new System.Drawing.Size(194, 70);
            this.btnContactSubmit.TabIndex = 13;
            this.btnContactSubmit.UseVisualStyleBackColor = true;
            this.btnContactSubmit.Click += new System.EventHandler(this.btnContactSubmit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Zip";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Street Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // tabPgSize
            // 
            this.tabPgSize.Controls.Add(this.grpBxSize);
            this.tabPgSize.Location = new System.Drawing.Point(4, 38);
            this.tabPgSize.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgSize.Name = "tabPgSize";
            this.tabPgSize.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgSize.Size = new System.Drawing.Size(615, 371);
            this.tabPgSize.TabIndex = 0;
            this.tabPgSize.Text = "Size";
            this.tabPgSize.UseVisualStyleBackColor = true;
            // 
            // grpBxSize
            // 
            this.grpBxSize.AutoSize = true;
            this.grpBxSize.Controls.Add(this.label15);
            this.grpBxSize.Controls.Add(this.label14);
            this.grpBxSize.Controls.Add(this.label13);
            this.grpBxSize.Controls.Add(this.label12);
            this.grpBxSize.Controls.Add(this.label11);
            this.grpBxSize.Controls.Add(this.radBtnSizeXLarge);
            this.grpBxSize.Controls.Add(this.radBtnSizeLarge);
            this.grpBxSize.Controls.Add(this.radBtnSizeMedium);
            this.grpBxSize.Controls.Add(this.radBtnSizeSmall);
            this.grpBxSize.Controls.Add(this.radBtnSizeXSmall);
            this.grpBxSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxSize.Location = new System.Drawing.Point(4, 4);
            this.grpBxSize.Margin = new System.Windows.Forms.Padding(4);
            this.grpBxSize.Name = "grpBxSize";
            this.grpBxSize.Padding = new System.Windows.Forms.Padding(4);
            this.grpBxSize.Size = new System.Drawing.Size(607, 363);
            this.grpBxSize.TabIndex = 0;
            this.grpBxSize.TabStop = false;
            this.grpBxSize.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(215, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 29);
            this.label15.TabIndex = 12;
            this.label15.Text = "--- 13$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(215, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 29);
            this.label14.TabIndex = 11;
            this.label14.Text = "--- 10$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 29);
            this.label13.TabIndex = 10;
            this.label13.Text = "--- 8$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "--- 6$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(215, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 29);
            this.label11.TabIndex = 8;
            this.label11.Text = "--- 4$";
            // 
            // radBtnSizeXLarge
            // 
            this.radBtnSizeXLarge.AutoSize = true;
            this.radBtnSizeXLarge.Location = new System.Drawing.Point(21, 214);
            this.radBtnSizeXLarge.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnSizeXLarge.Name = "radBtnSizeXLarge";
            this.radBtnSizeXLarge.Size = new System.Drawing.Size(166, 33);
            this.radBtnSizeXLarge.TabIndex = 4;
            this.radBtnSizeXLarge.TabStop = true;
            this.radBtnSizeXLarge.Text = "Extra Large";
            this.radBtnSizeXLarge.UseVisualStyleBackColor = true;
            this.radBtnSizeXLarge.CheckedChanged += new System.EventHandler(this.radBtnSizeXLarge_CheckedChanged);
            // 
            // radBtnSizeLarge
            // 
            this.radBtnSizeLarge.AutoSize = true;
            this.radBtnSizeLarge.Location = new System.Drawing.Point(21, 174);
            this.radBtnSizeLarge.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnSizeLarge.Name = "radBtnSizeLarge";
            this.radBtnSizeLarge.Size = new System.Drawing.Size(106, 33);
            this.radBtnSizeLarge.TabIndex = 3;
            this.radBtnSizeLarge.TabStop = true;
            this.radBtnSizeLarge.Text = "Large";
            this.radBtnSizeLarge.UseVisualStyleBackColor = true;
            this.radBtnSizeLarge.CheckedChanged += new System.EventHandler(this.radBtnSizeLarge_CheckedChanged);
            // 
            // radBtnSizeMedium
            // 
            this.radBtnSizeMedium.AutoSize = true;
            this.radBtnSizeMedium.Location = new System.Drawing.Point(21, 134);
            this.radBtnSizeMedium.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnSizeMedium.Name = "radBtnSizeMedium";
            this.radBtnSizeMedium.Size = new System.Drawing.Size(131, 33);
            this.radBtnSizeMedium.TabIndex = 2;
            this.radBtnSizeMedium.TabStop = true;
            this.radBtnSizeMedium.Text = "Medium";
            this.radBtnSizeMedium.UseVisualStyleBackColor = true;
            this.radBtnSizeMedium.CheckedChanged += new System.EventHandler(this.radBtnSizeMedium_CheckedChanged);
            // 
            // radBtnSizeSmall
            // 
            this.radBtnSizeSmall.AutoSize = true;
            this.radBtnSizeSmall.Location = new System.Drawing.Point(21, 94);
            this.radBtnSizeSmall.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnSizeSmall.Name = "radBtnSizeSmall";
            this.radBtnSizeSmall.Size = new System.Drawing.Size(105, 33);
            this.radBtnSizeSmall.TabIndex = 1;
            this.radBtnSizeSmall.TabStop = true;
            this.radBtnSizeSmall.Text = "Small";
            this.radBtnSizeSmall.UseVisualStyleBackColor = true;
            this.radBtnSizeSmall.CheckedChanged += new System.EventHandler(this.radBtnSizeSmall_CheckedChanged);
            // 
            // radBtnSizeXSmall
            // 
            this.radBtnSizeXSmall.AutoSize = true;
            this.radBtnSizeXSmall.Location = new System.Drawing.Point(21, 54);
            this.radBtnSizeXSmall.Margin = new System.Windows.Forms.Padding(4);
            this.radBtnSizeXSmall.Name = "radBtnSizeXSmall";
            this.radBtnSizeXSmall.Size = new System.Drawing.Size(165, 33);
            this.radBtnSizeXSmall.TabIndex = 0;
            this.radBtnSizeXSmall.TabStop = true;
            this.radBtnSizeXSmall.Text = "Extra Small";
            this.radBtnSizeXSmall.UseVisualStyleBackColor = true;
            this.radBtnSizeXSmall.CheckedChanged += new System.EventHandler(this.radBtnSizeXSmall_CheckedChanged);
            // 
            // tabPgCrust
            // 
            this.tabPgCrust.Controls.Add(this.grpBxCrust);
            this.tabPgCrust.Location = new System.Drawing.Point(4, 38);
            this.tabPgCrust.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgCrust.Name = "tabPgCrust";
            this.tabPgCrust.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgCrust.Size = new System.Drawing.Size(615, 371);
            this.tabPgCrust.TabIndex = 1;
            this.tabPgCrust.Text = "Crust";
            this.tabPgCrust.UseVisualStyleBackColor = true;
            // 
            // grpBxCrust
            // 
            this.grpBxCrust.AutoSize = true;
            this.grpBxCrust.Controls.Add(this.radBtnCrustGluten);
            this.grpBxCrust.Controls.Add(this.radBtnCrustCrunchyThin);
            this.grpBxCrust.Controls.Add(this.radBtnCrustChicago);
            this.grpBxCrust.Controls.Add(this.radBtnCrustNewYork);
            this.grpBxCrust.Controls.Add(this.radBtnCrustHand);
            this.grpBxCrust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxCrust.Location = new System.Drawing.Point(4, 4);
            this.grpBxCrust.Name = "grpBxCrust";
            this.grpBxCrust.Size = new System.Drawing.Size(607, 363);
            this.grpBxCrust.TabIndex = 0;
            this.grpBxCrust.TabStop = false;
            this.grpBxCrust.Visible = false;
            // 
            // radBtnCrustGluten
            // 
            this.radBtnCrustGluten.AutoSize = true;
            this.radBtnCrustGluten.Location = new System.Drawing.Point(21, 213);
            this.radBtnCrustGluten.Name = "radBtnCrustGluten";
            this.radBtnCrustGluten.Size = new System.Drawing.Size(171, 33);
            this.radBtnCrustGluten.TabIndex = 4;
            this.radBtnCrustGluten.TabStop = true;
            this.radBtnCrustGluten.Text = "Gluten Free";
            this.radBtnCrustGluten.UseVisualStyleBackColor = true;
            this.radBtnCrustGluten.CheckedChanged += new System.EventHandler(this.radBtnCrustGluten_CheckedChanged);
            // 
            // radBtnCrustCrunchyThin
            // 
            this.radBtnCrustCrunchyThin.AutoSize = true;
            this.radBtnCrustCrunchyThin.Location = new System.Drawing.Point(21, 174);
            this.radBtnCrustCrunchyThin.Name = "radBtnCrustCrunchyThin";
            this.radBtnCrustCrunchyThin.Size = new System.Drawing.Size(185, 33);
            this.radBtnCrustCrunchyThin.TabIndex = 3;
            this.radBtnCrustCrunchyThin.TabStop = true;
            this.radBtnCrustCrunchyThin.Text = "Crunchy Thin";
            this.radBtnCrustCrunchyThin.UseVisualStyleBackColor = true;
            this.radBtnCrustCrunchyThin.CheckedChanged += new System.EventHandler(this.radBtnCrustCrunchyThin_CheckedChanged);
            // 
            // radBtnCrustChicago
            // 
            this.radBtnCrustChicago.AutoSize = true;
            this.radBtnCrustChicago.Location = new System.Drawing.Point(21, 135);
            this.radBtnCrustChicago.Name = "radBtnCrustChicago";
            this.radBtnCrustChicago.Size = new System.Drawing.Size(133, 33);
            this.radBtnCrustChicago.TabIndex = 2;
            this.radBtnCrustChicago.TabStop = true;
            this.radBtnCrustChicago.Text = "Chicago";
            this.radBtnCrustChicago.UseVisualStyleBackColor = true;
            this.radBtnCrustChicago.CheckedChanged += new System.EventHandler(this.radBtnCrustChicago_CheckedChanged);
            // 
            // radBtnCrustNewYork
            // 
            this.radBtnCrustNewYork.AutoSize = true;
            this.radBtnCrustNewYork.Location = new System.Drawing.Point(21, 96);
            this.radBtnCrustNewYork.Name = "radBtnCrustNewYork";
            this.radBtnCrustNewYork.Size = new System.Drawing.Size(150, 33);
            this.radBtnCrustNewYork.TabIndex = 1;
            this.radBtnCrustNewYork.TabStop = true;
            this.radBtnCrustNewYork.Text = "New York";
            this.radBtnCrustNewYork.UseVisualStyleBackColor = true;
            this.radBtnCrustNewYork.CheckedChanged += new System.EventHandler(this.radBtnCrustNewYork_CheckedChanged);
            // 
            // radBtnCrustHand
            // 
            this.radBtnCrustHand.AutoSize = true;
            this.radBtnCrustHand.Location = new System.Drawing.Point(21, 57);
            this.radBtnCrustHand.Name = "radBtnCrustHand";
            this.radBtnCrustHand.Size = new System.Drawing.Size(189, 33);
            this.radBtnCrustHand.TabIndex = 0;
            this.radBtnCrustHand.TabStop = true;
            this.radBtnCrustHand.Text = "Hand Tossed";
            this.radBtnCrustHand.UseVisualStyleBackColor = true;
            this.radBtnCrustHand.CheckedChanged += new System.EventHandler(this.radBtnCrustHand_CheckedChanged);
            // 
            // tabPgMeat
            // 
            this.tabPgMeat.Controls.Add(this.btnChangeTabMeat);
            this.tabPgMeat.Controls.Add(this.lblMeatPrice);
            this.tabPgMeat.Controls.Add(this.chLstBxMeat);
            this.tabPgMeat.Location = new System.Drawing.Point(4, 38);
            this.tabPgMeat.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgMeat.Name = "tabPgMeat";
            this.tabPgMeat.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgMeat.Size = new System.Drawing.Size(615, 371);
            this.tabPgMeat.TabIndex = 2;
            this.tabPgMeat.Text = "Meats";
            this.tabPgMeat.UseVisualStyleBackColor = true;
            // 
            // btnChangeTabMeat
            // 
            this.btnChangeTabMeat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChangeTabMeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeTabMeat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChangeTabMeat.Location = new System.Drawing.Point(352, 278);
            this.btnChangeTabMeat.Name = "btnChangeTabMeat";
            this.btnChangeTabMeat.Size = new System.Drawing.Size(248, 50);
            this.btnChangeTabMeat.TabIndex = 14;
            this.btnChangeTabMeat.Text = "Veggies";
            this.btnChangeTabMeat.UseVisualStyleBackColor = false;
            this.btnChangeTabMeat.Visible = false;
            this.btnChangeTabMeat.Click += new System.EventHandler(this.btnChangeTabMeat_Click);
            // 
            // lblMeatPrice
            // 
            this.lblMeatPrice.AutoSize = true;
            this.lblMeatPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMeatPrice.Location = new System.Drawing.Point(414, 58);
            this.lblMeatPrice.Name = "lblMeatPrice";
            this.lblMeatPrice.Size = new System.Drawing.Size(186, 29);
            this.lblMeatPrice.TabIndex = 9;
            this.lblMeatPrice.Text = "0.50 Cents Each";
            this.lblMeatPrice.Visible = false;
            // 
            // chLstBxMeat
            // 
            this.chLstBxMeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chLstBxMeat.CheckOnClick = true;
            this.chLstBxMeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chLstBxMeat.FormattingEnabled = true;
            this.chLstBxMeat.Items.AddRange(new object[] {
            "Pepperoni",
            "Italian Sausage",
            "Beef",
            "Philly Steak",
            "Ham",
            "Bacon"});
            this.chLstBxMeat.Location = new System.Drawing.Point(4, 4);
            this.chLstBxMeat.Name = "chLstBxMeat";
            this.chLstBxMeat.Size = new System.Drawing.Size(607, 363);
            this.chLstBxMeat.TabIndex = 0;
            this.chLstBxMeat.Visible = false;
            this.chLstBxMeat.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chLstBxMeat_ItemCheck);
            // 
            // tabPgVeggie
            // 
            this.tabPgVeggie.Controls.Add(this.lblVeggiePrice);
            this.tabPgVeggie.Controls.Add(this.chLstBxVeggie);
            this.tabPgVeggie.Location = new System.Drawing.Point(4, 38);
            this.tabPgVeggie.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgVeggie.Name = "tabPgVeggie";
            this.tabPgVeggie.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgVeggie.Size = new System.Drawing.Size(615, 371);
            this.tabPgVeggie.TabIndex = 3;
            this.tabPgVeggie.Text = "Veggies";
            this.tabPgVeggie.UseVisualStyleBackColor = true;
            // 
            // lblVeggiePrice
            // 
            this.lblVeggiePrice.AutoSize = true;
            this.lblVeggiePrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblVeggiePrice.Location = new System.Drawing.Point(422, 80);
            this.lblVeggiePrice.Name = "lblVeggiePrice";
            this.lblVeggiePrice.Size = new System.Drawing.Size(186, 29);
            this.lblVeggiePrice.TabIndex = 2;
            this.lblVeggiePrice.Text = "0.35 Cents Each";
            this.lblVeggiePrice.Visible = false;
            // 
            // chLstBxVeggie
            // 
            this.chLstBxVeggie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chLstBxVeggie.CheckOnClick = true;
            this.chLstBxVeggie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chLstBxVeggie.FormattingEnabled = true;
            this.chLstBxVeggie.Items.AddRange(new object[] {
            "Banana Peppers",
            "Black Olives",
            "Green Peppers",
            "Jalapeno Peppers",
            "Mushrooms",
            "Pineapple",
            "Onions",
            "Roasted Red Peppers",
            "Spinach",
            "Diced Tomatoes"});
            this.chLstBxVeggie.Location = new System.Drawing.Point(4, 4);
            this.chLstBxVeggie.Name = "chLstBxVeggie";
            this.chLstBxVeggie.Size = new System.Drawing.Size(607, 363);
            this.chLstBxVeggie.TabIndex = 1;
            this.chLstBxVeggie.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 683);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Total :";
            // 
            // txBxCurrentTotal
            // 
            this.txBxCurrentTotal.Location = new System.Drawing.Point(902, 677);
            this.txBxCurrentTotal.Name = "txBxCurrentTotal";
            this.txBxCurrentTotal.ReadOnly = true;
            this.txBxCurrentTotal.Size = new System.Drawing.Size(139, 35);
            this.txBxCurrentTotal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(403, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 76);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fast Pie";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(264, 624);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(185, 59);
            this.btnCheckout.TabIndex = 10;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Visible = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnStartOver
            // 
            this.btnStartOver.Location = new System.Drawing.Point(470, 624);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(185, 59);
            this.btnStartOver.TabIndex = 11;
            this.btnStartOver.Text = "Start Over";
            this.btnStartOver.UseVisualStyleBackColor = true;
            this.btnStartOver.Click += new System.EventHandler(this.btnStartOver_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FastPie.Properties.Resources.FastPieLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(667, 143);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblContactInfo.Location = new System.Drawing.Point(666, 94);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(369, 31);
            this.lblContactInfo.TabIndex = 1;
            this.lblContactInfo.Text = "Contact Information Required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 630);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number of Pizzas :";
            // 
            // txBxPizzaCnt
            // 
            this.txBxPizzaCnt.Location = new System.Drawing.Point(903, 624);
            this.txBxPizzaCnt.Name = "txBxPizzaCnt";
            this.txBxPizzaCnt.ReadOnly = true;
            this.txBxPizzaCnt.Size = new System.Drawing.Size(139, 35);
            this.txBxPizzaCnt.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(44, 537);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 29);
            this.label18.TabIndex = 15;
            this.label18.Text = "Discount Code :";
            // 
            // txBxDiscount
            // 
            this.txBxDiscount.Location = new System.Drawing.Point(264, 537);
            this.txBxDiscount.Name = "txBxDiscount";
            this.txBxDiscount.Size = new System.Drawing.Size(185, 35);
            this.txBxDiscount.TabIndex = 16;
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(470, 537);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(189, 55);
            this.btnDiscount.TabIndex = 17;
            this.btnDiscount.Text = "Add Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1085, 799);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.txBxDiscount);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txBxPizzaCnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.btnStartOver);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txBxCurrentTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Fast Pie Order Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPgContact.ResumeLayout(false);
            this.tabPgContact.PerformLayout();
            this.tabPgSize.ResumeLayout(false);
            this.tabPgSize.PerformLayout();
            this.grpBxSize.ResumeLayout(false);
            this.grpBxSize.PerformLayout();
            this.tabPgCrust.ResumeLayout(false);
            this.tabPgCrust.PerformLayout();
            this.grpBxCrust.ResumeLayout(false);
            this.grpBxCrust.PerformLayout();
            this.tabPgMeat.ResumeLayout(false);
            this.tabPgMeat.PerformLayout();
            this.tabPgVeggie.ResumeLayout(false);
            this.tabPgVeggie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPgSize;
        private System.Windows.Forms.GroupBox grpBxSize;
        private System.Windows.Forms.RadioButton radBtnSizeXLarge;
        private System.Windows.Forms.RadioButton radBtnSizeLarge;
        private System.Windows.Forms.RadioButton radBtnSizeMedium;
        private System.Windows.Forms.RadioButton radBtnSizeSmall;
        private System.Windows.Forms.RadioButton radBtnSizeXSmall;
        private System.Windows.Forms.TabPage tabPgCrust;
        private System.Windows.Forms.TabPage tabPgMeat;
        private System.Windows.Forms.TabPage tabPgVeggie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpBxCrust;
        private System.Windows.Forms.RadioButton radBtnCrustHand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txBxCurrentTotal;
        private System.Windows.Forms.RadioButton radBtnCrustGluten;
        private System.Windows.Forms.RadioButton radBtnCrustCrunchyThin;
        private System.Windows.Forms.RadioButton radBtnCrustChicago;
        private System.Windows.Forms.RadioButton radBtnCrustNewYork;
        private System.Windows.Forms.CheckedListBox chLstBxMeat;
        private System.Windows.Forms.CheckedListBox chLstBxVeggie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TabPage tabPgContact;
        private System.Windows.Forms.TextBox txBxPhone;
        private System.Windows.Forms.TextBox txBxZip;
        private System.Windows.Forms.TextBox txBxCity;
        private System.Windows.Forms.TextBox txBxStreet;
        private System.Windows.Forms.TextBox txBxName;
        private System.Windows.Forms.Button btnContactSubmit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.ComboBox cmbBXState;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMeatPrice;
        private System.Windows.Forms.Label lblVeggiePrice;
        private System.Windows.Forms.Button btnChangeTabMeat;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBxPizzaCnt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txBxDiscount;
        private System.Windows.Forms.Button btnDiscount;
    }
}

