using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NewsDTO
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public CategoryDTO Category { get; set; }
        public DateTime Date { get; set; }

    }
}
