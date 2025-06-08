using Microsoft.Data.SqlClient;


namespace _4UG
{

    public partial class FormKayit : Form
    {
        public FormKayit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            FormGiris girisFormu = new FormGiris();
            girisFormu.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (email == "" || sifre == "")
            {
                MessageBox.Show("L�tfen t�m alanlar� doldurun.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Kullanicilar (Email, Sifre) VALUES (@Email, @Sifre)";
                    SqlCommand komut = new SqlCommand(query, conn);
                    komut.Parameters.AddWithValue("@Email", email);
                    komut.Parameters.AddWithValue("@Sifre", sifre);
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kay�t ba�ar�l�! Giri� ekran�na y�nlendiriliyorsunuz.");
                    FormGiris girisFormu = new FormGiris();
                    girisFormu.Show();
                    this.Hide();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // UNIQUE constraint hatas� (ayn� email)
                        MessageBox.Show("Bu e-posta zaten kay�tl�.");
                    else
                        MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void FormKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
