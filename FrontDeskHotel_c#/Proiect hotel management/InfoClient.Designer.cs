
namespace Proiect_hotel_management
{
    partial class InfoClient
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
            this.CNPclient = new System.Windows.Forms.TextBox();
            this.Numeclient = new System.Windows.Forms.TextBox();
            this.Telefonclient = new System.Windows.Forms.TextBox();
            this.Taraclient = new System.Windows.Forms.ComboBox();
            this.Listaclient = new System.Windows.Forms.DataGridView();
            this.Adauga = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.Editeaza = new System.Windows.Forms.Button();
            this.Cautareclient = new System.Windows.Forms.TextBox();
            this.Cauta = new System.Windows.Forms.Button();
            this.Datalbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Reset = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Listaclient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informatii Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CNPclient
            // 
            this.CNPclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPclient.Location = new System.Drawing.Point(49, 76);
            this.CNPclient.Name = "CNPclient";
            this.CNPclient.Size = new System.Drawing.Size(175, 29);
            this.CNPclient.TabIndex = 1;
            this.CNPclient.Text = "CNP-ul clientului";
            // 
            // Numeclient
            // 
            this.Numeclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeclient.Location = new System.Drawing.Point(49, 121);
            this.Numeclient.Name = "Numeclient";
            this.Numeclient.Size = new System.Drawing.Size(175, 29);
            this.Numeclient.TabIndex = 2;
            this.Numeclient.Text = "Numele clientului";
            // 
            // Telefonclient
            // 
            this.Telefonclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonclient.Location = new System.Drawing.Point(49, 166);
            this.Telefonclient.Name = "Telefonclient";
            this.Telefonclient.Size = new System.Drawing.Size(244, 29);
            this.Telefonclient.TabIndex = 3;
            this.Telefonclient.Text = "Nr de telefon al clientului\r\n\r\n\r\n";
            // 
            // Taraclient
            // 
            this.Taraclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taraclient.FormattingEnabled = true;
            this.Taraclient.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua & Deps",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Central African Rep",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo",
            "Congo {Democratic Rep}",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland {Republic}",
            "Israel",
            "Italy",
            "Ivory Coast",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea North",
            "Korea South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar, {Burma}",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russian Federation",
            "Rwanda",
            "St Kitts & Nevis",
            "St Lucia",
            "Saint Vincent & the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome & Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad & Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.Taraclient.Location = new System.Drawing.Point(49, 210);
            this.Taraclient.Name = "Taraclient";
            this.Taraclient.Size = new System.Drawing.Size(216, 32);
            this.Taraclient.TabIndex = 4;
            this.Taraclient.Text = "Tara clientului";
            // 
            // Listaclient
            // 
            this.Listaclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listaclient.Location = new System.Drawing.Point(355, 91);
            this.Listaclient.Name = "Listaclient";
            this.Listaclient.Size = new System.Drawing.Size(382, 347);
            this.Listaclient.TabIndex = 5;
            this.Listaclient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listaclient_CellContentClick);
            // 
            // Adauga
            // 
            this.Adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adauga.Location = new System.Drawing.Point(53, 324);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(62, 32);
            this.Adauga.TabIndex = 7;
            this.Adauga.Text = "Adauga";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sterge
            // 
            this.Sterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sterge.Location = new System.Drawing.Point(231, 324);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(62, 32);
            this.Sterge.TabIndex = 8;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // Editeaza
            // 
            this.Editeaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeaza.Location = new System.Drawing.Point(135, 324);
            this.Editeaza.Name = "Editeaza";
            this.Editeaza.Size = new System.Drawing.Size(75, 32);
            this.Editeaza.TabIndex = 9;
            this.Editeaza.Text = "Editeaza";
            this.Editeaza.UseVisualStyleBackColor = true;
            this.Editeaza.Click += new System.EventHandler(this.Editeaza_Click);
            // 
            // Cautareclient
            // 
            this.Cautareclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautareclient.Location = new System.Drawing.Point(425, 61);
            this.Cautareclient.Name = "Cautareclient";
            this.Cautareclient.Size = new System.Drawing.Size(175, 29);
            this.Cautareclient.TabIndex = 10;
            this.Cautareclient.Text = "Numele clientului";
            this.Cautareclient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cautareclient.TextChanged += new System.EventHandler(this.Cautareclient_TextChanged);
            // 
            // Cauta
            // 
            this.Cauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cauta.Location = new System.Drawing.Point(597, 61);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(62, 29);
            this.Cauta.TabIndex = 11;
            this.Cauta.Text = "Cauta";
            this.Cauta.UseVisualStyleBackColor = true;
            this.Cauta.Click += new System.EventHandler(this.Cauta_Click);
            // 
            // Datalbl
            // 
            this.Datalbl.AutoSize = true;
            this.Datalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datalbl.Location = new System.Drawing.Point(616, 19);
            this.Datalbl.Name = "Datalbl";
            this.Datalbl.Size = new System.Drawing.Size(51, 24);
            this.Datalbl.TabIndex = 12;
            this.Datalbl.Text = "Data\r\n";
            this.Datalbl.Click += new System.EventHandler(this.Datalbl_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(661, 69);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(53, 20);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(53, 400);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(62, 27);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // InfoClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Datalbl);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.Cautareclient);
            this.Controls.Add(this.Editeaza);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.Listaclient);
            this.Controls.Add(this.Taraclient);
            this.Controls.Add(this.Telefonclient);
            this.Controls.Add(this.Numeclient);
            this.Controls.Add(this.CNPclient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoClient";
            this.Load += new System.EventHandler(this.InfoClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listaclient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CNPclient;
        private System.Windows.Forms.TextBox Numeclient;
        private System.Windows.Forms.TextBox Telefonclient;
        private System.Windows.Forms.ComboBox Taraclient;
        private System.Windows.Forms.DataGridView Listaclient;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.Button Editeaza;
        private System.Windows.Forms.TextBox Cautareclient;
        private System.Windows.Forms.Button Cauta;
        private System.Windows.Forms.Label Datalbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Back;
    }
}