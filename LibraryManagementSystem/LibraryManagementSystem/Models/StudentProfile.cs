using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class StudentProfile
    {
        public int UserId { get; set; }   // FK → Users

        public string Email { get; set; }
        public string Mobile { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
    }
}
