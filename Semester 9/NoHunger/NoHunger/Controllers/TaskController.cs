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
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Index()
        {
            return View(TaskRepo.GetTasks());
        }

        public ActionResult Update(int id)
        {
            return View(TaskRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Update(TaskModel task)
        {
            var db = new NoHungerEntities();
            var v = (from t in db.Tasks
                     where t.TaskId.Equals(task.TaskId)
                     select t).FirstOrDefault();
            db.Entry(v).CurrentValues.SetValues(task);
            db.SaveChanges();
            //return View(TaskRepo.Get(task.TaskId));
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TaskModel task)
        {   TaskRepo.Create(task);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateStatus(int id)
        {
            return View(TaskRepo.Get(id));
        }

        [HttpPost]
        public ActionResult UpdateStatus(TaskModel task)
        {
            var db = new NoHungerEntities();
            var v = (from t in db.Tasks
                     where t.TaskId.Equals(task.TaskId)
                     select t).FirstOrDefault();
            db.Entry(v).CurrentValues.SetValues(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        /*public ActionResult Create()
        {
            ViewBag.Users = TaskRepo.Get();
            return View();
        }

        [HttpPost]
        public ActionResult Create(TaskModel Task)
        {
            if (ModelState.IsValid)
            {
                TaskRepo.Create(Task);
                return RedirectToAction("Index");
            }
            return View(Task);

        }

        public ActionResult Edit(int id)
        {
            return View(TaskRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(TaskModel Task)
        {
            if (ModelState.IsValid)
            {
                if (Task != null)
                {
                    TaskRepo.Update(Task);
                }
                return RedirectToAction("Index");
            }
            return View(Task);

        }
        */

        public ActionResult Delete(int id)
        {
            return View(TaskRepo.Get(id));
        }

        [HttpPost]
        public ActionResult Delete()
        {
            var db = new NoHungerEntities();
            int taskid = Convert.ToInt32(Request["taskid"]);
            var tsk = (from t in db.Tasks
                       where t.TaskId.Equals(taskid)
                       select t).FirstOrDefault();
            if (tsk != null)
            {
                db.Tasks.Remove(tsk);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult AddTaskFood()
        {
            int taskid = Convert.ToInt32(Request["taskid"]);
            int foodid = Convert.ToInt32(Request["foodid"]);
            //db operations
            var db = new NoHungerEntities();
            var food = (from f in db.Foods
                        where f.FoodId.Equals(foodid)
                        select f).FirstOrDefault();
            if (food != null && food.TaskId == null)
            {
                food.TaskId = taskid;
                db.Entry(food).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
                return Redirect("Error?errormessage=Invalid Food Id. Food ID already assigned to a task or does'nt exist");
            return Redirect("Update/" + taskid.ToString());
        }

        public ActionResult RemoveTaskFood()
        {
            int taskid = Convert.ToInt32(Request["taskid"]);
            int foodid = Convert.ToInt32(Request["foodid"]);

            var db = new NoHungerEntities();
            var food = (from f in db.Foods
                        where f.FoodId.Equals(foodid)
                        select f).FirstOrDefault();
            if (food != null)
            {
                food.TaskId = null;
                db.Entry(food).State = EntityState.Modified;
                db.SaveChanges();
            }
            else
                return Redirect("Error?errormessage=Invalid Food Id.");
            return Redirect("Update/" + taskid.ToString());
        }

        public ActionResult AddTaskEmployee()
        {
            int taskid = Convert.ToInt32(Request["taskid"]);
            int userid = Convert.ToInt32(Request["userid"]);
            //db operations
            var db = new NoHungerEntities();
            var taskuser = (from tu in db.TaskUsers
                            where tu.UserId.Equals(userid)
                            where tu.TaskId.Equals(taskid)
                            select tu).FirstOrDefault();
            var u = (from usr in db.Users
                     where usr.UserId.Equals(userid)
                     select usr).FirstOrDefault();
            if (u!=null && u.Role != "employee")
                return Redirect("Error?errormessage=Invalid User Id. User role is not employee or does'nt exist");
            if (u!=null && taskuser == null)
            {
                taskuser = new TaskUser();
                taskuser.UserId = userid;
                taskuser.TaskId = taskid;
                db.TaskUsers.Add(taskuser);
                db.SaveChanges();
            }
            else
                return Redirect("Error?errormessage=Invalid User Id. User role is not employee or does'nt exist");

            return Redirect("Update/" + taskid.ToString());
        }

        public ActionResult RemoveTaskEmployee()
        {
            int taskid = Convert.ToInt32(Request["taskid"]);
            int userid = Convert.ToInt32(Request["userid"]);
            //db operations
            var db = new NoHungerEntities();
            var u = (from usr in db.Users
                     where usr.UserId.Equals(userid)
                     select usr).FirstOrDefault();
            if (u != null && u.Role != "employee")
                return Redirect("Error?errormessage=Invalid User Id. User role is not employee or does'nt exist");
            var taskuser = (from tu in db.TaskUsers
                            where tu.UserId.Equals(userid)
                            where tu.TaskId.Equals(taskid)
                            select tu).FirstOrDefault();
            if (taskuser != null)
            {
                db.TaskUsers.Remove(taskuser);
                db.SaveChanges();
            }
            else 
                return Redirect("Error?errormessage=Invalid User Id.");

            return Redirect("Update/" + taskid.ToString());
        }

        public ActionResult Error(String message)
        {
            return View(message);
        }
    }
}