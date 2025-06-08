namespace _4UG
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtEmail.Location = new Point(350, 150);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 50);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "E-Posta";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(350, 240);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(300, 50);
            txtSifre.TabIndex = 1;
            txtSifre.Text = "Şifre";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(380, 320);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(240, 50);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş Yap!";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click_1;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.WhiteSmoke;
            btnKayitOl.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKayitOl.ForeColor = Color.RoyalBlue;
            btnKayitOl.Location = new Point(400, 380);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(200, 50);
            btnKayitOl.TabIndex = 3;
            btnKayitOl.Text = "Hesabın yok mu? Kayıt ol!";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 555);
            Controls.Add(btnKayitOl);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GIRIS YAP";
            Load += FormGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button btnGiris;
        private Button btnKayitOl;
    }
}