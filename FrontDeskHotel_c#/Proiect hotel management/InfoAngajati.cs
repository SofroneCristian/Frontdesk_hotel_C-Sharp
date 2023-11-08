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
    public partial class InfoAngajati : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\bd Hotel\Hotelbd.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Act = "select * from Angajat_tabel";
            SqlDataAdapter da = new SqlDataAdapter(Act, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var datas = new DataSet();
            da.Fill(datas);
            Listaangajat.DataSource = datas.Tables[0];
            Con.Close();

        }
        public InfoAngajati()
        {
            InitializeComponent();
        }

        private void InfoAngajati_Load(object sender, EventArgs e)
        {
            Datalbl1.Text = DateTime.Now.ToString();
            timer2.Start();
            populate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datalbl1.Text = DateTime.Now.ToString();
        }
        private void InfoAngajat_Load(object sender, EventArgs e)
        {
            Datalbl1.Text = DateTime.Now.ToString();
            timer2.Start();
            populate();
        }

        private void Idangajat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Adaugaa_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmnd = new SqlCommand("insert into Angajat_tabel values(" + Idangajat.Text + ",'" + Numeangajat.Text + "','" + Telefonangajat.Text + "', '" + Sexangajat.SelectedItem.ToString() + "','"+Parolaangajat.Text+"')", Con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Angajat Adaugat!");
            Con.Close();
            populate();
        }

        private void Editeazaa_Click(object sender, EventArgs e)
        {
            Con.Open();
            string edit = "UPDATE Angajat_tabel set Nume_angajat ='" + Numeangajat.Text + "',Telefon_angajat ='" + Telefonangajat.Text + "',Sex_angajat='" + Sexangajat.SelectedItem.ToString() + "' ,Password_angajat ='" + Parolaangajat.Text + "' where ID_angajat = " + Idangajat.Text + ";";
            SqlCommand cnmd = new SqlCommand(edit, Con);
            cnmd.ExecuteNonQuery();
            MessageBox.Show("Angajat Editat!");
            Con.Close();
            populate();
        }

        private void Listaangajat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Idangajat.Text = Listaangajat.Rows[e.RowIndex].Cells[0].Value.ToString();
            Numeangajat.Text = Listaangajat.Rows[e.RowIndex].Cells[1].Value.ToString();
            Telefonangajat.Text = Listaangajat.Rows[e.RowIndex].Cells[2].Value.ToString();
            Parolaangajat.Text = Listaangajat.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Stergee_Click(object sender, EventArgs e)
        {
            Con.Open();
            string sterge = "delete from Angajat_tabel where ID_angajat = " + Idangajat.Text + "";
            SqlCommand cmnd = new SqlCommand(sterge, Con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Angajat Sters!");
            Con.Close();
            populate();
        }

        private void Cautareangajat_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cautaa_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Act = "select * from Angajat_tabel where Nume_angajat = '" + Cautareangajat.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Act, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var datas = new DataSet();
            da.Fill(datas);
            Listaangajat.DataSource = datas.Tables[0];
            Con.Close();
        }

        private void Reseta_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Datalbl1_Click(object sender, EventArgs e)
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
