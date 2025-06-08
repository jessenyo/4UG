using Microsoft.Data.SqlClient;

namespace _4UG
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (email == "" || sifre == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            // 1. Admin girişi kontrolü
            if (email == "admin" && sifre == "1234")
            {
                FormAdminEkrani adminForm = new FormAdminEkrani();
                adminForm.Show();
                this.Hide();
                return;
            }

            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                conn.Open();
                {

                    string logQuery = "INSERT INTO GirisLoglari (Email) VALUES (@Email)";
                    SqlCommand logCmd = new SqlCommand(logQuery, conn);
                    logCmd.Parameters.AddWithValue("@Email", email);
                    logCmd.ExecuteNonQuery();

                }
                try
                {


                    string query = "SELECT COUNT(*) FROM Kullanicilar WHERE Email = @Email AND Sifre = @Sifre";
                    SqlCommand komut = new SqlCommand(query, conn);
                    komut.Parameters.AddWithValue("@Email", email);
                    komut.Parameters.AddWithValue("@Sifre", sifre);

                    int kayitSayisi = (int)komut.ExecuteScalar();

                    if (kayitSayisi > 0)
                    {
                        FormKullaniciEkrani kullaniciForm = new FormKullaniciEkrani();
                        kullaniciForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı e-posta veya şifre.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FormKayit kayitFormu = new FormKayit();
            kayitFormu.Show();
            this.Hide();
        }


        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
