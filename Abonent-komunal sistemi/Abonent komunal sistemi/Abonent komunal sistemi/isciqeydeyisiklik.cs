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
    public partial class isciqeydeyisiklik : Form
    {
        public isciqeydeyisiklik()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 girs = new Form1();
            girs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Adt.Text != "" && Soyadt.Text != "" && ataadt.Text != "" && isdN.Text != "" && sifreT.Text != "" && ssn.Text != "" && elqN.Text != "")
            {
                SqlConnection d_etme = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                d_etme.Open();
                SqlCommand abonentkomdax = new SqlCommand("Update İsciQeydiyyati set Ad=(N'" + Adt.Text + "'), Soyad = (N'" + Soyadt.Text + "'), AtaAdi= (N'" + ataadt.Text + "'), DogumTarixi= ('" + DateTime.Parse(dt.Text) + "') , Şəxsiyyətin_Seriya_N= (N'" + ssn.Text + "') , Əlaqə_N= (N'" + elqN.Text + "') , Maaş= (N'" + maas.Text + "') , Şifrə = (N'" + sifreT.Text + "') where İstifadeci_N=(N'" + isdN.Text + "') )", d_etme);

                abonentkomdax.ExecuteNonQuery();
                d_etme.Close();
                MessageBox.Show("Daxil edildi.", "Qeyd olundu", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Daxil etmə mümkün deyil.", "Qeyd olunmadı", MessageBoxButtons.OK);
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

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void button6_KeyPress(object sender, KeyPressEventArgs e)
        {
            BDBB g = new BDBB();

            g.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isciqeydiy iscq = new isciqeydiy();

            iscq.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abonent_qeydiyyati abq = new Abonent_qeydiyyati();

            abq.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abonent_kommunal abk = new Abonent_kommunal();

            abk.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isdN.Text != "")
            {
                SqlConnection odemesirasindagoresil = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                odemesirasindagoresil.Open();
                SqlCommand odemesirasindagorsil = new SqlCommand(" Delete İsciQeydiyyati where İstifadeci_N=('" + isdN.Text + "') ", odemesirasindagoresil);

                odemesirasindagorsil.ExecuteNonQuery();
                odemesirasindagoresil.Close();
                MessageBox.Show("Silinmə əməlliyatı icra edildi.", "SİLMƏ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("İstifadəçi nömrəsini yazdıqda silinmə mümkün olacaqdır.", "Silinmədi", MessageBoxButtons.OK);
            }
        }
    }
}
