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

namespace Belediye
{
    public partial class PersonelKayıt : Form
    {
       
        public PersonelKayıt()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter DA;
        public DataSet DS;
        public SqlDataReader DR;


       
        

    private void btn_personel_kayit_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(@"Data Source = IMPORTANTE\SQLEXPRESS; Initial Catalog = Belediye; Integrated Security = True");
 
    

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand veriekle = new SqlCommand("insert into PersonelKayit (Personel_adi,Personel_soyadi,Personel_numara,Personel_meslek) values (@adi,@soyadi,@numara,@meslek)", con);
                veriekle.Parameters.AddWithValue("@adi", txtad.Text);
                veriekle.Parameters.AddWithValue("@soyadi", txtsoyad.Text);
                veriekle.Parameters.AddWithValue("@numara", txtnumara.Text);
                veriekle.Parameters.AddWithValue("@meslek", txtmeslek.Text);
                veriekle.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt Başarılı");
                txtad.Clear();
                txtsoyad.Clear();
                txtnumara.Clear();
                txtmeslek.Clear();

               
            }

            else
            {
                MessageBox.Show("Veri Ekleme Başarısız !");
            }

        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
