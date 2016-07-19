using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mvc_Repository.Models;
using Mvc_Repository.Models.Interface;
using Mvc_Repository.Models.Repository;

namespace Mvc_Repository.Controllers
{
    public class ProductsController : Controller
    {
        private IRepository<Products> productsRepository;
        private IRepository<Categories> categoriesRepository;

        public IEnumerable<Categories> Categories
        {
            get 
            {
                return categoriesRepository.GetAll();
            }
        }
 
        public ProductsController()
        {
            this.productsRepository = new GenericRepository<Products>();
            this.categoriesRepository = new GenericRepository<Categories>();
        }
 
        public ActionResult Index()
        {
            var products = productsRepository.GetAll().OrderByDescending(x => x.ProductID).ToList();
            return View(products);
        }
 
        //=========================================================================================
        
        public ActionResult Details(int id = 0)
        {
            Products product = productsRepository.Get(x => x.ProductID == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
 
        //=========================================================================================
 
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.Categories, "CategoryID", "CategoryName");
            return View();
        }
 
        [HttpPost]
        public ActionResult Create(Products products)
        {
            if (ModelState.IsValid)
            {
                this.productsRepository.Create(products);
                return RedirectToAction("Index");
            }
        
            ViewBag.CategoryID = new SelectList(this.Categories, "CategoryID", "CategoryName", products.CategoryID);
            return View(products);
        }
 
        //=========================================================================================
 
        public ActionResult Edit(int id = 0)
        {
            Products product = this.productsRepository.Get(x => x.ProductID == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(this.Categories, "CategoryID", "CategoryName", product.CategoryID);
            return View(product);
        }
 
        [HttpPost]
        public ActionResult Edit(Products products)
        {
            if (ModelState.IsValid)
            {
                this.productsRepository.Update(products);
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(this.Categories, "CategoryID", "CategoryName", products.CategoryID);
            return View(products);
        }
 
        //=========================================================================================
 
        public ActionResult Delete(int id = 0)
        {
            Products product = this.productsRepository.Get(x => x.ProductID == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
 
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Products product = this.productsRepository.Get(x=>x.ProductID == id);
            this.productsRepository.Delete(product);
            return RedirectToAction("Index");
        }
    }
}
