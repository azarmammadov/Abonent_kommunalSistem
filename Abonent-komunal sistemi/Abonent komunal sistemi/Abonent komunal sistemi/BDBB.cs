using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Abonent_komunal_sistemi
{
    public partial class BDBB : Form
    {
        public BDBB()
        {
            InitializeComponent();
        }
        private void BDBB_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dataBase = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True";

            SqlConnection isci = new SqlConnection(dataBase);
            isci.Open();
            SqlCommand iscimgosterilmesi = new SqlCommand("Select * from İsciQeydiyyati", isci);

            SqlDataAdapter iscida = new SqlDataAdapter(iscimgosterilmesi);
            DataTable cedvel = new DataTable();
            iscida.Fill(cedvel);
            dataGridView1.DataSource = cedvel;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dataBase = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True";

            SqlConnection abonentkom = new SqlConnection(dataBase);
            abonentkom.Open();
            SqlCommand abonentmgosterilmesi = new SqlCommand("Select * from Abonent_kommunal", abonentkom);

            SqlDataAdapter abonentda = new SqlDataAdapter(abonentmgosterilmesi);
            DataTable cedvel = new DataTable();
            abonentda.Fill(cedvel);
            dataGridView1.DataSource = cedvel;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string dataBase = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True";

            SqlConnection odenis = new SqlConnection(dataBase);
            odenis.Open();
            SqlCommand odenismgosterilmesi = new SqlCommand("Select * from Odenisler", odenis);

            SqlDataAdapter odenisda = new SqlDataAdapter(odenismgosterilmesi);
            DataTable cedvel = new DataTable();
            odenisda.Fill(cedvel);
            dataGridView1.DataSource = cedvel;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isciqeydeyisiklik iscqeyd = new isciqeydeyisiklik();

            iscqeyd.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isciqeydiy isciqey = new isciqeydiy();

            isciqey.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();

            giris.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abonent_kommunal abonentkom = new Abonent_kommunal();

            abonentkom.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abonent_qeydiyyati abonent_ = new Abonent_qeydiyyati();

            abonent_.Show();

            this.Hide();
        }
    }
}
