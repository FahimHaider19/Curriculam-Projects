using Microsoft.Ajax.Utilities;
//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using NoHunger.DB;
using NoHunger.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoHunger.Repo
{
    public class TaskRepo
    {
        public static List<TaskModel> GetTasks()
        {
            var db = new NoHungerEntities();
            var tasks = new List<TaskModel>();

            var t = (from tu in db.Tasks
                        .Include("Foods").Include("TaskUsers")
                        select tu).ToList();
            
            foreach(var v in t)
            {
                List<FoodModel> foods = new List<FoodModel>();
                List<UserModel> users = new List<UserModel>();
                foreach (var f in v.Foods) {
                    foods.Add(new FoodModel() { FoodId = f.FoodId });
                }
                foreach (var f in v.TaskUsers) {
                    users.Add(new UserModel() { UserId = f.UserId });
                }
                tasks.Add(new TaskModel()
                {
                    TaskId = v.TaskId,
                    TaskDetails = v.TaskDetails,
                    DistributionPoint = v.DistributionPoint,
                    Status = v.Status,
                });

            }

            return tasks;
        }
        public static List<TaskModel> Get()
        {
            var db = new NoHungerEntities();
            var tasks = new List<TaskModel>();
            foreach (var t in db.Tasks)
            {
                var e = (from U in db.Users
                         join T in db.TaskUsers
                         on U.UserId equals T.UserId
                         where T.TaskId == t.TaskId
                         select U).ToList();
                var f = (from fd in db.Foods
                         where fd.TaskId == t.TaskId
                         select fd).ToList();
                List<UserModel> employees = new List<UserModel>();
                foreach(var u in e)
                {
                    employees.Add(new UserModel() { 
                        UserId= u.UserId,
                        UserName= u.UserName,
                        Password= u.Password,
                        Role= u.Role
                    });
                }

                List<FoodModel> foods= new List<FoodModel>();
                foreach (var fo in f)
                {
                    UserModel userModel = (UserModel)UserRepo.Get(fo.FoodDonor);
                    foods.Add(new FoodModel()
                    {
                        FoodId = fo.FoodId,
                        FoodName = fo.FoodName,
                        //Expire= fo.Expire,
                        PickupPoint = fo.PickupPoint,
                        PersonQuntity = (int)fo.PersonQuantity,
                        Donor = userModel
                    });
                }
                tasks.Add(new TaskModel()
                {
                    TaskId = t.TaskId,
                    TaskDetails = t.TaskDetails,
                    DistributionPoint = t.DistributionPoint,
                    Status = t.Status,
                    Employees = employees,
                    Foods = foods
                });
            }
            return tasks;
        }

        public static object Get(int taskId)
        {
            var db = new NoHungerEntities();
            var task = (from t in db.Tasks 
                        where t.TaskId == taskId
                        select t).FirstOrDefault();
            var e = (from U in db.Users
                     join T in db.TaskUsers
                     on U.UserId equals T.UserId
                     where T.TaskId == taskId
                     select U).ToList();
            var f = (from fd in db.Foods
                     where fd.TaskId == taskId
                     select fd).ToList();
            List<UserModel> employees = new List<UserModel>();
            foreach (var u in e)
            {
                employees.Add(new UserModel()
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    Password = u.Password,
                    Role = u.Role
                });
            }

            List<FoodModel> foods = new List<FoodModel>();
            foreach (var fo in f)
            {
                UserModel userModel = (UserModel)UserRepo.Get(fo.FoodDonor);
                foods.Add(new FoodModel()
                {
                    FoodId = fo.FoodId,
                    FoodName = fo.FoodName,
                    //Expire= fo.Expire,
                    PickupPoint = fo.PickupPoint,
                    PersonQuntity = (int)fo.PersonQuantity,
                    Donor = userModel
                });
            }

            var TaskModel = new TaskModel();
            TaskModel.TaskId = taskId;
            TaskModel.TaskDetails = task.TaskDetails;
            TaskModel.Employees = employees;
            TaskModel.Foods = foods;
            TaskModel.DistributionPoint = task.DistributionPoint;
            TaskModel.Status = task.Status;
            return TaskModel;
        }

        public static void Create(TaskModel task)
        {
            var t = new DB.Task();
            t.TaskId = task.TaskId;
            t.TaskDetails = task.TaskDetails;
            t.DistributionPoint = task.DistributionPoint;
            t.Status = task.Status;
            var db = new NoHungerEntities();
            db.Tasks.Add(t);
            db.SaveChanges();
        }

        public static void Update()
        {
            var db = new NoHungerEntities();
            var t = (from T in db.Tasks
                        where T.TaskId == 2
                        select T).FirstOrDefault();
            //t.TaskId = v.TaskId;
            
            t.Foods = new List<Food>();
            t.Foods.Add(new Food() { FoodId = 1});
            //t.Foods = (ICollection<Food>)v.Foods;
            //db.Attach(t.Foods[]);
            db.Entry(t).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete(TaskModel user)
        {
            var db = new NoHungerEntities();
            //db.Users.Remove(new User() { UserId = user.UserId });
            db.SaveChanges();
        }
    }
}