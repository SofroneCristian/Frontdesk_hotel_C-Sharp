using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_hotel_management
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\bd Hotel\Hotelbd.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Angajat_tabel where Nume_angajat='"+usernametb.Text+"' and Password_angajat = '"+passwordtb.Text+"' ",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                FormPrinc fp = new FormPrinc();
                fp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username sau Password gresit!");
            }
            Con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
