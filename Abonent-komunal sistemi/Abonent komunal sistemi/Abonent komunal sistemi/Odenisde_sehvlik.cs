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
    public partial class Odenisde_sehvlik : Form
    {
        public Odenisde_sehvlik()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abonent_kommunal abk = new Abonent_kommunal();
            abk.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (ABK.Text != "" && ODM.Text != "" && EMLAPSHAD.Text != "" && EMLAPSHSOYAD.Text != "")
            {
                SqlConnection d_etme = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                d_etme.Open();
                SqlCommand abonentkomdax = new SqlCommand("Update Odenisler set Abonent_kodu=(N'" + ABK.Text + "'), Ödəyəcəyi_məbləğ = (N'" + ODM.Text + "'), Ödənilən_tarix= ('" + DateTime.Parse(ODT.Text) + "'), Əməliyyatı_aparanın_adı= (N'" + EMLAPSHAD.Text + "'), Əməliyyatı_aparanın_soyadı= (N'" + EMLAPSHSOYAD.Text + "')where Ödəmə_sırası=('" + o_s.Text + "'))", d_etme);

                abonentkomdax.ExecuteNonQuery();
                d_etme.Close();
                MessageBox.Show("Daxil edildi.", "Qeyd olundu", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("Daxil etmə mümkün deyil.", "Qeyd olunmadı", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (o_s.Text != "")
            {
                SqlConnection odemesirasindagoresil = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                odemesirasindagoresil.Open();
                SqlCommand odemesirasindagorsil = new SqlCommand(" Delete Odenisler where Ödəmə_sırası=('"+ o_s.Text + "') ", odemesirasindagoresil);
                
                odemesirasindagorsil.ExecuteNonQuery();
                odemesirasindagoresil.Close();
                MessageBox.Show("Silinmə əməlliyatı icra edildi.", "SİLMƏ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ödəniş sırasını yazın.", "Silinmədi", MessageBoxButtons.OK);
            }
        }

        private void Odenisde_sehvlik_Load(object sender, EventArgs e)
        {

        }

        private void o_s_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 abk = new Form1();
            abk.Show();
            this.Hide();
        }
    }
}
