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
    public partial class InfoCamere : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\bd Hotel\Hotelbd.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Act = "select * from Camera_tabel";
            SqlDataAdapter da = new SqlDataAdapter(Act, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var datas = new DataSet();
            da.Fill(datas);
            Listacamera.DataSource = datas.Tables[0];
            Con.Close();

        }
        public InfoCamere()
        {
            InitializeComponent();
        }
        

        private void Adaugac_Click(object sender, EventArgs e)
        {
            string elib;
            if (Yes.Checked == true)
                elib = "Libera";
            else
                elib = "Ocupata";

            Con.Open();
            SqlCommand cmnd = new SqlCommand("insert into Camera_tabel values(" + Numarcam.Text + ",'" + Telefoncam.Text + "','" + elib + "')", Con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Camera Adaugata!");
            Con.Close();
            populate();
        }

        private void InfoCamere_Load(object sender, EventArgs e)
        {
            Datalbl2.Text = DateTime.Now.ToString();
            timer2.Start();
            populate();
        }

        private void Listacamera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Numarcam.Text = Listacamera.Rows[e.RowIndex].Cells[0].Value.ToString();
            Telefoncam.Text = Listacamera.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void Stergec_Click(object sender, EventArgs e)
        {
            Con.Open();
            string sterge = "delete from Camera_tabel where ID_cam = " + Numarcam.Text + "";
            SqlCommand cmnd = new SqlCommand(sterge, Con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Camera Stersa!");
            Con.Close();
            populate();
        }

        private void Editeazac_Click(object sender, EventArgs e)
        {
            string elib;
            if (Yes.Checked == true)
                elib = "Libera";
            else
                elib = "Ocupata";

            Con.Open();
            string edit = "UPDATE Camera_tabel set ID_cam ='" + Numarcam.Text + "',Telefon_cam ='" + Telefoncam.Text + "',Libera_cam='" + elib + "' where ID_cam = " + Numarcam.Text + ";";
            SqlCommand cnmd = new SqlCommand(edit, Con);
            cnmd.ExecuteNonQuery();
            MessageBox.Show("Camera Editata!");
            Con.Close();
            populate();
        }

        private void Cautac_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Act = "select * from Camera_tabel where ID_cam = '" + Cautarecam.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Act, Con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var datas = new DataSet();
            da.Fill(datas);
            Listacamera.DataSource = datas.Tables[0];
            Con.Close();
        }

        private void Resetc_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Datalbl2.Text = DateTime.Now.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            FormPrinc f1 = new FormPrinc();
            f1.ShowDialog();
            this.Hide();
        }
    }
}
