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
    public class Tbl_KategorilerController : Controller
    {
        private dB_UrunTakipEntities db = new dB_UrunTakipEntities();

        // GET: Tbl_Kategoriler
        public ActionResult Index()
        {
            return View(db.Tbl_Kategoriler.ToList());
        }

        // GET: Tbl_Kategoriler/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Kategoriler tbl_Kategoriler = db.Tbl_Kategoriler.Find(id);
            if (tbl_Kategoriler == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Kategoriler);
        }

        // GET: Tbl_Kategoriler/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Kategoriler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KategoriId,KategoriAd")] Tbl_Kategoriler tbl_Kategoriler)
        {
            if (ModelState.IsValid)
            {
                db.Tbl_Kategoriler.Add(tbl_Kategoriler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Kategoriler);
        }

        // GET: Tbl_Kategoriler/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Kategoriler tbl_Kategoriler = db.Tbl_Kategoriler.Find(id);
            if (tbl_Kategoriler == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Kategoriler);
        }

        // POST: Tbl_Kategoriler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KategoriId,KategoriAd")] Tbl_Kategoriler tbl_Kategoriler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Kategoriler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Kategoriler);
        }

        // GET: Tbl_Kategoriler/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl_Kategoriler tbl_Kategoriler = db.Tbl_Kategoriler.Find(id);
            if (tbl_Kategoriler == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Kategoriler);
        }

        // POST: Tbl_Kategoriler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tbl_Kategoriler tbl_Kategoriler = db.Tbl_Kategoriler.Find(id);
            db.Tbl_Kategoriler.Remove(tbl_Kategoriler);
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
    }
}
