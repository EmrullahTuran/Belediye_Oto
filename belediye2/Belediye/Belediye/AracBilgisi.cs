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
using System.Data;

namespace Belediye
{
    public partial class AracBilgisi : Form
    {
        public AracBilgisi()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter DA;
        public DataSet DS;
        public SqlDataReader DR;

        private void btnAracKayıt_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = IMPORTANTE\SQLEXPRESS; Initial Catalog = Belediye; Integrated Security = True");



            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand veriekle = new SqlCommand("insert into AracBilgisi (Arac_model,Arac_plaka,Arac_kilometre,Arac_renk,Arac_turu) values (@model,@plaka,@kilometre,@renk,@turu)", con);
                veriekle.Parameters.AddWithValue("@model", txtmodel.Text);
                veriekle.Parameters.AddWithValue("@plaka", txtplaka.Text);
                veriekle.Parameters.AddWithValue("@kilometre", txtkometre.Text);
                veriekle.Parameters.AddWithValue("@renk", txtrenk.Text);
                veriekle.Parameters.AddWithValue("@turu", txtturu.Text);
                veriekle.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt Başarılı");
                txtmodel.Clear();
                txtplaka.Clear();
                txtkometre.Clear();
                txtrenk.Clear();
                txtturu.Clear();


            }

            else
            {
                MessageBox.Show("Veri Ekleme Başarısız !");
            }

        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa na = new Anasayfa();
            na.Show();
            this.Hide();
        }
    }
}
