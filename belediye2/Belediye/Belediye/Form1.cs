namespace Belediye
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtKulan�c�.Text == "emrah" && txtsifre.Text == "12345")
            {

                Anasayfa ana = new Anasayfa();
                ana.Show();
                this.Hide();

            }
            else {
                MessageBox.Show("Hatal� giri� Yapt�n�z");
                txtKulan�c�.Clear();
                txtsifre.Clear();
            }
        }
    }
}