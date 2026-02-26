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
    internal class StudentProfileRepository
    {
        public void Add(StudentProfile student)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO StudentProfiles VALUES (@id,@e,@m,@d,@dept)", con);

                cmd.Parameters.AddWithValue("@id", student.UserId);
                cmd.Parameters.AddWithValue("@e", student.Email);
                cmd.Parameters.AddWithValue("@m", student.Mobile);
                cmd.Parameters.AddWithValue("@d", student.DateOfBirth);
                cmd.Parameters.AddWithValue("@dept", student.Department);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public StudentProfile GetByUserId(int userId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM StudentProfiles WHERE UserId=@id", con);

                cmd.Parameters.AddWithValue("@id", userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new StudentProfile
                    {
                        UserId = (int)reader["UserId"],
                        Email = reader["Email"].ToString(),
                        Mobile = reader["Mobile"].ToString(),
                        DateOfBirth = (DateTime)reader["DOB"],
                        Department = reader["Department"].ToString()
                    };
                }
            }
            return null;
        }

        public void Update(StudentProfile student)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                const string query = @"UPDATE StudentProfiles
SET Email = @e,
    Mobile = @m,
    Department = @dept
WHERE UserId = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", student.UserId);
                cmd.Parameters.AddWithValue("@e", student.Email);
                cmd.Parameters.AddWithValue("@m", student.Mobile);
                cmd.Parameters.AddWithValue("@dept", student.Department);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
