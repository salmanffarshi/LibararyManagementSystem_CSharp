using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Utils;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagementSystem.Services
{
    internal class UserService
    {
        private readonly UserRepository userRepo = new UserRepository();
        private readonly UserProfileRepository profileRepo = new UserProfileRepository();
        private readonly StudentProfileRepository studentRepo = new StudentProfileRepository();
        private readonly AuditService auditService = new AuditService();

        public void RegisterStudent(
            string username,
            string password,
            string fullName,
            string email,
            string mobile,
            DateTime dob,
            string department)
        {
            // 1. Create User
            User user = new User
            {
                Username = username,
                Password = password,
                RoleId = 4,          // Student
                Status = "Pending"
            };

            int userId = userRepo.AddAndReturnId(user);

            // 2. Create User Profile
            profileRepo.Add(new UserProfile
            {
                UserId = userId,
                FullName = fullName
            });

            // 3. Create Student Profile
            studentRepo.Add(new StudentProfile
            {
                UserId = userId,
                Email = email,
                Mobile = mobile,
                DateOfBirth = dob,
                Department = department
            });
        }

        public void RegisterLibrarian(
            string username,
            string password,
            string fullName)
        {
            // 1. Create User
            User user = new User
            {
                Username = username,
                Password = password,
                RoleId = 3,          // Librarian
                Status = "Active"
            };

            int userId = userRepo.AddAndReturnId(user);

            // 2. Create User Profile
            profileRepo.Add(new UserProfile
            {
                UserId = userId,
                FullName = fullName
            });

        }

        public void RegisterAdmin(
            string username,
            string password,
            string fullName)
        {
            // 1. Create User
            User user = new User
            {
                Username = username,
                Password = password,
                RoleId = 2,          // Admin
                Status = "Active"
            };

            int userId = userRepo.AddAndReturnId(user);

            // 2. Create User Profile
            profileRepo.Add(new UserProfile
            {
                UserId = userId,
                FullName = fullName
            });

        }

        public DataTable GetAllStudents()
        {
            return userRepo.GetAllStudentsWithDetails();
        }

        public DataTable GetAllLibrarians()
        {
            return userRepo.GetAllLibrariansWithDetails();
        }
        public DataTable GetAllAdmins()
        {
            return userRepo.GetAllAdminsWithDetails();
        }

        public DataTable GetAllStudents(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAllStudents();
            }

            return userRepo.SearchStudentsWithDetails(keyword.Trim());
        }

        

        public void SetStudentStatus(int userId, string status)
        {
            if (userId <= 0)
            {
                throw new Exception("Invalid user id.");
            }

            if (string.IsNullOrWhiteSpace(status))
            {
                throw new Exception("Invalid status.");
            }

            userRepo.UpdateStatus(userId, status);
            auditService.Log($"Student status changed: UserId={userId}, Status={status}");
        }

        public void DeleteLibrarian(int userId)
        {
           
            
            auditService.Log($"User deleted permanently: UserId={userId}, RoleId={3}");

            userRepo.DeleteUserHardAdminOrLibrarian(userId);
        }
        public void DeleteAdmin(int userId)
        {

            
            auditService.Log($"User deleted permanently: UserId={userId}, RoleId={2}");

            userRepo.DeleteUserHardAdminOrLibrarian(userId);
        }
    }
}
