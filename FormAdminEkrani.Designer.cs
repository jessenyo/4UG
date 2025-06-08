namespace _4UG
{
    partial class FormAdminEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEkle = new Button();
            btnSil = new Button();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridLog = new DataGridView();
            button1 = new Button();
            txtKullaniciAra = new TextBox();
            btnKullaniciAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridLog).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(178, 394);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 50);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Kullanıcı Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(178, 450);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 50);
            btnSil.TabIndex = 1;
            btnSil.Text = "Kullanıcı Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.Location = new Point(144, 218);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 50);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "E-Posta girin.";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(144, 292);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(269, 50);
            txtSifre.TabIndex = 3;
            txtSifre.Text = "Şifre Girin.";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(495, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 49;
            dataGridView1.Size = new Size(490, 300);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridLog
            // 
            dataGridLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLog.Location = new Point(495, 362);
            dataGridLog.Name = "dataGridLog";
            dataGridLog.RowHeadersWidth = 49;
            dataGridLog.Size = new Size(490, 300);
            dataGridLog.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(12, 641);
            button1.Name = "button1";
            button1.Size = new Size(153, 52);
            button1.TabIndex = 6;
            button1.Text = "Giriş Ekranına dön.";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtKullaniciAra
            // 
            txtKullaniciAra.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAra.Location = new Point(178, 75);
            txtKullaniciAra.Multiline = true;
            txtKullaniciAra.Name = "txtKullaniciAra";
            txtKullaniciAra.Size = new Size(200, 40);
            txtKullaniciAra.TabIndex = 7;
            // 
            // btnKullaniciAra
            // 
            btnKullaniciAra.Location = new Point(187, 136);
            btnKullaniciAra.Name = "btnKullaniciAra";
            btnKullaniciAra.Size = new Size(180, 40);
            btnKullaniciAra.TabIndex = 8;
            btnKullaniciAra.Text = "Kullanıcı Ara";
            btnKullaniciAra.UseVisualStyleBackColor = true;
            btnKullaniciAra.Click += btnKullaniciAra_Click;
            // 
            // FormAdminEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1032, 705);
            Controls.Add(btnKullaniciAra);
            Controls.Add(txtKullaniciAra);
            Controls.Add(button1);
            Controls.Add(dataGridLog);
            Controls.Add(dataGridView1);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdminEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoşgeldin Admin.";
            Load += FormAdminEkrani_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnSil;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private DataGridView dataGridView1;
        private DataGridView dataGridLog;
        private Button button1;
        private TextBox txtKullaniciAra;
        private Button btnKullaniciAra;
    }
}