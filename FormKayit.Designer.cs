namespace _4UG
{
    partial class FormKayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKayit));
            btnKayitOl = new Button();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            SuspendLayout();
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(380, 320);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(240, 50);
            btnKayitOl.TabIndex = 0;
            btnKayitOl.Text = "Kayıt Ol!";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.Location = new Point(350, 150);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 50);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "Kayıt E-postası";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(350, 240);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(300, 50);
            txtSifre.TabIndex = 3;
            txtSifre.Text = "Şifre";
            // 
            // btnGirisYap
            // 
            btnGirisYap.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.ForeColor = Color.RoyalBlue;
            btnGirisYap.Location = new Point(380, 376);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(240, 50);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Zaten hesabın var mı? Giriş Yap!";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // FormKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 555);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(btnKayitOl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KAYIT OL";
            Load += FormKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayitOl;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button btnGirisYap;
    }
}
