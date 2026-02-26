using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Models;
using Microsoft.Data.SqlClient;
using LibraryManagementSystem.Utils;

namespace LibraryManagementSystem.Repositories
{
    internal class AuditRepository
    {
        public void Add(AuditLog log)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO AuditLogs
                            (UserId, Action, Timestamp)
                            VALUES (@u, @a, @t)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", log.UserId);
                cmd.Parameters.AddWithValue("@a", log.Action);
                cmd.Parameters.AddWithValue("@t", log.Timestamp);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<AuditLog> GetAll()
        {
            var logs = new List<AuditLog>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM AuditLogs ORDER BY Timestamp DESC", con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    logs.Add(new AuditLog
                    {
                        AuditLogId = (int)reader["AuditLogId"],
                        UserId = (int)reader["UserId"],
                        Action = reader["Action"].ToString(),
                        Timestamp = (DateTime)reader["Timestamp"]
                    });
                }
            }
            return logs;
        }


        public List<AuditLog> GetByUserId(int userId)
        {
            var logs = new List<AuditLog>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM AuditLogs WHERE UserId = @uid ORDER BY Timestamp DESC", con);

                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    logs.Add(new AuditLog
                    {
                        AuditLogId = (int)reader["AuditLogId"],
                        UserId = (int)reader["UserId"],
                        Action = reader["Action"].ToString(),
                        Timestamp = (DateTime)reader["Timestamp"]
                    });
                }
            }

            return logs;
        }

        public List<AuditLog> GetByDateRange(DateTime from, DateTime to)
        {
            var logs = new List<AuditLog>();

            // make "to" inclusive for the full day (if user passes a date without time)
            DateTime toInclusive = to.Date.AddDays(1).AddTicks(-1);

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM AuditLogs WHERE Timestamp >= @from AND Timestamp <= @to ORDER BY Timestamp DESC",
                    con);

                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@to", toInclusive);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    logs.Add(new AuditLog
                    {
                        AuditLogId = (int)reader["AuditLogId"],
                        UserId = (int)reader["UserId"],
                        Action = reader["Action"].ToString(),
                        Timestamp = (DateTime)reader["Timestamp"]
                    });
                }
            }

            return logs;
        }
    }
}
