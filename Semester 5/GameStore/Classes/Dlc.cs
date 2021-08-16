using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Dlc : Product
    {
        string baseGameName;
        public string BaseGameName
        {
            set { this.baseGameName = value; }
            get { return this.baseGameName; }
        }
    }
}
