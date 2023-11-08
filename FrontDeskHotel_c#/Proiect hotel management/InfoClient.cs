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
    public partial class InfoClient : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\bd Hotel\Hotelbd.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Act = "select * from Client_tabel";
            SqlDataAdapter da = new SqlDataAdapter(Act, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var datas = new DataSet();
            da.Fill(datas);
            Listaclient.DataSource = datas.Tables[0];
            Con.Close();
            
        }
        public InfoClient()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datalbl.Text = DateTime.Now.ToString();
        }

        private void InfoClient_Load(object sender, EventArgs e)
        {
            Datalbl.Text = DateTime.Now.ToString();
            timer1.Start();
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmnd = new SqlCommand("insert into Client_tabel values("+CNPclient.Text+ ",'" + Numeclient.Text + "','" + Telefonclient.Text + "', '" + Taraclient.SelectedItem.ToString() + "')", Con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Client Adaugat!");
            Con.Close();
            populate();
        }

        private void Listaclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                CNPclient.Text = Listaclient.Rows[e.RowIndex].Cells[0].Value.ToString();
                Numeclient.Text = Listaclient.Rows[e.RowIndex].Cells[1].Value.ToString();
                Telefonclient.Text = Listaclient.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void Editeaza_Click(object sender, EventArgs e)
        {
            Con.Open();
            string edit = "UPDATE Client_tabel set Nume ='" + Numeclient.Text + "',Telefon ='" + Telefonclient.Text + "',Tara='" + Taraclient.SelectedItem.ToString() + "' where CNP = " + CNPclient.Text + ";";
            SqlCommand cnmd = new SqlCommand(edit, Con);
            cnmd.ExecuteNonQuery();
            MessageBox.Show("Client Editat!");
            Con.Close();
            populate();
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            Con.Open();
            string sterge = "delete from Client_tabel where CNP = "+CNPclient.Text+ "";
            SqlCommand cmnd = new SqlCommand(sterge, Con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Client Sters!");
            Con.Close();
            populate();
        }

        private void Cauta_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Act = "select * from Client_tabel where Nume = '"+Cautareclient.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(Act, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var datas = new DataSet();
            da.Fill(datas);
            Listaclient.DataSource = datas.Tables[0];
            Con.Close();
        }

        private void Cautareclient_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Datalbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormPrinc f1 = new FormPrinc();
            f1.ShowDialog();
            this.Hide();

        }
    }
}
