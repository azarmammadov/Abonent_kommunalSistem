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
    public partial class Abonent_qeydiyyati : Form
    {
        public Abonent_qeydiyyati()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Qeydiyyatda_sehvlik abonentQeydiyyatsehv = new Qeydiyyatda_sehvlik();

            abonentQeydiyyatsehv.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Abonent_kommunal abonentKom = new Abonent_kommunal();

            abonentKom.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 girs = new Form1();

            girs.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dataBase = "Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True";
            if (Adt.Text !=""  && Soyadt.Text != "" && AtaAdt.Text != ""  && komxidm.Text != "" && ssn.Text != "" && qzamanM.Text != "" && elaqeN.Text != "" )
            {
                SqlConnection d_etme = new SqlConnection(dataBase);
                d_etme.Open();
                SqlCommand abonentkomdax = new SqlCommand("insert into Abonent_kommunal (Ad, Soyad, AtaAdi, DoğumTarixi, KommunalXidmet, ŞəxsiyyətinSeriyaN, ƏlaqəN1, Xidmete_Qosul_Tarix, Qosulan_zaman_odenilen_mebleg ) values (N'" + Adt.Text + "',N'" + Soyadt.Text + "',N'" + AtaAdt.Text + "','" + DateTime.Parse(qt.Text) + "', N'" + komxidm.Text + "', N'AZE,AA " + ssn.Text + "',N'" + elaqeN.Text + "','" + DateTime.Parse(dogumt.Text) + "',N'" + qzamanM.Text + "')", d_etme);

                abonentkomdax.ExecuteNonQuery();
                d_etme.Close();
                MessageBox.Show("Daxil edildi.", "Qeyd olundu", MessageBoxButtons.OK);


            }
            else
            {
                MessageBox.Show("Daxil etmə mümkün deyil.", "Qeyd olunmadı", MessageBoxButtons.OK);
            }
            
        }

        private void elaqeN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void elqeN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void qzamanM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void komxidm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
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

        private void elaqeN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
