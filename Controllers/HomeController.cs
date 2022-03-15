using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasarimGiydirme.Models;

namespace TasarimGiydirme.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Tasarım()
        {
            ViewData["Örnek"] = "Controllerdan gelen bilgi";
            ViewBag.Header = "Tasarım dersinde oluşturduğum Tasarım  viewına Controllerdan veri gönderdim .";

            return View();
        }
        public ActionResult MListele()     // aynı isimde View ekledik template: List görünümünde 
        {
            ViewBag.Listele = "Müşteri Bilgileri Listelemiştir";
            return View(TasarimGiydirme.Musteriveri.Musteriveri.KMusteri);
            // Proje adı.musteriverinin altında. musteri veri class dosyası ile KMusterideki veriyi   modele bagladik

        }
        public ActionResult YeniKayit()
        {


            return View();

        }
        [HttpPost]
        public ActionResult YeniKayit(Models.Musteri yeniMusteri)
        {
            TasarimGiydirme.Musteriveri.Musteriveri.KMusteri.Add(yeniMusteri);
            
            return RedirectToAction("MListele");

        }    
        public ActionResult Duzenle (int id)
        {
            Musteri DuzenlenecekMusteri = TasarimGiydirme.Musteriveri.Musteriveri.KMusteri.
                                            Where(o => o.Id == id).FirstOrDefault();
            return View(DuzenlenecekMusteri);
        }
        [HttpPost]
        public ActionResult Duzenle(Musteri musteri)
        {
            Musteri Duzenlenecekmusteri = TasarimGiydirme.Musteriveri.Musteriveri.KMusteri.
                                          Where(o => o.Id == musteri.Id).FirstorDefault();

            Duzenlenecekmusteri.Ad = musteri.Ad;
            Duzenlenecekmusteri.SoyAd = musteri.SoyAd;
            Duzenlenecekmusteri.Dogtar = musteri.Dogtar;
            Duzenlenecekmusteri.Adres = musteri.Adres;
            Duzenlenecekmusteri.Tckimlikno = musteri.Tckimlikno;
            return RedirectToAction("MListele");


        }
    }
}