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
    public partial class Qeydiyyatda_sehvlik : Form
    {
        public Qeydiyyatda_sehvlik()
        {
            InitializeComponent();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 girs = new Form1();

            girs.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Abonent_kommunal abk = new Abonent_kommunal();

            abk.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abonent_qeydiyyati abq = new Abonent_qeydiyyati();

            abq.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Adt.Text != "" && Soyadt.Text != "" && ataadt.Text != "" && KX.Text != "" && AbonentKoduuu.Text != "" && ssn.Text != "" && elqN.Text != "" && Qzom.Text != "")
            {
                SqlConnection d_etme = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                d_etme.Open();
                SqlCommand abonentkomdax = new SqlCommand("Update Abonent_kommunal set Ad=(N'" + Adt.Text + "'), Soyad = (N'" + Soyadt.Text + "'),AtaAdi= (N'" + ataadt.Text + "'), DoğumTarixi= ('" + DateTime.Parse(dt.Text) + "'), KommunalXidmət= (N'" + KX.Text + "') , ŞəxsiyyətinSeriyaN= (N'" + ssn.Text + "') , ƏlaqəN= (N'" + elqN.Text + "') , Xidmətə_Qoşul_Tarix= (N'" + DateTime.Parse(q_zm.Text) + "') , Qosulan_zaman_odenilen_mebleg= (N'" + Qzom.Text + "') where Abonent_kodu=(N'" + AbonentKoduuu.Text + "') )", d_etme);

                abonentkomdax.ExecuteNonQuery();
                d_etme.Close();
                MessageBox.Show("Daxil edildi.", "Qeyd olundu", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("Daxil etmə mümkün deyil.", "Qeyd olunmadı", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AbonentKoduuu.Text != "")
            {
                SqlConnection odemesirasindagoresil = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                odemesirasindagoresil.Open();
                SqlCommand odemesirasindagorsil = new SqlCommand(" Delete Abonent_kommunal where Abonent_kodu=('" + AbonentKoduuu.Text + "') ", odemesirasindagoresil);

                odemesirasindagorsil.ExecuteNonQuery();
                odemesirasindagoresil.Close();
                MessageBox.Show("Silinmə əməlliyatı icra edildi.", "SİLMƏ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Abonentin kodunu yazdıqda silinmə mümkün olacaqdır.", "Silinmədi", MessageBoxButtons.OK);
            }
        }
    }
}
