using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Utils;
using LibraryManagementSystem.Models;
using Microsoft.Data.SqlClient;


namespace LibraryManagementSystem.Repositories
{
    internal class UserProfileRepository
    {
        public void Add(UserProfile profile)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO UserProfiles VALUES (@id,@name)", con);

                cmd.Parameters.AddWithValue("@id", profile.UserId);
                cmd.Parameters.AddWithValue("@name", profile.FullName);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public UserProfile GetByUserId(int userId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM UserProfiles WHERE UserId=@id", con);

                cmd.Parameters.AddWithValue("@id", userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new UserProfile
                    {
                        UserId = (int)reader["UserId"],
                        FullName = reader["FullName"].ToString()
                    };
                }
            }
            return null;
        }

        public void Update(UserProfile profile)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                const string query = @"UPDATE UserProfiles
SET FullName = @name
WHERE UserId = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", profile.UserId);
                cmd.Parameters.AddWithValue("@name", profile.FullName);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
