using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
