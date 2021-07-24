using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Game : Product
    {
        SystemRequirements systemRequirments;
        List<Dlc> dlcs = new List<Dlc>();
        List<Review> reviews = new List<Review>();
        List<News> news = new List<News>();
    }
}
