using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelOlusturma.OgrenciVeri
{
    public class OgrenciVeri
    {
        public static List<Models.Ogrenci> KOgrenci = new List<Models.Ogrenci>
        {
            new Models.Ogrenci()
            {
                Id = 1,
                OgrNo = "18155034",
                OgrAd = "Pervin",
                OgrSoyAd = "Çalışkan",
                BolumAd = "Bilgisayar Mühendisliğii",
                GirisYil = "2018"

            },
            new Models.Ogrenci()
            {
                Id = 2,
                OgrNo = "1915400",
                OgrAd = "Ahmet",
                OgrSoyAd = "Yılmaz",
                BolumAd = "Elektrik Elektronik Mühendisliğii",
                GirisYil = "2018"

            }

        };
    }
}