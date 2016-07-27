using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Mvc_Repository.Models;
using Mvc_Repository.Models.Interface;
using Mvc_Repository.Models.Repository;

namespace Mvc_Repository.Controllers
{
    public class CategoryController : Controller
    {
        //private IRepository<Categories> categoriesRepository;
        private ICategoryRepository categoriesRepository;

        public CategoryController()
        {
            this.categoriesRepository = new CategoryRepository();
        }


        public ActionResult Index()
        {
            var categories = this.categoriesRepository.GetAll().OrderByDescending(x => x.CategoryID).ToList();
            return View(categories);
        }

        //=========================================================================================

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("index");
            }
            else
            {
                var category = this.categoriesRepository.Get(x => x.CategoryID == id.Value);
                return View(category);        
            }
        }

        //=========================================================================================

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Categories category)
        {
            if (category != null && ModelState.IsValid)
            {
                this.categoriesRepository.Create(category);
                return RedirectToAction("index");
            }
            else
            {
                return View(category);
            }
        }
        
        ////=========================================================================================
        
        public ActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("index");
            }
            else
            {
                var category = this.categoriesRepository.Get(x => x.CategoryID == id.Value);
                return View(category);
            }
        }
        
        [HttpPost]
        public ActionResult Edit(Categories category)
        {
            if (category != null && ModelState.IsValid)
            {
                this.categoriesRepository.Update(category);
                return View(category);
            }
            else
            {
                return RedirectToAction("index");
            }
        }
        
        ////=========================================================================================
        
        public ActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                return RedirectToAction("index");
            }
            else
            {
                var category = this.categoriesRepository.Get(x => x.CategoryID == id.Value);
                return View(category);
            }
        }
        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var category = this.categoriesRepository.Get(x => x.CategoryID == id);
                this.categoriesRepository.Delete(category);
            }
            catch (DataException)
            {
                return RedirectToAction("Delete", new { id = id });
            }
            return RedirectToAction("index");
        }

    }
}