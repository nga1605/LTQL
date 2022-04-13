using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NTNBaiTapLon801.Models;
using NTNBaiTapLon801.Models.Process;

namespace NTNBaiTapLon801.Controllers
{
    public class BanAnsController : Controller
    {
        private QuanLyNhaHang db = new QuanLyNhaHang();
        StringProcess aukey = new StringProcess();

        // GET: BanAns
        public ActionResult Index()
        {
            return View(db.BanAns.ToList());
        }

        // GET: BanAns/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanAn banAn = db.BanAns.Find(id);
            if (banAn == null)
            {
                return HttpNotFound();
            }
            return View(banAn);
        }

        // GET: BanAns/Create
        public ActionResult Create()
        {
            if (db.BanAns.Count() == 0)
            {
                ViewBag.NewBAID = "BA01";
            }
            else
            {
                var BAID = db.BanAns.OrderByDescending(m => m.BanAnID).FirstOrDefault().BanAnID;
                var newID = aukey.AutoGenerateID("BA", BAID);
                ViewBag.NewBAID = newID;
            }
            return View();
        }

        // POST: BanAns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BanAnID,TrangthaiBanAn,DanhsachBanAn")] BanAn banAn)
        {
            if (ModelState.IsValid)
            {
                db.BanAns.Add(banAn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(banAn);
        }

        // GET: BanAns/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanAn banAn = db.BanAns.Find(id);
            if (banAn == null)
            {
                return HttpNotFound();
            }
            return View(banAn);
        }

        // POST: BanAns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BanAnID,TrangthaiBanAn,DanhsachBanAn")] BanAn banAn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banAn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banAn);
        }

        // GET: BanAns/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BanAn banAn = db.BanAns.Find(id);
            if (banAn == null)
            {
                return HttpNotFound();
            }
            return View(banAn);
        }

        // POST: BanAns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BanAn banAn = db.BanAns.Find(id);
            db.BanAns.Remove(banAn);
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
