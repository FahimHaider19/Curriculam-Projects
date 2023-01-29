using NoHunger.DB;
using NoHunger.Models;
using NoHunger.Repo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NoHunger.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(UserRepo.Get());
        }
        public ActionResult Create() 
        {
            ViewBag.Users = UserRepo.Get();
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModel User)
        {
            if (ModelState.IsValid)
            {
                UserRepo.Create(User);
                return RedirectToAction("Index");
            }
            return View(User);

        }

        public ActionResult Register()
        {
            ViewBag.Users = UserRepo.Get();
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserModel User)
        {
            if (ModelState.IsValid)
            {
                User.Role = "user";
                UserRepo.Create(User);
                return RedirectToAction("Index");
            }
            return View(User);

        }

        public ActionResult Edit(int id)
        {
            return View(UserRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(UserModel User)
        {
            if (ModelState.IsValid)
            {
                if (User != null)
                {
                    UserRepo.Update(User);
                }
                return RedirectToAction("Index");
            }
            return View(User);

        }

        public ActionResult Delete(int id)
        {
            return View(UserRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Delete(UserModel user)
        {
            /*if (ModelState.IsValid)
            {
                if (User != null)
                {
                    UserRepo.Delete(user);
                }
            }*/
            var db = new NoHungerEntities();
            int userid = Convert.ToInt32(Request["userid"]);
            var usr = (from u in db.Users
                        where u.UserId.Equals(userid)
                       select u)
                       .FirstOrDefault();
            if (usr != null)
            {
                //db.Entry(usr).State = EntityState.Deleted;
                db.Users.Remove(usr);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}