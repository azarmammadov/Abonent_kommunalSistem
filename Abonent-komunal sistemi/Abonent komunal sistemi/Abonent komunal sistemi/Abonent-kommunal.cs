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
    public partial class Abonent_kommunal : Form
    {
        public Abonent_kommunal()
        {
            InitializeComponent();
        }

        private void Abonent_kommunal_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (ABK.Text != "" && ODM.Text != "" && EMLAPSHAD.Text != "" && EMLAPSHSOYAD.Text != "" )
            {
                SqlConnection d_etme = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                d_etme.Open();
                SqlCommand abonentkomdax = new SqlCommand("insert into Odenisler (Abonent_kodu, Ödəyəcəyi_məbləğ, Ödənilən_tarix, Əməliyyatı_aparanın_adı, Əməliyyatı_aparanın_soyadı) values (N'" + ABK.Text + "',N'" + ODM.Text + "','" + DateTime.Parse(ODT.Text) + "', N'" + EMLAPSHAD.Text + "', N'" + EMLAPSHSOYAD.Text + "')", d_etme);

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
           
                SqlConnection datta = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
                datta.Open();
                string axtar = "Select * from Abonent_kommunal where AbonentKodu LIKE '%' + @AbonentKodu +  '%' ";
                SqlDataAdapter axtaris = new SqlDataAdapter(axtar, datta);

                axtaris.SelectCommand.Parameters.AddWithValue("@AbonentKodu ", abkdser.Text.Trim());
                DataTable axtarsce = new DataTable();
                axtaris.Fill(axtarsce);
                axtars.DataSource = axtarsce;
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection datta = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");
            datta.Open();
            string axtar = "Select * from Odenisler where Abonent_kodu LIKE '%' + @Abonent_kodu +  '%' ";
            SqlDataAdapter axtaris = new SqlDataAdapter(axtar, datta);

            axtaris.SelectCommand.Parameters.AddWithValue("@Abonent_kodu ", abkdetod.Text.Trim());
            DataTable axtarsce = new DataTable();
            axtaris.Fill(axtarsce);
            axtars2.DataSource = axtarsce;
        }

        private void axtars2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ABK_KeyPress(object sender, KeyPressEventArgs e)
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
