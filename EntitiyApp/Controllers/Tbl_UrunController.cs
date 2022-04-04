using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntitiyApp.Models;

namespace EntitiyApp.Controllers
{
    public class Tbl_UrunController : Controller
    {
        private dB_UrunTakipEntities db = new dB_UrunTakipEntities();

        // GET: Tbl_Urun
        public ActionResult Index()
        {
            return View(db.Tbl_Urun.ToList());
        }

        // GET: Tbl_Urun/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Urun tbl_Urun = db.Tbl_Urun.Find(id);
            if (tbl_Urun == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Urun);
        }

        // GET: Tbl_Urun/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Urun/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UrunId,KategoriId,UrunAd,UrunFiyat,UrunAdet")] Tbl_Urun tbl_Urun)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Urun.Add(tbl_Urun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Urun);
        }

        // GET: Tbl_Urun/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Urun tbl_Urun = db.Tbl_Urun.Find(id);
            if (tbl_Urun == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Urun);
        }

        // POST: Tbl_Urun/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UrunId,KategoriId,UrunAd,UrunFiyat,UrunAdet")] Tbl_Urun tbl_Urun)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Urun).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Urun);
        }

        // GET: Tbl_Urun/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Urun tbl_Urun = db.Tbl_Urun.Find(id);
            if (tbl_Urun == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Urun);
        }

        // POST: Tbl_Urun/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Urun tbl_Urun = db.Tbl_Urun.Find(id);
            db.Tbl_Urun.Remove(tbl_Urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult Kategori(int id)
        {
            string kategoriismi = (from k in db.Tbl_Kategoriler
                                   where k.KategoriId == id
                                   select k.KategoriAd).FirstOrDefault();
            ViewBag.Title = kategoriismi + "Kategorisindeki Ürün Listesi";
            ViewBag.Id = id;
            List<Tbl_Urun> filtreliurunler = (from u in db.Tbl_Urun
                                              where u.KategoriId == id
                                              select u).ToList();
            return View(filtreliurunler);
        }
        public ActionResult Detay(int id)
        {
            Tbl_Urun urunum = (from u in db.Tbl_Urun
                               where u.UrunId == id
                                   select u).FirstOrDefault();
            return View(urunum);

        }
    }
}
