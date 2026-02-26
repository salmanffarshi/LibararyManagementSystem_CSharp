using LibraryManagementSystem.Models;
using LibraryManagementSystem.Utils;
using Microsoft.Data.SqlClient; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    internal class UserRepository
    {
        public int AddAndReturnId(User user)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO Users (Username, Password, RoleId, Status)
                         OUTPUT INSERTED.UserId
                         VALUES (@u,@p,@r,@s)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", user.Username);
                cmd.Parameters.AddWithValue("@p", user.Password);
                cmd.Parameters.AddWithValue("@r", user.RoleId);
                cmd.Parameters.AddWithValue("@s", user.Status);

                con.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public User GetByUsername(string username)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Users WHERE Username=@username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User
                    {
                        UserId = (int)reader["UserId"],
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        RoleId = (int)reader["RoleId"],
                        Status = reader["Status"].ToString()
                    };
                }
            }
            return null;
        }

        public void Add(User user)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO Users 
                             (Username, Password, RoleId, Status)
                             VALUES (@u, @p, @r, @s)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", user.Username);
                cmd.Parameters.AddWithValue("@p", user.Password);
                cmd.Parameters.AddWithValue("@r", user.RoleId);
                cmd.Parameters.AddWithValue("@s", user.Status);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllStudentsWithDetails()
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
            SELECT 
                u.UserId,
                u.Username,
                up.FullName,
                sp.Email,
                sp.Mobile,
                sp.DOB,
                sp.Department,
                u.Status
            FROM Users u
            INNER JOIN UserProfiles up ON u.UserId = up.UserId
            INNER JOIN StudentProfiles sp ON u.UserId = sp.UserId
            WHERE u.RoleId = 4"; 

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(table);
            }

            return table;
        }

        public DataTable SearchStudentsWithDetails(string keyword)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
            SELECT 
                u.UserId,
                u.Username,
                up.FullName,
                sp.Email,
                sp.Mobile,
                sp.DOB,
                sp.Department,
                u.Status
            FROM Users u
            INNER JOIN UserProfiles up ON u.UserId = up.UserId
            INNER JOIN StudentProfiles sp ON u.UserId = sp.UserId
            WHERE u.RoleId = 4
              AND (
                   u.Username LIKE @k
                OR up.FullName LIKE @k
                OR sp.Email LIKE @k
                OR sp.Mobile LIKE @k
                OR sp.Department LIKE @k
              )";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@k", $"%{keyword}%");
                da.Fill(table);
            }

            return table;
        }


        public DataTable GetAllLibrariansWithDetails()
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
            SELECT 
                u.UserId,
                u.Username,
                up.FullName,
                u.Status
            FROM Users u
            INNER JOIN UserProfiles up ON u.UserId = up.UserId
            WHERE u.RoleId = 3";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(table);
            }

            return table;
        }

        public DataTable GetAllAdminsWithDetails()
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"
            SELECT 
                u.UserId,
                u.Username,
                up.FullName,
                u.Status
            FROM Users u
            INNER JOIN UserProfiles up ON u.UserId = up.UserId
            WHERE u.RoleId = 2";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(table);
            }

            return table;
        }

        public void UpdateStatus(int userId, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                const string query = "UPDATE Users SET Status = @status WHERE UserId = @userId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@userId", userId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteUserHardAdminOrLibrarian(int userId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                using (SqlTransaction tx = con.BeginTransaction())
                {
                    try
                    {
                        // Remove audit logs first (FK to Users likely exists)
                        using (SqlCommand cmd = new SqlCommand(
                            "DELETE FROM AuditLogs WHERE UserId = @uid;", con, tx))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.ExecuteNonQuery();
                        }

                        // Remove profile (FK to Users likely exists)
                        using (SqlCommand cmd = new SqlCommand(
                            "DELETE FROM UserProfiles WHERE UserId = @uid;", con, tx))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.ExecuteNonQuery();
                        }

                        // Finally remove user
                        using (SqlCommand cmd = new SqlCommand(
                            "DELETE FROM Users WHERE UserId = @uid;", con, tx))
                        {
                            cmd.Parameters.AddWithValue("@uid", userId);
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

    }
}
