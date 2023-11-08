
namespace Proiect_hotel_management
{
    partial class InfoCamere
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
            this.Datalbl2 = new System.Windows.Forms.Label();
            this.Cautarecam = new System.Windows.Forms.TextBox();
            this.Cautac = new System.Windows.Forms.Button();
            this.Resetc = new System.Windows.Forms.Button();
            this.Telefoncam = new System.Windows.Forms.TextBox();
            this.Numarcam = new System.Windows.Forms.TextBox();
            this.Listacamera = new System.Windows.Forms.DataGridView();
            this.Liberacam = new System.Windows.Forms.Label();
            this.Yes = new System.Windows.Forms.RadioButton();
            this.No = new System.Windows.Forms.RadioButton();
            this.Editeazac = new System.Windows.Forms.Button();
            this.Stergec = new System.Windows.Forms.Button();
            this.Adaugac = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Listacamera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informatii Camera\r\n";
            // 
            // Datalbl2
            // 
            this.Datalbl2.AutoSize = true;
            this.Datalbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datalbl2.Location = new System.Drawing.Point(599, 22);
            this.Datalbl2.Name = "Datalbl2";
            this.Datalbl2.Size = new System.Drawing.Size(51, 24);
            this.Datalbl2.TabIndex = 13;
            this.Datalbl2.Text = "Data\r\n";
            // 
            // Cautarecam
            // 
            this.Cautarecam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautarecam.Location = new System.Drawing.Point(393, 66);
            this.Cautarecam.Name = "Cautarecam";
            this.Cautarecam.Size = new System.Drawing.Size(175, 29);
            this.Cautarecam.TabIndex = 14;
            this.Cautarecam.Text = "Numarul camerei";
            this.Cautarecam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cautac
            // 
            this.Cautac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cautac.Location = new System.Drawing.Point(565, 66);
            this.Cautac.Name = "Cautac";
            this.Cautac.Size = new System.Drawing.Size(62, 29);
            this.Cautac.TabIndex = 15;
            this.Cautac.Text = "Cauta";
            this.Cautac.UseVisualStyleBackColor = true;
            this.Cautac.Click += new System.EventHandler(this.Cautac_Click);
            // 
            // Resetc
            // 
            this.Resetc.Location = new System.Drawing.Point(625, 71);
            this.Resetc.Name = "Resetc";
            this.Resetc.Size = new System.Drawing.Size(53, 20);
            this.Resetc.TabIndex = 16;
            this.Resetc.Text = "Reset";
            this.Resetc.UseVisualStyleBackColor = true;
            this.Resetc.Click += new System.EventHandler(this.Resetc_Click);
            // 
            // Telefoncam
            // 
            this.Telefoncam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefoncam.Location = new System.Drawing.Point(33, 146);
            this.Telefoncam.Name = "Telefoncam";
            this.Telefoncam.Size = new System.Drawing.Size(175, 29);
            this.Telefoncam.TabIndex = 18;
            this.Telefoncam.Text = "Telefon camera\r\n";
            // 
            // Numarcam
            // 
            this.Numarcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numarcam.Location = new System.Drawing.Point(33, 101);
            this.Numarcam.Name = "Numarcam";
            this.Numarcam.Size = new System.Drawing.Size(175, 29);
            this.Numarcam.TabIndex = 17;
            this.Numarcam.Text = "Numarul camerei";
            // 
            // Listacamera
            // 
            this.Listacamera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listacamera.Location = new System.Drawing.Point(366, 91);
            this.Listacamera.Name = "Listacamera";
            this.Listacamera.Size = new System.Drawing.Size(382, 347);
            this.Listacamera.TabIndex = 19;
            this.Listacamera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listacamera_CellContentClick);
            // 
            // Liberacam
            // 
            this.Liberacam.AutoSize = true;
            this.Liberacam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liberacam.Location = new System.Drawing.Point(29, 208);
            this.Liberacam.Name = "Liberacam";
            this.Liberacam.Size = new System.Drawing.Size(79, 24);
            this.Liberacam.TabIndex = 20;
            this.Liberacam.Text = "Libera?";
            // 
            // Yes
            // 
            this.Yes.AutoSize = true;
            this.Yes.Location = new System.Drawing.Point(114, 214);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(43, 17);
            this.Yes.TabIndex = 22;
            this.Yes.TabStop = true;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            this.No.AutoSize = true;
            this.No.Location = new System.Drawing.Point(182, 214);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(39, 17);
            this.No.TabIndex = 23;
            this.No.TabStop = true;
            this.No.Text = "No\r\n";
            this.No.UseVisualStyleBackColor = true;
            // 
            // Editeazac
            // 
            this.Editeazac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeazac.Location = new System.Drawing.Point(114, 281);
            this.Editeazac.Name = "Editeazac";
            this.Editeazac.Size = new System.Drawing.Size(75, 32);
            this.Editeazac.TabIndex = 26;
            this.Editeazac.Text = "Editeaza";
            this.Editeazac.UseVisualStyleBackColor = true;
            this.Editeazac.Click += new System.EventHandler(this.Editeazac_Click);
            // 
            // Stergec
            // 
            this.Stergec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stergec.Location = new System.Drawing.Point(210, 281);
            this.Stergec.Name = "Stergec";
            this.Stergec.Size = new System.Drawing.Size(62, 32);
            this.Stergec.TabIndex = 25;
            this.Stergec.Text = "Sterge";
            this.Stergec.UseVisualStyleBackColor = true;
            this.Stergec.Click += new System.EventHandler(this.Stergec_Click);
            // 
            // Adaugac
            // 
            this.Adaugac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaugac.Location = new System.Drawing.Point(32, 281);
            this.Adaugac.Name = "Adaugac";
            this.Adaugac.Size = new System.Drawing.Size(62, 32);
            this.Adaugac.TabIndex = 24;
            this.Adaugac.Text = "Adauga";
            this.Adaugac.UseVisualStyleBackColor = true;
            this.Adaugac.Click += new System.EventHandler(this.Adaugac_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(32, 397);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(62, 27);
            this.Back.TabIndex = 35;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // InfoCamere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Editeazac);
            this.Controls.Add(this.Stergec);
            this.Controls.Add(this.Adaugac);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.Liberacam);
            this.Controls.Add(this.Listacamera);
            this.Controls.Add(this.Telefoncam);
            this.Controls.Add(this.Numarcam);
            this.Controls.Add(this.Resetc);
            this.Controls.Add(this.Cautac);
            this.Controls.Add(this.Cautarecam);
            this.Controls.Add(this.Datalbl2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoCamere";
            this.Text = "InfoCamere";
            this.Load += new System.EventHandler(this.InfoCamere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listacamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Datalbl2;
        private System.Windows.Forms.TextBox Cautarecam;
        private System.Windows.Forms.Button Cautac;
        private System.Windows.Forms.Button Resetc;
        private System.Windows.Forms.TextBox Telefoncam;
        private System.Windows.Forms.TextBox Numarcam;
        private System.Windows.Forms.DataGridView Listacamera;
        private System.Windows.Forms.Label Liberacam;
        private System.Windows.Forms.RadioButton Yes;
        private System.Windows.Forms.RadioButton No;
        private System.Windows.Forms.Button Editeazac;
        private System.Windows.Forms.Button Stergec;
        private System.Windows.Forms.Button Adaugac;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Back;
    }
}