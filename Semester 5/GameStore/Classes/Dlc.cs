using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Dlc : Product
    {
        string gameName;
        public string GameName
        {
            set { this.gameName = value; }
            get { return this.gameName; }
        }
    }
}
