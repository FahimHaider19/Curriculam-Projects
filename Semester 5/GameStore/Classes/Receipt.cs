using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Receipt
    {
        long purchaseId;
        string customerName;
        string productType;
        string productName;
        string gameName; //only if productType == DLC
        string dateAndTime;
        double price;
    }
}
