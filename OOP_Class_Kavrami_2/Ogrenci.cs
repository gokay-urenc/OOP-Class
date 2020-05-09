using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Class_Kavrami_2
{
    class Ogrenci
    {
        public string ad_soyad;
        public float vize_notu;
        public float final_notu;
        public string cinsiyet;

        public float Ortalama()
        {
            // Vizeyi ortalamaya %40'lık etki, final notunun ortalamaya %60'lık etkisi olsun.
            float sonuc = vize_notu * 0.4f + final_notu * 0.6f;
            return sonuc;
        }
    }
}