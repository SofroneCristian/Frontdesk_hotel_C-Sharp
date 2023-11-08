
namespace Proiect_hotel_management
{
    partial class InfoAngajati
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
            this.Datalbl1 = new System.Windows.Forms.Label();
            this.Telefonangajat = new System.Windows.Forms.TextBox();
            this.Numeangajat = new System.Windows.Forms.TextBox();
            this.Idangajat = new System.Windows.Forms.TextBox();
            this.Sexangajat = new System.Windows.Forms.ComboBox();
            this.Editeazaa = new System.Windows.Forms.Button();
            this.Stergee = new System.Windows.Forms.Button();
            this.Adaugaa = new System.Windows.Forms.Button();
            this.Listaangajat = new System.Windows.Forms.DataGridView();
            this.Cautareangajat = new System.Windows.Forms.TextBox();
            this.Cautaa = new System.Windows.Forms.Button();
            this.Reseta = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Parolaangajat = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Listaangajat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informatii Angajati";
            // 
            // Datalbl1
            // 
            this.Datalbl1.AutoSize = true;
            this.Datalbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datalbl1.Location = new System.Drawing.Point(713, 22);
            this.Datalbl1.Name = "Datalbl1";
            this.Datalbl1.Size = new System.Drawing.Size(51, 24);
            this.Datalbl1.TabIndex = 13;
            this.Datalbl1.Text = "Data\r\n";
            this.Datalbl1.Click += new System.EventHandler(this.Datalbl1_Click);
            // 
            // Telefonangajat
            // 
            this.Telefonangajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonangajat.Location = new System.Drawing.Point(26, 144);
            this.Telefonangajat.Name = "Telefonangajat";
            this.Telefonangajat.Size = new System.Drawing.Size(244, 29);
            this.Telefonangajat.TabIndex = 16;
            this.Telefonangajat.Text = "Nr de telefon al angajatului";
            // 
            // Numeangajat
            // 
            this.Numeangajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeangajat.Location = new System.Drawing.Point(26, 99);
            this.Numeangajat.Name = "Numeangajat";
            this.Numeangajat.Size = new System.Drawing.Size(175, 29);
            this.Numeangajat.TabIndex = 15;
            this.Numeangajat.Text = "Numele angajatului";
            // 
            // Idangajat
            // 
            this.Idangajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idangajat.Location = new System.Drawing.Point(26, 51);
            this.Idangajat.Name = "Idangajat";
            this.Idangajat.Size = new System.Drawing.Size(175, 29);
            this.Idangajat.TabIndex = 14;
            this.Idangajat.Text = "Id-ul angajatului";
            this.Idangajat.TextChanged += new System.EventHandler(this.Idangajat_TextChanged);
            // 
            // Sexangajat
            // 
            this.Sexangajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexangajat.FormattingEnabled = true;
            this.Sexangajat.Items.AddRange(new object[] {
            "Barbat",
            "Femeie",
            "Altele"});
            this.Sexangajat.Location = new System.Drawing.Point(26, 189);
            this.Sexangajat.Name = "Sexangajat";
            this.Sexangajat.Size = new System.Drawing.Size(216, 32);
            this.Sexangajat.TabIndex = 19;
            this.Sexangajat.Text = "Sex-ul angajatului";
            // 
            // Editeazaa
            // 
            this.Editeazaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeazaa.Location = new System.Drawing.Point(108, 311);
            this.Editeazaa.Name = "Editeazaa";
            this.Editeazaa.Size = new System.Drawing.Size(75, 32);
            this.Editeazaa.TabIndex = 22;
            this.Editeazaa.Text = "Editeaza";
            this.Editeazaa.UseVisualStyleBackColor = true;
            this.Editeazaa.Click += new System.EventHandler(this.Editeazaa_Click);
            // 
            // Stergee
            // 
            this.Stergee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stergee.Location = new System.Drawing.Point(204, 311);
            this.Stergee.Name = "Stergee";
            this.Stergee.Size = new System.Drawing.Size(62, 32);
            this.Stergee.TabIndex = 21;
            this.Stergee.Text = "Sterge";
            this.Stergee.UseVisualStyleBackColor = true;
            this.Stergee.Click += new System.EventHandler(this.Stergee_Click);
            // 
            // Adaugaa
            // 
            this.Adaugaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaugaa.Location = new System.Drawing.Point(26, 311);
            this.Adaugaa.Name = "Adaugaa";
            this.Adaugaa.Size = new System.Drawing.Size(62, 32);
            this.Adaugaa.TabIndex = 20;
            this.Adaugaa.Text = "Adauga";
            this.Adaugaa.UseVisualStyleBackColor = true;
            this.Adaugaa.Click += new System.EventHandler(this.Adaugaa_Click);
            // 
            // Listaangajat
            // 
            this.Listaangajat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listaangajat.Location = new System.Drawing.Point(422, 99);
            this.Listaangajat.Name = "Listaangajat";
            this.Listaangajat.Size = new System.Drawing.Size(382, 347);
            this.Listaangajat.TabIndex = 23;
            this.Listaangajat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listaangajat_CellContentClick);
            // 
            // Cautareangajat
            // 
            this.Cautareangajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautareangajat.Location = new System.Drawing.Point(453, 66);
            this.Cautareangajat.Name = "Cautareangajat";
            this.Cautareangajat.Size = new System.Drawing.Size(175, 29);
            this.Cautareangajat.TabIndex = 24;
            this.Cautareangajat.Text = "Numele angajat";
            this.Cautareangajat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cautareangajat.TextChanged += new System.EventHandler(this.Cautareangajat_TextChanged);
            // 
            // Cautaa
            // 
            this.Cautaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautaa.Location = new System.Drawing.Point(624, 66);
            this.Cautaa.Name = "Cautaa";
            this.Cautaa.Size = new System.Drawing.Size(62, 29);
            this.Cautaa.TabIndex = 25;
            this.Cautaa.Text = "Cauta";
            this.Cautaa.UseVisualStyleBackColor = true;
            this.Cautaa.Click += new System.EventHandler(this.Cautaa_Click);
            // 
            // Reseta
            // 
            this.Reseta.Location = new System.Drawing.Point(683, 73);
            this.Reseta.Name = "Reseta";
            this.Reseta.Size = new System.Drawing.Size(53, 20);
            this.Reseta.TabIndex = 26;
            this.Reseta.Text = "Reset";
            this.Reseta.UseVisualStyleBackColor = true;
            this.Reseta.Click += new System.EventHandler(this.Reseta_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Parolaangajat
            // 
            this.Parolaangajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parolaangajat.Location = new System.Drawing.Point(26, 247);
            this.Parolaangajat.Name = "Parolaangajat";
            this.Parolaangajat.Size = new System.Drawing.Size(244, 29);
            this.Parolaangajat.TabIndex = 27;
            this.Parolaangajat.Text = "Parola angajatului";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(26, 419);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(62, 27);
            this.Back.TabIndex = 28;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // InfoAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Parolaangajat);
            this.Controls.Add(this.Reseta);
            this.Controls.Add(this.Cautaa);
            this.Controls.Add(this.Cautareangajat);
            this.Controls.Add(this.Listaangajat);
            this.Controls.Add(this.Editeazaa);
            this.Controls.Add(this.Stergee);
            this.Controls.Add(this.Adaugaa);
            this.Controls.Add(this.Sexangajat);
            this.Controls.Add(this.Telefonangajat);
            this.Controls.Add(this.Numeangajat);
            this.Controls.Add(this.Idangajat);
            this.Controls.Add(this.Datalbl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoAngajati";
            this.Text = "InfoAngajati";
            this.Load += new System.EventHandler(this.InfoAngajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listaangajat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datalbl1;
        private System.Windows.Forms.TextBox Telefonangajat;
        private System.Windows.Forms.TextBox Numeangajat;
        private System.Windows.Forms.TextBox Idangajat;
        private System.Windows.Forms.ComboBox Sexangajat;
        private System.Windows.Forms.Button Editeazaa;
        private System.Windows.Forms.Button Stergee;
        private System.Windows.Forms.Button Adaugaa;
        private System.Windows.Forms.DataGridView Listaangajat;
        private System.Windows.Forms.TextBox Cautareangajat;
        private System.Windows.Forms.Button Cautaa;
        private System.Windows.Forms.Button Reseta;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox Parolaangajat;
        private System.Windows.Forms.Button Back;
    }
}