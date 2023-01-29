//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace NoHunger.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
    }
}