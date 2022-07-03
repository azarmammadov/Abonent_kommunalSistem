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
    public partial class isciqeydiy : Form
    {
        public isciqeydiy()
        {
            InitializeComponent();
        }

        private void isciqeydiy_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (Adt.Text != "" && Soyadt.Text != "" && AtaAdt.Text != ""  && ssn.Text != "" && maas.Text != "" && sifret.Text != "" && elaqeN.Text != "")
            {
                SqlConnection d_etme = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                d_etme.Open();
                SqlCommand iscidax = new SqlCommand("insert into İsciQeydiyyati (Ad, Soyad, AtaAdi, DogumTarixi, Şəxsiyyətin_Seriya_N, Əlaqə_N, Maaş, Şifrə ) values (N'" + Adt.Text + "',N'" + Soyadt.Text + "',N'" + AtaAdt.Text + "','" + DateTime.Parse(dt.Text) + "', N'AZE,AA " + ssn.Text + "',N'" + elaqeN.Text + "',N'" + maas.Text + "',N'" + sifret.Text + "')", d_etme);

                iscidax.ExecuteNonQuery();
                d_etme.Close();
                MessageBox.Show("Daxil edildi.", "Qeyd olundu", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Daxil etmə mümkün deyil.", "Qeyd olunmadı", MessageBoxButtons.OK);
            }
        }

        private void ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void maas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void elaqeN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void Adt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Soyadt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AtaAdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BDBB bdbb = new BDBB();
            bdbb.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isciqeydeyisiklik isc = new isciqeydeyisiklik();
            isc.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 abk = new Form1();
            abk.Show();
            this.Hide();
        }
    }
}
