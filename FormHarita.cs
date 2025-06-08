using _4UG.Properties; // Eğer Resources.resx gibi kaynaklar kullanılıyorsa bu using gerekli olabilir.
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _4UG
{
    public partial class FormHarita : Form
    {
        
        private WebView2 webViewGoogleMaps;
        private string aramaTuru;

        public FormHarita(string aramaTuru = "")
        {
            
            InitializeComponent();

            this.aramaTuru = aramaTuru;
            InitializeWebView(); 
        }

        private async void InitializeWebView()
        {
           
            if (this.webViewGoogleMaps == null)
            {
                
                this.webViewGoogleMaps = this.Controls.OfType<WebView2>().FirstOrDefault();
            }


            if (this.webViewGoogleMaps == null)
            {
                
                this.webViewGoogleMaps = new WebView2();
                this.webViewGoogleMaps.Dock = DockStyle.Fill;
                this.Controls.Add(this.webViewGoogleMaps); 
            }

           
            if (this.webViewGoogleMaps != null && this.webViewGoogleMaps.CoreWebView2 == null)
            {
                await this.webViewGoogleMaps.EnsureCoreWebView2Async(null);
            }

            
            if (this.webViewGoogleMaps != null && this.webViewGoogleMaps.CoreWebView2 != null)
            {
                if (!string.IsNullOrEmpty(aramaTuru))
                {
                    string googleMapsUrl = $"https://www.google.com.tr/maps/search/?api=1&query={Uri.EscapeDataString(aramaTuru)} near me&hl=tr";
                    this.webViewGoogleMaps.CoreWebView2.Navigate(googleMapsUrl);
                }
                else
                {
                    this.webViewGoogleMaps.CoreWebView2.Navigate("https://www.google.com.tr/maps?hl=tr");
                }
            }
            else if (this.webViewGoogleMaps == null)
            {
                MessageBox.Show("WebView2 kontrolü başlatılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormHarita_Load(object sender, EventArgs e)
        {
            
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHarita));
            SuspendLayout();
            // 
            // FormHarita
            // 
            ClientSize = new Size(1582, 855);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormHarita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HARİTA";
            ResumeLayout(false);
        }
    }
}