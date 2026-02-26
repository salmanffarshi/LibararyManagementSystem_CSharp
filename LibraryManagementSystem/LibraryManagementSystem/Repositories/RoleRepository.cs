using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utils;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem.Repositories
{
    internal class RoleRepository
    {
        public List<Role> GetAll()
        {
            var roles = new List<Role>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Roles", con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roles.Add(new Role
                    {
                        RoleId = (int)reader["RoleId"],
                        RoleName = reader["RoleName"].ToString()
                    });
                }
            }
            return roles;
        }
    }
}

// role , student profile , userprofile,user