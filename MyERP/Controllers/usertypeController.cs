using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using db_class;

namespace MyERP.Controllers
{
    public class usertypeController : Controller
    {
        private EaseErpV1Entities db = new EaseErpV1Entities();

        // GET: usertype
        public ActionResult Index()
        {
            return View(db.tblUserTypes.ToList());
        }

        // GET: usertype/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUserType tblUserType = db.tblUserTypes.Find(id);
            if (tblUserType == null)
            {
                return HttpNotFound();
            }
            return View(tblUserType);
        }

        // GET: usertype/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: usertype/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserTypeID,UserType")] tblUserType tblUserType)
        {
            if (ModelState.IsValid)
            {
                db.tblUserTypes.Add(tblUserType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblUserType);
        }

        // GET: usertype/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUserType tblUserType = db.tblUserTypes.Find(id);
            if (tblUserType == null)
            {
                return HttpNotFound();
            }
            return View(tblUserType);
        }

        // POST: usertype/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserTypeID,UserType")] tblUserType tblUserType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblUserType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblUserType);
        }

        // GET: usertype/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUserType tblUserType = db.tblUserTypes.Find(id);
            if (tblUserType == null)
            {
                return HttpNotFound();
            }
            return View(tblUserType);
        }

        // POST: usertype/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblUserType tblUserType = db.tblUserTypes.Find(id);
            db.tblUserTypes.Remove(tblUserType);
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
