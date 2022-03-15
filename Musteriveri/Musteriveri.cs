using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasarimGiydirme.Musteriveri
{
    public class Musteriveri
    {
        public static List<Models.Musteri> KMusteri = new List<Models.Musteri>
       {
           new Models.Musteri
           {
               Id=1,   Ad="Pervin",
        SoyAd="Çalışkan",
        DogTar= Convert.ToDateTime("15/08/1999"),
               TCKimlikNo="12345667",
               Adres ="Adana/Seyhan"
       
           }  ,
           new Models.Musteri
           {
               Id=2,    Ad="Poyraz",
        SoyAd="Çalışkan",
        DogTar= Convert.ToDateTime("06/06/2014"),
               TCKimlikNo="12345667",
               Adres ="Adana/Seyhan"

           }  
       };
    }
}