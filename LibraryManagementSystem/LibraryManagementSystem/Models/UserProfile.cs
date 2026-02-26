using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class UserProfile
    {
        public int UserId { get; set; }   // FK → Users
        public string FullName { get; set; }
    }
}
