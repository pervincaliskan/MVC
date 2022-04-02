using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelOlusturma.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string OgrNo { get; set; }
        public string OgrAd { get; set; }
        public string OgrSoyAd { get; set; }

        public string BolumAd { get; set; }

        public string GirisYil { get; set; }
    }


}