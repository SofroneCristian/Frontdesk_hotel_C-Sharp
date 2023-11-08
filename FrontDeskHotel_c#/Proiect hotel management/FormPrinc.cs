using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_hotel_management
{
    public partial class FormPrinc : Form
    {
        public FormPrinc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            InfoAngajati aninf = new InfoAngajati();
            aninf.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoClient clinf = new InfoClient();
            clinf.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            InfoClient clinf = new InfoClient();
            clinf.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            InfoCamere cminf = new InfoCamere();
            cminf.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            InfoRezervare rezinf = new InfoRezervare();
            rezinf.Show();
            this.Hide();
        }
    }
}
