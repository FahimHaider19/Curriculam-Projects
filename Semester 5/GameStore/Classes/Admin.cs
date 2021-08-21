using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interface;

namespace GameStore.Classes
{
    public class Admin : User//, IDeveloperManagement, IGamerManagement, IStoreManagement
    {
        int age;
        string firstName;
        string lastName;
        long nid;
        string sex;
        string address;

        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }
        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }
        public long Nid
        {
            set { this.nid = value; }
            get { return this.nid; }
        }
        public string Sex
        {
            set { this.sex = value; }
            get { return this.sex; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
    }
}
