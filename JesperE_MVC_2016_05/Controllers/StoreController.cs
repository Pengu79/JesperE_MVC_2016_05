using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JesperE_MVC_2016_05.Models;

namespace JesperE_MVC_2016_05.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            List<Store> Stores = new List<Store>() {new Store() {
                    Name = "ToysRus",
                    Address = "Leksaksgatan 2",
                    Products = new List<Product>()
                    { new Product()
                    {
                        Name = "Hello Kitty",
                        Price = 12.33d,
                        ProductNumber = 1313131,
                        ProductsInStock = 55,
                        ProductText = "Rolig kissekatt"
                    },new Product()
                    {
                        Name = "Dinosaur",
                        Price = 22.44d,
                        ProductNumber = 3232323,
                        ProductsInStock = 22,
                        ProductText = "Farlig leksak"
                    }
                    }
            },new Store(){
                    Name = "Klädesbutiken",
                    Address = "Klädgatan 2",
                    Products = new List<Product>()
                    { new Product()
                    {
                        Name = "Hello Kitty tröja",
                        Price = 122.33d,
                        ProductNumber = 1443131,
                        ProductsInStock = 5,
                        ProductText = "Rolig kissekatt tröja"
                    },new Product()
                    {
                        Name = "Dinosaurie byxor",
                        Price = 222.44d,
                        ProductNumber = 3442323,
                        ProductsInStock = 122,
                        ProductText = "Byxor med dinosaurier"
                    }
                    }
            }}
            ;
            Session["stores"] = Stores;

            return View(Stores);
        }

        // GET: Store/Details/5
        public ActionResult Details(string id)
        {

            return View(id);
        }

        // GET: Store/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Store/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Store/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Store/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Store/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Store/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
