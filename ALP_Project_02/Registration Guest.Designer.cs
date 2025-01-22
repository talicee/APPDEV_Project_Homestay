namespace ALP_Project_02
{
    partial class Registration_Guest
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
            this.label21 = new System.Windows.Forms.Label();
            this.tb_RegistGuestNIK = new System.Windows.Forms.TextBox();
            this.tb_RegistGuestName = new System.Windows.Forms.TextBox();
            this.tb_RegistGuestAddress = new System.Windows.Forms.TextBox();
            this.tb_RegistGuestEmail = new System.Windows.Forms.TextBox();
            this.tb_RegistGuestPhone = new System.Windows.Forms.TextBox();
            this.btn_RegisterationGuestSave = new System.Windows.Forms.Button();
            this.dgv_RegistrationGuest = new System.Windows.Forms.DataGridView();
            this.datetime_BirthGuest = new System.Windows.Forms.DateTimePicker();
            this.cbx_RegistGuestGender = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_IDG = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_IDG = new System.Windows.Forms.TextBox();
            this.btn_RegistrationGuestBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_RegistGuestNationality = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistrationGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana Pro Cond", 14F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(40, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(251, 34);
            this.label21.TabIndex = 27;
            this.label21.Text = "Guest Registration";
            // 
            // tb_RegistGuestNIK
            // 
            this.tb_RegistGuestNIK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_RegistGuestNIK.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_RegistGuestNIK.Location = new System.Drawing.Point(46, 126);
            this.tb_RegistGuestNIK.Name = "tb_RegistGuestNIK";
            this.tb_RegistGuestNIK.Size = new System.Drawing.Size(285, 27);
            this.tb_RegistGuestNIK.TabIndex = 1;
            this.tb_RegistGuestNIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RegistGuestNIK_KeyPress);
            // 
            // tb_RegistGuestName
            // 
            this.tb_RegistGuestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_RegistGuestName.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_RegistGuestName.Location = new System.Drawing.Point(46, 172);
            this.tb_RegistGuestName.Name = "tb_RegistGuestName";
            this.tb_RegistGuestName.Size = new System.Drawing.Size(285, 27);
            this.tb_RegistGuestName.TabIndex = 2;
            this.tb_RegistGuestName.TextChanged += new System.EventHandler(this.tb_RegistGuestName_TextChanged);
            this.tb_RegistGuestName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RegistGuestName_KeyPress);
            // 
            // tb_RegistGuestAddress
            // 
            this.tb_RegistGuestAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_RegistGuestAddress.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_RegistGuestAddress.Location = new System.Drawing.Point(47, 414);
            this.tb_RegistGuestAddress.Name = "tb_RegistGuestAddress";
            this.tb_RegistGuestAddress.Size = new System.Drawing.Size(285, 27);
            this.tb_RegistGuestAddress.TabIndex = 7;
            // 
            // tb_RegistGuestEmail
            // 
            this.tb_RegistGuestEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_RegistGuestEmail.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_RegistGuestEmail.Location = new System.Drawing.Point(47, 366);
            this.tb_RegistGuestEmail.Name = "tb_RegistGuestEmail";
            this.tb_RegistGuestEmail.Size = new System.Drawing.Size(285, 27);
            this.tb_RegistGuestEmail.TabIndex = 6;
            // 
            // tb_RegistGuestPhone
            // 
            this.tb_RegistGuestPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_RegistGuestPhone.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_RegistGuestPhone.Location = new System.Drawing.Point(46, 318);
            this.tb_RegistGuestPhone.Name = "tb_RegistGuestPhone";
            this.tb_RegistGuestPhone.Size = new System.Drawing.Size(285, 27);
            this.tb_RegistGuestPhone.TabIndex = 5;
            this.tb_RegistGuestPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_RegistGuestPhone_KeyPress);
            // 
            // btn_RegisterationGuestSave
            // 
            this.btn_RegisterationGuestSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_RegisterationGuestSave.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_RegisterationGuestSave.ForeColor = System.Drawing.Color.White;
            this.btn_RegisterationGuestSave.Location = new System.Drawing.Point(47, 493);
            this.btn_RegisterationGuestSave.Name = "btn_RegisterationGuestSave";
            this.btn_RegisterationGuestSave.Size = new System.Drawing.Size(125, 36);
            this.btn_RegisterationGuestSave.TabIndex = 8;
            this.btn_RegisterationGuestSave.Text = "Save";
            this.btn_RegisterationGuestSave.UseVisualStyleBackColor = false;
            this.btn_RegisterationGuestSave.Click += new System.EventHandler(this.btn_RegisterationGuestSave_Click);
            // 
            // dgv_RegistrationGuest
            // 
            this.dgv_RegistrationGuest.AllowUserToAddRows = false;
            this.dgv_RegistrationGuest.AllowUserToDeleteRows = false;
            this.dgv_RegistrationGuest.AllowUserToResizeColumns = false;
            this.dgv_RegistrationGuest.AllowUserToResizeRows = false;
            this.dgv_RegistrationGuest.BackgroundColor = System.Drawing.Color.White;
            this.dgv_RegistrationGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RegistrationGuest.Location = new System.Drawing.Point(338, 77);
            this.dgv_RegistrationGuest.MultiSelect = false;
            this.dgv_RegistrationGuest.Name = "dgv_RegistrationGuest";
            this.dgv_RegistrationGuest.ReadOnly = true;
            this.dgv_RegistrationGuest.RowHeadersVisible = false;
            this.dgv_RegistrationGuest.RowHeadersWidth = 62;
            this.dgv_RegistrationGuest.RowTemplate.Height = 28;
            this.dgv_RegistrationGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RegistrationGuest.Size = new System.Drawing.Size(599, 452);
            this.dgv_RegistrationGuest.TabIndex = 41;
            this.dgv_RegistrationGuest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RegistrationGuest_CellClick);
            this.dgv_RegistrationGuest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RegistrationGuest_CellDoubleClick);
            // 
            // datetime_BirthGuest
            // 
            this.datetime_BirthGuest.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.datetime_BirthGuest.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.datetime_BirthGuest.Location = new System.Drawing.Point(46, 222);
            this.datetime_BirthGuest.Name = "datetime_BirthGuest";
            this.datetime_BirthGuest.Size = new System.Drawing.Size(285, 27);
            this.datetime_BirthGuest.TabIndex = 3;
            this.datetime_BirthGuest.ValueChanged += new System.EventHandler(this.datetime_BirthGuest_ValueChanged);
            // 
            // cbx_RegistGuestGender
            // 
            this.cbx_RegistGuestGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.cbx_RegistGuestGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_RegistGuestGender.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.cbx_RegistGuestGender.FormattingEnabled = true;
            this.cbx_RegistGuestGender.Items.AddRange(new object[] {
            "P",
            "L"});
            this.cbx_RegistGuestGender.Location = new System.Drawing.Point(46, 269);
            this.cbx_RegistGuestGender.Name = "cbx_RegistGuestGender";
            this.cbx_RegistGuestGender.Size = new System.Drawing.Size(285, 26);
            this.cbx_RegistGuestGender.TabIndex = 4;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_edit.Enabled = false;
            this.btn_edit.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(200, 493);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(125, 36);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label5.Location = new System.Drawing.Point(44, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "NIK :";
            // 
            // lb_IDG
            // 
            this.lb_IDG.AutoSize = true;
            this.lb_IDG.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.lb_IDG.Location = new System.Drawing.Point(44, 58);
            this.lb_IDG.Name = "lb_IDG";
            this.lb_IDG.Size = new System.Drawing.Size(78, 18);
            this.lb_IDG.TabIndex = 51;
            this.lb_IDG.Text = "ID Guest :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label10.Location = new System.Drawing.Point(44, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 18);
            this.label10.TabIndex = 57;
            this.label10.Text = "Date Of Birth :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label12.Location = new System.Drawing.Point(44, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 18);
            this.label12.TabIndex = 55;
            this.label12.Text = "Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label14.Location = new System.Drawing.Point(44, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 18);
            this.label14.TabIndex = 61;
            this.label14.Text = "Phone Number :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label16.Location = new System.Drawing.Point(44, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 18);
            this.label16.TabIndex = 59;
            this.label16.Text = "Gender :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label19.Location = new System.Drawing.Point(47, 395);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 18);
            this.label19.TabIndex = 65;
            this.label19.Text = "Address :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label22.Location = new System.Drawing.Point(46, 347);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 18);
            this.label22.TabIndex = 63;
            this.label22.Text = "Email :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label24.Location = new System.Drawing.Point(46, 442);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(91, 18);
            this.label24.TabIndex = 67;
            this.label24.Text = "Nationality :";
            // 
            // tb_IDG
            // 
            this.tb_IDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_IDG.Enabled = false;
            this.tb_IDG.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.tb_IDG.Location = new System.Drawing.Point(46, 78);
            this.tb_IDG.Name = "tb_IDG";
            this.tb_IDG.Size = new System.Drawing.Size(285, 27);
            this.tb_IDG.TabIndex = 43;
            // 
            // btn_RegistrationGuestBack
            // 
            this.btn_RegistrationGuestBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(108)))), ((int)(((byte)(92)))));
            this.btn_RegistrationGuestBack.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.btn_RegistrationGuestBack.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrationGuestBack.Location = new System.Drawing.Point(829, 24);
            this.btn_RegistrationGuestBack.Name = "btn_RegistrationGuestBack";
            this.btn_RegistrationGuestBack.Size = new System.Drawing.Size(108, 36);
            this.btn_RegistrationGuestBack.TabIndex = 10;
            this.btn_RegistrationGuestBack.Text = "Back";
            this.btn_RegistrationGuestBack.UseVisualStyleBackColor = false;
            this.btn_RegistrationGuestBack.Click += new System.EventHandler(this.btn_RegistrationGuestBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label1.Location = new System.Drawing.Point(426, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "Name :";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana Pro Cond", 8F);
            this.label2.Location = new System.Drawing.Point(426, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Name :";
            this.label2.Visible = false;
            // 
            // tb_RegistGuestNationality
            // 
            this.tb_RegistGuestNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_RegistGuestNationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tb_RegistGuestNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(213)))), ((int)(((byte)(203)))));
            this.tb_RegistGuestNationality.FormattingEnabled = true;
            this.tb_RegistGuestNationality.Items.AddRange(new object[] {
            "Afghan",
            "Albanian",
            "Algerian",
            "American",
            "Andorran",
            "Angolan",
            "Antiguans and Barbudans",
            "Argentinean",
            "Armenian",
            "Australian",
            "Austrian",
            "Azerbaijani",
            "Bahamian",
            "Bahraini",
            "Bangladeshi",
            "Barbadian",
            "Barbudans",
            "Batswana",
            "Belarusian",
            "Belgian",
            "Belizean",
            "Beninese",
            "Bhutanese",
            "Bolivian",
            "Bosnian",
            "Brazilian",
            "British",
            "Bruneian",
            "Bulgarian",
            "Burkinabe",
            "Burmese",
            "Burundian",
            "Cambodian",
            "Cameroonian",
            "Canadian",
            "Cape Verdean",
            "Central African",
            "Chadian",
            "Chilean",
            "Chinese",
            "Colombian",
            "Comoran",
            "Congolese",
            "Costa Rican",
            "Croatian",
            "Cuban",
            "Cypriot",
            "Czech",
            "Danish",
            "Djibouti",
            "Dominican",
            "Dominican Republic",
            "Dutch",
            "East Timorese",
            "Ecuadorean",
            "Egyptian",
            "Emirian",
            "Equatorial Guinean",
            "Eritrean",
            "Estonian",
            "Ethiopian",
            "Fijian",
            "Filipino",
            "Finnish",
            "French",
            "Gabonese",
            "Gambian",
            "Georgian",
            "German",
            "Ghanaian",
            "Greek",
            "Grenadian",
            "Guatemalan",
            "Guinea-Bissauan",
            "Guinean",
            "Guyanese",
            "Haitian",
            "Herzegovinian",
            "Honduran",
            "Hungarian",
            "I-Kiribati",
            "Icelander",
            "Indian",
            "Indonesian",
            "Iranian",
            "Iraqi",
            "Irish",
            "Israeli",
            "Italian",
            "Ivorian",
            "Jamaican",
            "Japanese",
            "Jordanian",
            "Kazakhstani",
            "Kenyan",
            "Kittian and Nevisian",
            "Kuwaiti",
            "Kyrgyz",
            "Laotian",
            "Latvian",
            "Lebanese",
            "Liberian",
            "Libyan",
            "Liechtensteiner",
            "Lithuanian",
            "Luxembourger",
            "Macedonian",
            "Malagasy",
            "Malawian",
            "Malaysian",
            "Maldivan",
            "Malian",
            "Maltese",
            "Marshallese",
            "Mauritanian",
            "Mauritian",
            "Mexican",
            "Micronesian",
            "Moldovan",
            "Monacan",
            "Mongolian",
            "Moroccan",
            "Mosotho",
            "Motswana",
            "Mozambican",
            "Namibian",
            "Nauruan",
            "Nepalese",
            "New Zealander",
            "Ni-Vanuatu",
            "Nicaraguan",
            "Nigerian",
            "Nigerien",
            "North Korean",
            "Northern Irish",
            "Norwegian",
            "Omani",
            "Pakistani",
            "Palauan",
            "Panamanian",
            "Papua New Guinean",
            "Paraguayan",
            "Peruvian",
            "Polish",
            "Portuguese",
            "Qatari",
            "Romanian ",
            "Russian",
            "Rwandan",
            "Saint Lucian",
            "Salvadoran",
            "Samoan",
            "San Marinese",
            "Sao Tomean",
            "Saudi",
            "Scottish",
            "Senegalese",
            "Serbian",
            "Seychellois",
            "Sierra Leonean",
            "Singaporean",
            "Slovak",
            "Slovenian",
            "Solomon Islander",
            "Somali",
            "South African",
            "South Korean",
            "South Sudanese",
            "Spanish",
            "Sri Lankan",
            "Sudanese",
            "Surinamer",
            "Swazi",
            "Swedish",
            "Swiss",
            "Syrian",
            "Taiwanese",
            "Tajik",
            "Tanzanian",
            "Thai",
            "Togolese",
            "Tongan",
            "Trinidadian/Tobagonian",
            "Tunisian",
            "Turkish",
            "Tuvaluan",
            "Ugandan",
            "Ukrainian",
            "Uruguayan",
            "Uzbekistani",
            "Venezuelan",
            "Vietnamese",
            "Welsh",
            "Yemenite",
            "Zambian",
            "Zimbabwean"});
            this.tb_RegistGuestNationality.Location = new System.Drawing.Point(50, 463);
            this.tb_RegistGuestNationality.Name = "tb_RegistGuestNationality";
            this.tb_RegistGuestNationality.Size = new System.Drawing.Size(281, 28);
            this.tb_RegistGuestNationality.TabIndex = 8;
            // 
            // Registration_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.tb_RegistGuestNationality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_RegistGuestAddress);
            this.Controls.Add(this.tb_RegistGuestEmail);
            this.Controls.Add(this.tb_RegistGuestPhone);
            this.Controls.Add(this.datetime_BirthGuest);
            this.Controls.Add(this.cbx_RegistGuestGender);
            this.Controls.Add(this.tb_RegistGuestName);
            this.Controls.Add(this.tb_RegistGuestNIK);
            this.Controls.Add(this.tb_IDG);
            this.Controls.Add(this.btn_RegistrationGuestBack);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_IDG);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgv_RegistrationGuest);
            this.Controls.Add(this.btn_RegisterationGuestSave);
            this.Controls.Add(this.label21);
            this.MaximizeBox = false;
            this.Name = "Registration_Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration_Guest";
            this.Load += new System.EventHandler(this.Registration_Guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RegistrationGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_RegistGuestNIK;
        private System.Windows.Forms.TextBox tb_RegistGuestName;
        private System.Windows.Forms.TextBox tb_RegistGuestAddress;
        private System.Windows.Forms.TextBox tb_RegistGuestEmail;
        private System.Windows.Forms.TextBox tb_RegistGuestPhone;
        private System.Windows.Forms.Button btn_RegisterationGuestSave;
        private System.Windows.Forms.DataGridView dgv_RegistrationGuest;
        private System.Windows.Forms.DateTimePicker datetime_BirthGuest;
        private System.Windows.Forms.ComboBox cbx_RegistGuestGender;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_IDG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_IDG;
        private System.Windows.Forms.Button btn_RegistrationGuestBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tb_RegistGuestNationality;
    }
}