
namespace Proiect_hotel_management
{
    partial class InfoRezervare
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
            this.Datalbl3 = new System.Windows.Forms.Label();
            this.Cautarer = new System.Windows.Forms.TextBox();
            this.Cautar = new System.Windows.Forms.Button();
            this.Resetr = new System.Windows.Forms.Button();
            this.Listarezervare = new System.Windows.Forms.DataGridView();
            this.IDrez = new System.Windows.Forms.TextBox();
            this.Datackin = new System.Windows.Forms.DateTimePicker();
            this.Datackout = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Editeazar = new System.Windows.Forms.Button();
            this.Sterger = new System.Windows.Forms.Button();
            this.Adaugar = new System.Windows.Forms.Button();
            this.Numeclientr = new System.Windows.Forms.ComboBox();
            this.Numarcamr = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Listarezervare)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informatii Rezervare\r\n";
            // 
            // Datalbl3
            // 
            this.Datalbl3.AutoSize = true;
            this.Datalbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datalbl3.Location = new System.Drawing.Point(598, 19);
            this.Datalbl3.Name = "Datalbl3";
            this.Datalbl3.Size = new System.Drawing.Size(51, 24);
            this.Datalbl3.TabIndex = 13;
            this.Datalbl3.Text = "Data\r\n";
            // 
            // Cautarer
            // 
            this.Cautarer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautarer.Location = new System.Drawing.Point(430, 60);
            this.Cautarer.Name = "Cautarer";
            this.Cautarer.Size = new System.Drawing.Size(175, 29);
            this.Cautarer.TabIndex = 14;
            this.Cautarer.Text = "Numarul rezervarii\r\n";
            this.Cautarer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cautar
            // 
            this.Cautar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautar.Location = new System.Drawing.Point(602, 62);
            this.Cautar.Name = "Cautar";
            this.Cautar.Size = new System.Drawing.Size(62, 29);
            this.Cautar.TabIndex = 15;
            this.Cautar.Text = "Cauta";
            this.Cautar.UseVisualStyleBackColor = true;
            this.Cautar.Click += new System.EventHandler(this.Cautar_Click);
            // 
            // Resetr
            // 
            this.Resetr.Location = new System.Drawing.Point(670, 69);
            this.Resetr.Name = "Resetr";
            this.Resetr.Size = new System.Drawing.Size(53, 20);
            this.Resetr.TabIndex = 16;
            this.Resetr.Text = "Reset";
            this.Resetr.UseVisualStyleBackColor = true;
            this.Resetr.Click += new System.EventHandler(this.Resetr_Click);
            // 
            // Listarezervare
            // 
            this.Listarezervare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listarezervare.Location = new System.Drawing.Point(280, 91);
            this.Listarezervare.Name = "Listarezervare";
            this.Listarezervare.Size = new System.Drawing.Size(431, 347);
            this.Listarezervare.TabIndex = 17;
            this.Listarezervare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listarezervare_CellContentClick);
            // 
            // IDrez
            // 
            this.IDrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDrez.Location = new System.Drawing.Point(12, 91);
            this.IDrez.Name = "IDrez";
            this.IDrez.Size = new System.Drawing.Size(175, 29);
            this.IDrez.TabIndex = 18;
            this.IDrez.Text = "ID-ul rezervarii\r\n";
            // 
            // Datackin
            // 
            this.Datackin.Location = new System.Drawing.Point(82, 257);
            this.Datackin.Name = "Datackin";
            this.Datackin.Size = new System.Drawing.Size(105, 20);
            this.Datackin.TabIndex = 22;
            this.Datackin.ValueChanged += new System.EventHandler(this.Datackin_ValueChanged);
            // 
            // Datackout
            // 
            this.Datackout.Location = new System.Drawing.Point(81, 306);
            this.Datackout.Name = "Datackout";
            this.Datackout.Size = new System.Drawing.Size(106, 20);
            this.Datackout.TabIndex = 23;
            this.Datackout.ValueChanged += new System.EventHandler(this.Datackout_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Data\r\nIn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Data\r\n out";
            // 
            // Editeazar
            // 
            this.Editeazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeazar.Location = new System.Drawing.Point(92, 371);
            this.Editeazar.Name = "Editeazar";
            this.Editeazar.Size = new System.Drawing.Size(75, 32);
            this.Editeazar.TabIndex = 29;
            this.Editeazar.Text = "Editeaza";
            this.Editeazar.UseVisualStyleBackColor = true;
            this.Editeazar.Click += new System.EventHandler(this.Editeazar_Click);
            // 
            // Sterger
            // 
            this.Sterger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sterger.Location = new System.Drawing.Point(188, 371);
            this.Sterger.Name = "Sterger";
            this.Sterger.Size = new System.Drawing.Size(62, 32);
            this.Sterger.TabIndex = 28;
            this.Sterger.Text = "Sterge";
            this.Sterger.UseVisualStyleBackColor = true;
            this.Sterger.Click += new System.EventHandler(this.Sterger_Click);
            // 
            // Adaugar
            // 
            this.Adaugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaugar.Location = new System.Drawing.Point(10, 371);
            this.Adaugar.Name = "Adaugar";
            this.Adaugar.Size = new System.Drawing.Size(62, 32);
            this.Adaugar.TabIndex = 27;
            this.Adaugar.Text = "Adauga";
            this.Adaugar.UseVisualStyleBackColor = true;
            this.Adaugar.Click += new System.EventHandler(this.Adaugar_Click);
            // 
            // Numeclientr
            // 
            this.Numeclientr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeclientr.FormattingEnabled = true;
            this.Numeclientr.Location = new System.Drawing.Point(82, 135);
            this.Numeclientr.Name = "Numeclientr";
            this.Numeclientr.Size = new System.Drawing.Size(175, 32);
            this.Numeclientr.TabIndex = 30;
            this.Numeclientr.Text = "Numele clientului";
            // 
            // Numarcamr
            // 
            this.Numarcamr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numarcamr.FormattingEnabled = true;
            this.Numarcamr.Location = new System.Drawing.Point(82, 183);
            this.Numarcamr.Name = "Numarcamr";
            this.Numarcamr.Size = new System.Drawing.Size(175, 32);
            this.Numarcamr.TabIndex = 31;
            this.Numarcamr.Text = "Numarul camerei";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Camera";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Client";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(10, 420);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(62, 27);
            this.Back.TabIndex = 34;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // InfoRezervare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Numarcamr);
            this.Controls.Add(this.Numeclientr);
            this.Controls.Add(this.Editeazar);
            this.Controls.Add(this.Sterger);
            this.Controls.Add(this.Adaugar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datackout);
            this.Controls.Add(this.Datackin);
            this.Controls.Add(this.IDrez);
            this.Controls.Add(this.Listarezervare);
            this.Controls.Add(this.Resetr);
            this.Controls.Add(this.Cautar);
            this.Controls.Add(this.Cautarer);
            this.Controls.Add(this.Datalbl3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoRezervare";
            this.Text = "InfoRezervare";
            this.Load += new System.EventHandler(this.InfoRezervare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listarezervare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datalbl3;
        private System.Windows.Forms.TextBox Cautarer;
        private System.Windows.Forms.Button Cautar;
        private System.Windows.Forms.Button Resetr;
        private System.Windows.Forms.DataGridView Listarezervare;
        private System.Windows.Forms.TextBox IDrez;
        private System.Windows.Forms.DateTimePicker Datackin;
        private System.Windows.Forms.DateTimePicker Datackout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button Editeazar;
        private System.Windows.Forms.Button Sterger;
        private System.Windows.Forms.Button Adaugar;
        private System.Windows.Forms.ComboBox Numeclientr;
        private System.Windows.Forms.ComboBox Numarcamr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Back;
    }
}