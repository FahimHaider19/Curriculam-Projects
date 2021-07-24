using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Classes;

namespace GameStore.Interface
{
    interface IGamerManagement
    {
        void banUser(Gamer gamer, string message);
        void unbanUser(Gamer gamer, string message);
        void warning(Gamer gamer, string message);
        void manageRefundRequest(bool approve, RefundRequests refundRequest);
        void changeRegion(Gamer gamer, string region);
    }
}
