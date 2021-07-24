using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interface;

namespace GameStore.Classes
{
    class Admin : User//, IDeveloperManagement, IGamerManagement, IStoreManagement
    {
        int age;
        string firstName;
        string lastName;
        long nid;
        char sex;
        string address;
    }
}
