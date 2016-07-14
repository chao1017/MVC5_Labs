using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KendoUI.Model;
using KendoGridBinder;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace KendoUIWeb.Controllers
{
    public class GridAjaxController : Controller
    {
        private NORTHWNDEntities db = new NORTHWNDEntities();

        // GET: /GridAjax/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCustomer(KendoGridRequest request)
        {
            try
            {
                var result = db.Customers.ToList();
                return Json(new KendoGrid<Customers>(request, result), JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                Dictionary<string, object> error = new Dictionary<string, object>();
                error.Add("ErrorCode", -1);
                error.Add("ErrorMessage", "讀取資料失敗!");
                return Json(error);
            }
        }

        // GET: /GridAjax/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customers customers = db.Customers.Find(id);
            if (customers == null)
            {
                return HttpNotFound();
            }
            return View(customers);
        }

        // GET: /GridAjax/Create
        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult CreateCustomer(Customers customers)
        {
            if (ModelState.IsValid)
            {
                if (TryUpdateModel(customers))
                {
                    db.Customers.Add(customers);
                    db.SaveChanges();
                    return Json("新增成功!!");
                }
            }
            return Json("新增失敗!!");
        }

        public JsonResult EditCustomer(Customers customers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customers).State = EntityState.Modified;
                if (TryUpdateModel(customers))
                {
                    try
                    {
                        db.SaveChanges();
                        
                    }
                    catch (Exception ex) {

                        string error = ex.Message;
                        return Json("CustomerID不可更新!!\n請按F5重新整理網頁!!");
                        
                    }

                    return Json("更新成功!!");
                }
            }
            return Json("更新失敗!!");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult DeleteCustomer(string CustomerID)
        {
            Customers customers = db.Customers.Find(CustomerID);
            db.Customers.Remove(customers);
            if (TryUpdateModel(customers))
            {
                db.SaveChanges();
                return Json("刪除成功!!");
            }
            return Json("刪除失敗!!");
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
