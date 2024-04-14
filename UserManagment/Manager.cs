using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBooking.UserManagment
{
    internal abstract class Manager : User
    {
        public string Deparment { get; set; }
        public Manager(string username, string password, string email,Role role,string deparment) : base(username, password, email, role)
        {
            Deparment = deparment;
        }
        public abstract void GenerateReports();
       

    }
}
