using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Classes;

namespace GameStore.Interface
{
    interface IDeveloperManagement
    {
        bool approveGamePublishRequest(Game game);
    }
}
