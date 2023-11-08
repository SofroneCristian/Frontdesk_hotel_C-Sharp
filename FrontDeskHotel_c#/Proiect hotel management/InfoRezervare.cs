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
    public partial class InfoRezervare : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\bd Hotel\Hotelbd.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Act = "select * from Rezervare_tabel";
            SqlDataAdapter da = new SqlDataAdapter(Act, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var datas = new DataSet();
            da.Fill(datas);
            Listarezervare.DataSource = datas.Tables[0];
            Con.Close();

        }
        public void UmplereCamere()
        {
            Con.Open();
            string statuscam = "Libera";
            SqlCommand cnmd = new SqlCommand("select ID_cam from Camera_tabel where Libera_cam = '"+statuscam+"'",Con);
            SqlDataReader rd;
            rd = cnmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_cam", typeof(int));
            dt.Load(rd);
            Numarcamr.ValueMember = "ID_cam";
            Numarcamr.DataSource = dt;

            Con.Close();
        }
        public void UmplereClienti()
        {
            Con.Open();
            SqlCommand cnmd = new SqlCommand("select Nume from Client_tabel", Con);
            SqlDataReader rd;
            rd = cnmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nume", typeof(string));
            dt.Load(rd);
            Numeclientr.ValueMember = "Nume";
            Numeclientr.DataSource = dt;

            Con.Close();
        }
        public InfoRezervare()
        {
            InitializeComponent();
        }
        DateTime today;

        private void InfoRezervare_Load(object sender, EventArgs e)
        {
            today = Datackin.Value;
            UmplereCamere();
            UmplereClienti();
            populate();
            
        }

        private void Datackin_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Datackin.Value, today);
            if (res < 0)
                MessageBox.Show("Data check-in gresita!");
        }

        private void Datackout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Datackout.Value, Datackin.Value);
            if (res < 0)
                MessageBox.Show("Data check-out gresita, verificati inca o data!");
        }
        public void updatestatuscam()
        {
            Con.Open();
            string statusnou = "busy";
            string edit = "UPDATE Camera_tabel set Libera_cam ='" + statusnou + "' where ID_cam = " +Convert.ToInt32(Numarcamr.SelectedValue.ToString()) + ";";
            SqlCommand cnmd = new SqlCommand(edit, Con);
            cnmd.ExecuteNonQuery();
            //MessageBox.Show("Rezervare Editata!");
            Con.Close();
            UmplereCamere();
        }
        
        private void Adaugar_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmnd = new SqlCommand("insert into Rezervare_tabel values(" + IDrez.Text + ",'" + Numeclientr.SelectedValue.ToString() + "','" + Numarcamr.SelectedValue.ToString() + "' , '" + Datackin.Value + "','" + Datackout.Value + "')", Con); ;
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Rezervare Adaugata!");
            Con.Close();
            updatestatuscam();
            populate();
            
        }

        private void Listarezervare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDrez.Text = Listarezervare.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void Sterger_Click(object sender, EventArgs e)
        {   if(IDrez.Text == "")
            {
                MessageBox.Show("Id rezervare gresit");
            }
            else
            {

            }
            Con.Open();
            string sterge = "delete from Rezervare_tabel where ID_rez = " + IDrez.Text + "";
            SqlCommand cmnd = new SqlCommand(sterge, Con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Rezervare Stersa!");
            Con.Close();
            populate();
        }

        private void Editeazar_Click(object sender, EventArgs e)
        {
            if (IDrez.Text == "")
            {
                MessageBox.Show("Id rezervare gresit!");
            }
            else
            {


                Con.Open();
                string edit = "UPDATE Rezervare_tabel set Client ='" + Numeclientr.SelectedValue.ToString() + "',Camera='" + Numarcamr.SelectedValue.ToString() + "' ,Datain ='" + Datackin.Value.ToString() + "' ,Dataout ='" + Datackout.Value.ToString() + "' where ID_rez = " + IDrez.Text + ";";
                SqlCommand cnmd = new SqlCommand(edit, Con);
                cnmd.ExecuteNonQuery();
                MessageBox.Show("Rezervare Editata!");
                Con.Close();
                populate();
            }
        }

        private void Cautar_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Act = "select * from Rezervare_tabel where ID_rez = '" + Cautarer.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Act, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var datas = new DataSet();
            da.Fill(datas);
            Listarezervare.DataSource = datas.Tables[0];
            Con.Close();
        }

        private void Resetr_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormPrinc f1 = new FormPrinc();
            f1.ShowDialog();
            this.Hide();
        }
    }
}
