using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepremCantasiUygulamasi
{
    public partial class Form1 : Form
    {
        Canta canta = new Canta();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtIsim.Text) || string.IsNullOrWhiteSpace(txtAdet.Text))
            {
                MessageBox.Show("Lütfen malzeme adı ve adet giriniz.");
                return;
            }

            if (!int.TryParse(txtAdet.Text, out int adet))
            {
                MessageBox.Show("Adet sayısal olmalı.");
                return;
            }

            string isim = txtIsim.Text.Trim();
            DateTime tarih = dateTimePicker1.Value;

            Malzeme m = new Malzeme(isim, adet, tarih);
            canta.MalzemeEkle(m);

            ListeGuncelle();

            txtIsim.Clear();
            txtAdet.Clear();
            txtIsim.Focus();

        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {

            string isim = txtIsim.Text;
            canta.MalzemeSil(isim);

            ListeGuncelle();
        }

        private void btnKontrol_Click_1(object sender, EventArgs e)
        {
            var eksikler = canta.EksikKontrol();
            if (eksikler.Count == 0)
                lblDurum.Text = "Her şey hazır!";
            else
                lblDurum.Text = string.Join("\n", eksikler);
        }

        private void ListeGuncelle()
        {
            lstMalzemeler.Items.Clear();
            var liste = canta.Listele();
            foreach (var item in liste)
            {
                lstMalzemeler.Items.Add(item);
            }
        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void btnHatirlat_Click(object sender, EventArgs e)
        {
            var uyarilar = canta.TarihiYaklasanlariGetir();

            if (uyarilar.Count == 0)
                MessageBox.Show("Tüm malzemeler güncel.");
            else
                MessageBox.Show(string.Join("\n", uyarilar), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            var uyarilar = canta.TarihiYaklasanlariGetir();
            if (uyarilar.Count > 0)
            {
                MessageBox.Show(string.Join("\n", uyarilar), "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
