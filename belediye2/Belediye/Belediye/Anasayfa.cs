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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter DA;
        public DataSet DS;
        public SqlDataReader DR;



        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelKayıt ps = new PersonelKayıt();
            ps.Show();
            this.Hide();

        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            AracBilgisi ar=new AracBilgisi();
            ar.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = IMPORTANTE\SQLEXPRESS; Initial Catalog = Belediye; Integrated Security = True");
            PersonelGetir();
            AracGetir();

        }
        private void PersonelGetir()
        {
            con.Open();
            string kayit = "SELECT * from PersonelKayit";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, con);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            datapersonel.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();
        }
        private void AracGetir()
        {
            con.Open();
            string kayit = "SELECT * from AracBilgisi";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, con);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataArac.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SikayetOneri si = new SikayetOneri();
            si.Show();
            this.Hide();
        }

        private void datapersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
