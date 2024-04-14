using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBooking.UserManagment
{
    public class AdminService
    {
        private UserManager _userManager;

        public AdminService(UserManager userManager)
        {
            _userManager = userManager;
        }

        public User CreateUser(string username, string password, string email, Role role)
        {
            return _userManager.CreateUser(username, password, email, role);
        }

        public void DeleteUser(int userId)
        { 
            _userManager.DeleteUser(userId);
        }

        // Other administrative tasks
        public void PerformSystemBackup()
        {
            // Backup logic
        }

        public void ConfigureSystemSettings(string setting, string value)
        {
            // Configuration logic
        }
    }
}
