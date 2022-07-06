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
    public partial class SikayetOneri : Form
    {
        public SikayetOneri()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter DA;
        public DataSet DS;
        public SqlDataReader DR;

        private void btngonder_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = IMPORTANTE\SQLEXPRESS; Initial Catalog = Belediye; Integrated Security = True");

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand veriekle = new SqlCommand("insert into SikayetOneri (Oneri_Adi,Oneri_soyadi,Oneri_mesaj) values (@oad,@osoyad,@omesaj)", con);
                veriekle.Parameters.AddWithValue("@oad", txtsikayetad.Text);
                veriekle.Parameters.AddWithValue("@osoyad", txtsikayetsoyad.Text);
                veriekle.Parameters.AddWithValue("@omesaj", txtoneri.Text);
                veriekle.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kayıt Başarılı");
                txtsikayetad.Clear();
                txtsikayetsoyad.Clear();
                txtoneri.Clear();
                


            }

            else
            {
                MessageBox.Show("Veri Ekleme Başarısız !");
            }




        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            Anasayfa ano = new Anasayfa();
            ano.Show();
            this.Hide();

        }

        private void btnsikayet_Click(object sender, EventArgs e)
        {
            OneriTablosu si = new OneriTablosu();
            si.Show();
            this.Hide();
        }
    }
}
