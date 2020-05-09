using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Kavrami_2
{
    class Sinif
    {
        public Ogrenci[] ogrenciler = new Ogrenci[0];
        public void OgrenciEkle(Ogrenci student)
        {
            int sinif_eleman_sayisi = ogrenciler.Length;
            sinif_eleman_sayisi++;
            Array.Resize(ref ogrenciler, sinif_eleman_sayisi);
            ogrenciler[sinif_eleman_sayisi - 1] = student;
        }
        // Sınıfın genel ortalamasını hesaplayan method.

        float genel_ortalama = 0;
        public float SınıfOrtalaması()
        {
            float toplam_ortalama = 0;
            foreach (Ogrenci student in ogrenciler)
            {
                toplam_ortalama += student.Ortalama();
            }
            genel_ortalama = toplam_ortalama / ogrenciler.Length;
            return genel_ortalama;
        }
    }
}