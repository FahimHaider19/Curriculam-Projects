//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NoHunger.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        public List<UserModel> Employees { get; set; }
        public  List<FoodModel> Foods { get; set; }
        public String TaskDetails { get; set; }
        public String DistributionPoint { get; set; }
        public String Status { get; set; }
    }
}