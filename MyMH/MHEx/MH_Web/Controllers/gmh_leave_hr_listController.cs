using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MH_Repository.Models;
using MH_Repository.Models.Interface;

namespace MH_Web.Controllers
{
    public class gmh_leave_hr_listController : Controller
    {
        private IGMHCorpTabRepository gmhCorpTabRepository;

        public gmh_leave_hr_listController()
        {
            this.gmhCorpTabRepository = new GMHCorpTabRepository();
        }


        // GET: gmh_leave_hr_list
        public ActionResult Index()
        {
            var result = this.gmhCorpTabRepository.Get("1", "9933");
            return View(result);
        }

        /*
        // GET: gmh_leave_hr_list/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gmh_leave_hr_list gmh_leave_hr_list = db.gmh_leave_hr_list.Find(id);
            if (gmh_leave_hr_list == null)
            {
                return HttpNotFound();
            }
            return View(gmh_leave_hr_list);
        }

        // GET: gmh_leave_hr_list/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: gmh_leave_hr_list/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Fix_HR,Nor_HR,Base,Mod_Base,Break_Init,Break_End,corp_id")] gmh_leave_hr_list gmh_leave_hr_list)
        {
            if (ModelState.IsValid)
            {
                db.gmh_leave_hr_list.Add(gmh_leave_hr_list);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gmh_leave_hr_list);
        }

        // GET: gmh_leave_hr_list/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gmh_leave_hr_list gmh_leave_hr_list = db.gmh_leave_hr_list.Find(id);
            if (gmh_leave_hr_list == null)
            {
                return HttpNotFound();
            }
            return View(gmh_leave_hr_list);
        }

        // POST: gmh_leave_hr_list/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Fix_HR,Nor_HR,Base,Mod_Base,Break_Init,Break_End,corp_id")] gmh_leave_hr_list gmh_leave_hr_list)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gmh_leave_hr_list).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gmh_leave_hr_list);
        }

        // GET: gmh_leave_hr_list/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            gmh_leave_hr_list gmh_leave_hr_list = db.gmh_leave_hr_list.Find(id);
            if (gmh_leave_hr_list == null)
            {
                return HttpNotFound();
            }
            return View(gmh_leave_hr_list);
        }

        // POST: gmh_leave_hr_list/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            gmh_leave_hr_list gmh_leave_hr_list = db.gmh_leave_hr_list.Find(id);
            db.gmh_leave_hr_list.Remove(gmh_leave_hr_list);
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
        */
    }
}
