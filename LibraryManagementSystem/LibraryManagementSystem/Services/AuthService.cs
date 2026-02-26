using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utils;


namespace LibraryManagementSystem.Services
{
    internal class AuthService
    {
        private readonly UserRepository userRepo = new UserRepository();

        public bool Login(string username, string password)
        {
            User user = userRepo.GetByUsername(username);

            if (user == null)
            {   return false;
            }

            if (user.Status != "Active")
            {   return false;
            }
            // for now ,  using plain text password comparison as have to work with hashed password later
            if (user.Password != password)
            {   return false;
            }

            SessionManager.Login(user);
            return true;
        }

        public void Logout()
        {
            SessionManager.Logout();
        }
    }
}
