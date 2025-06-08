using System;
using System.Windows.Forms;

namespace _4UG
{
    public partial class FormKullaniciEkrani : Form
    {


        public FormKullaniciEkrani()
        {
            InitializeComponent();
        }


        private void BtnRestoranGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Restoran");
            formHarita.Show();
        }
        private void BtnOtelGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Otel");
            formHarita.Show();
        }
        private void BtnMuzeGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Müze");
            formHarita.Show();
        }
        private void BtnAtmGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Banka ve ATM");
            formHarita.Show();
        }
        private void BtnEczaneGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Eczane");
            formHarita.Show();
        }
        private void BtnHastaneGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Hastaneler ve Klinikler");
            formHarita.Show();
        }
        private void BtnKafeGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Kafe");
            formHarita.Show();
        }
        private void BtnAVMGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "AVM");
            formHarita.Show();
        }
        private void BtnMarketGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Market");
            formHarita.Show();
        }
        private void BtnParkGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Park");
            formHarita.Show();
        }
        private void BtnBenzinlikGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Benzinlik");
            formHarita.Show();
        }
        private void BtnKargoGoster_Click(object sender, EventArgs e)
        {
            FormHarita formHarita = new FormHarita(aramaTuru: "Kargo");
            formHarita.Show();
        }
    }
}