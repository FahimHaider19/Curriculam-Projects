using NoHunger.DB;
using NoHunger.Models;
using NoHunger.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NoHunger.Controllers
{
    public class FoodController : Controller
    {
        /// GET: Food
        public ActionResult Index()
        {
            return View(FoodRepo.Get());
        }
        public ActionResult Create()
        {
            ViewBag.Foods = FoodRepo.Get();
            return View();
        }

        [HttpPost]
        public ActionResult Create(FoodModel Food)
        {
            if (ModelState.IsValid)
            {
                FoodRepo.Create(Food);
                return RedirectToAction("Index");
            }
            return View(Food);

        }

        public ActionResult Edit(int id)
        {
            return View(FoodRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(FoodModel Food)
        {
            if (ModelState.IsValid)
            {
                if (Food != null)
                {
                    FoodRepo.Update(Food);
                }
                return RedirectToAction("Index");
            }
            return View(Food);
        }

        public ActionResult Delete(int id)
        {
            return View(FoodRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Delete(FoodModel food)
        {
            var db = new NoHungerEntities();
            int foodid = Convert.ToInt32(Request["foodid"]);
            var fd = (from f in db.Foods
                       where f.FoodId.Equals(foodid)
                       select f)
                       .FirstOrDefault();
            if (fd != null)
            {
                //db.Entry(usr).State = EntityState.Deleted;
                db.Foods.Remove(fd);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}