using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Abonent_komunal_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool dogrulugu_yoxla;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlmelumatcedvelininkompyeri = new SqlConnection("Data Source=DESKTOP-UDQ6KSV\\SQLEXPRESS;Initial Catalog=abonent-kommunalxidmet;Integrated Security=True");


            sqlmelumatcedvelininkompyeri.Open();
            SqlCommand sqlmelumatcedvelindenbaxaraqsec = new SqlCommand("Select *from dbo.melumatlar", sqlmelumatcedvelininkompyeri);
            SqlDataReader SqlMelumatCedvelinden_oxu = sqlmelumatcedvelindenbaxaraqsec.ExecuteReader();

            while (SqlMelumatCedvelinden_oxu.Read())
            {

                if (istfadN.Text  == SqlMelumatCedvelinden_oxu["İstifadeci_N"].ToString().TrimEnd() && "(N'" + addaxil.Text + "')"== SqlMelumatCedvelinden_oxu["Ad"].ToString().TrimEnd() && "(N'" + soyaddaxil.Text + "')"  == SqlMelumatCedvelinden_oxu["Soyad"].ToString().TrimEnd() && "(N'" + sifredaxil.Text + "')" == SqlMelumatCedvelinden_oxu["Şifrə"].ToString().TrimEnd())
                {
                    dogrulugu_yoxla = true;
                    break;
                }
                else
                {
                    dogrulugu_yoxla = false;

                }

            }
            if (dogrulugu_yoxla == true)
            {

                Abonent_kommunal giris = new Abonent_kommunal();

                giris.Show();

                this.Hide();
            }
            else if ( addaxil.Text=="abonent" && soyaddaxil.Text == "kommunal" && sifredaxil.Text =="xidmetler")
            {
                BDBB giris = new BDBB();

                giris.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Doğruluğunuzu təsdiq edin", "Daxil olma mümkün deyil.", MessageBoxButtons.OK);
            }
        }

        private void istfadN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void addaxil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void soyaddaxil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
