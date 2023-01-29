using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTOs
{
    public class TokenDTO
    {
        public int TokenId { get; set; }
        public string TokenKey { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ExpirationTime { get; set; } //Nullable<System.DateTime>
        public string Username { get; set; }
    }
}
