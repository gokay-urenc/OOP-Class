using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Class_Kavrami_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinif snf = new Sinif();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.ad_soyad = txtAdSoyad.Text;
            ogr.vize_notu = Convert.ToSingle(txtVize.Text);
            ogr.final_notu = Convert.ToSingle(txtFinal.Text);
            ogr.cinsiyet = cmbCinsiyet.SelectedItem.ToString() == "E" ? "Erkek" : "Kadın";
            snf.OgrenciEkle(ogr);
            MessageBox.Show("Öğrencinin Ortalaması: " + ogr.Ortalama());
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            foreach (Ogrenci liste in snf.ogrenciler)
            {
                listBox1.Items.Add(liste.ad_soyad + " " + liste.vize_notu + " " + liste.final_notu + " " + liste.cinsiyet);
            }
            float son_sonuc = snf.SınıfOrtalaması();
            MessageBox.Show("Sınıfın Genel Ortalaması: " + son_sonuc);
        }
    }
}
// Sıralama: Class Members => Methods => Fields => Properties
// Field sadece değer tutmak için vardır.