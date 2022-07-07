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
    public partial class OneriTablosu : Form
    {
        public OneriTablosu()
        {
            InitializeComponent();
        }
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter DA;
        public DataSet DS;
        public SqlDataReader DR;

        private void OneriTablosu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = IMPORTANTE\SQLEXPRESS; Initial Catalog = Belediye; Integrated Security = True");
            OneriGetir();




        }


        private void OneriGetir()
        {
            con.Open();
            string kayit = "SELECT * from SikayetOneri";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, con);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataOneri.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();
        }
    }
}
