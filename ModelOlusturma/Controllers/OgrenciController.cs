using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelOlusturma.Models; // BURASI ÖNEMLİ !

namespace ModelOlusturma.Controllers
{
    public class OgrenciController : Controller
    {
        public ActionResult OgrListele()
        {
            return View(ModelOlusturma.OgrenciVeri.OgrenciVeri.KOgrenci);
        }


        public ActionResult YeniKayit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKayit(Ogrenci YeniOgrenci)
        {
            OgrenciVeri.OgrenciVeri.KOgrenci.Add(YeniOgrenci);
            return RedirectToAction("OgrListele");
        }

        public ActionResult Duzenle(int id)
        {
            Ogrenci DuzenlenecekOgrenci = ModelOlusturma.OgrenciVeri.OgrenciVeri.KOgrenci.
                Where(x => x.Id == id).FirstOrDefault();
            return View(DuzenlenecekOgrenci);
        }

        [HttpPost]
        public ActionResult Duzenle(Ogrenci ogrenci)
        {
            Ogrenci DuzenlenecekOgrenci = ModelOlusturma.OgrenciVeri.OgrenciVeri.KOgrenci.
                Where(x => x.Id == ogrenci.Id).FirstOrDefault();
            DuzenlenecekOgrenci.OgrNo = ogrenci.OgrNo;
            DuzenlenecekOgrenci.OgrAd = ogrenci.OgrAd;
            DuzenlenecekOgrenci.OgrSoyAd = ogrenci.OgrSoyAd;
            DuzenlenecekOgrenci.BolumAd = ogrenci.BolumAd;
            DuzenlenecekOgrenci.GirisYil = ogrenci.GirisYil;
            return RedirectToAction("OgrListele");

        }

    }
}