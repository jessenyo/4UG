using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq; 

namespace _4UG
{
    public partial class FormAdminEkrani : Form
    {
        private DataTable kullaniciTablosu;

        public FormAdminEkrani()
        {
            InitializeComponent();
        }

        private void FormAdminEkrani_Load(object sender, EventArgs e)
        {
            KullaniciListele();
            GirisLoglariniYukle();
        }

        private void KullaniciListele()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = "SELECT Id, Email FROM Kullanicilar";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                kullaniciTablosu = new DataTable(); 
                da.Fill(kullaniciTablosu);
                dataGridView1.DataSource = kullaniciTablosu;
            }
        }

        private void GirisLoglariniYukle()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = "SELECT Email, GirisTarihi FROM GirisLoglari ORDER BY GirisTarihi DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridLog.DataSource = dt;
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = "INSERT INTO Kullanicilar (Email, Sifre) VALUES (@Email, @Sifre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kullanıcı eklendi.");
                KullaniciListele();
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.");
                return;
            }

            int kullaniciId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            using (SqlConnection conn = new SqlConnection(DbHelper.ConnectionString))
            {
                string query = "DELETE FROM Kullanicilar WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", kullaniciId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kullanıcı silindi.");
                KullaniciListele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGiris girisFormu = new FormGiris();
            girisFormu.Show();
            this.Hide();
        }

        private void txtKullaniciAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtKullaniciAra.Text.ToLower();

            if (kullaniciTablosu != null)
            {
                var filteredData = kullaniciTablosu.AsEnumerable()
                    .Where(row => row.Field<string>("Email").ToLower().Contains(aramaMetni));

                if (filteredData.Any())
                {
                    DataTable dtFiltrelenmis = filteredData.CopyToDataTable();
                    dataGridView1.DataSource = dtFiltrelenmis;
                }
                else
                { 
                    dataGridView1.DataSource = kullaniciTablosu.Clone(); 
                }
            }
        }

        private void btnKullaniciAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtKullaniciAra.Text.ToLower();

            if (kullaniciTablosu != null)
            {
             
                var filteredData = kullaniciTablosu.AsEnumerable()
                    .Where(row => row.Field<string>("Email").ToLower().Contains(aramaMetni));
                
                if (filteredData.Any())
                {
                    DataTable dtFiltrelenmis = filteredData.CopyToDataTable();
                    dataGridView1.DataSource = dtFiltrelenmis;
                }
                else
                {
                    
                    dataGridView1.DataSource = kullaniciTablosu.Clone();
                   
                }
            }
        }
    }
}