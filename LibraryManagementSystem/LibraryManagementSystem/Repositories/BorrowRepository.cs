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
    internal class BorrowRepository
    {
        public void Add(Borrow borrow)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO Borrows
                            (UserId, BookId, BorrowDate, DueDate, IsReturned)
                            VALUES (@u, @b, @bd, @dd, @ir)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", borrow.UserId);
                cmd.Parameters.AddWithValue("@b", borrow.BookId);
                cmd.Parameters.AddWithValue("@bd", borrow.BorrowDate);
                cmd.Parameters.AddWithValue("@dd", borrow.DueDate);
                cmd.Parameters.AddWithValue("@ir", borrow.IsReturned);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void MarkAsReturned(int borrowId, DateTime returnDate)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"UPDATE Borrows
                             SET IsReturned = 1, ReturnDate = @rd
                             WHERE BorrowId = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rd", returnDate);
                cmd.Parameters.AddWithValue("@id", borrowId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public bool CanBorrow(int userId)
        {
            const int borrowLimit = 3;

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Borrows WHERE UserId = @uid AND IsReturned = 0",
                    con);

                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                int activeCount = (int)cmd.ExecuteScalar();

                return activeCount < borrowLimit;
            }
        }

        public List<Borrow> GetByUserId(int userId)
        {
            var list = new List<Borrow>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Borrows WHERE UserId=@uid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(MapBorrow(reader));
                }
            }
            return list;
        }

        public List<Borrow> GetActiveBorrowsByUserId(int userId)
        {
            var list = new List<Borrow>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Borrows WHERE UserId=@uid AND IsReturned = 0";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(MapBorrow(reader));
                }
            }
            return list;
        }


        // GetByBorrowId implementation


        public Borrow GetByBorrowId(int borrowId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = "SELECT * FROM Borrows WHERE BorrowId=@bid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@bid", borrowId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) return MapBorrow(reader);
            }
            return null;
        }

        public List<Borrow> GetAll()
        {
            var list = new List<Borrow>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Borrows", con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(MapBorrow(reader));
                }
            }
            return list;
        }

        private Borrow MapBorrow(SqlDataReader reader)
        {
            return new Borrow
            {
                BorrowId = (int)reader["BorrowId"],
                UserId = (int)reader["UserId"],
                BookId = (int)reader["BookId"],
                BorrowDate = (DateTime)reader["BorrowDate"],
                DueDate = (DateTime)reader["DueDate"],
                ReturnDate = reader["ReturnDate"] == DBNull.Value
                             ? null
                             : (DateTime?)reader["ReturnDate"],
                IsReturned = (bool)reader["IsReturned"]
            };
        }

        public List<Borrow> GetActiveBorrows()
        {
            var list = new List<Borrow>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM Borrows WHERE IsReturned = 0", con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(MapBorrow(reader));
                }
            }
            return list;
        }

        public List<Borrow> GetByBookId(int bookId)
        {
            var list = new List<Borrow>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM Borrows WHERE BookId = @bid", con);

                cmd.Parameters.AddWithValue("@bid", bookId);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(MapBorrow(reader));
                }
            }
            return list;
        }

        public List<Borrow> GetHistoryByUser(int userId)
        {
            var list = new List<Borrow>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Borrows WHERE UserId = @uid ORDER BY BorrowDate DESC",
                    con);

                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(MapBorrow(reader));
                }
            }

            return list;
        }

        public List<Borrow> GetOverdue()
        {
            var list = new List<Borrow>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Borrows WHERE IsReturned = 0 AND DueDate < @now",
                    con);

                cmd.Parameters.AddWithValue("@now", DateTime.Now);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(MapBorrow(reader));
                }
            }

            return list;
        }

        public bool HasOverdue(int userId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT TOP 1 1 FROM Borrows WHERE UserId = @uid AND IsReturned = 0 AND DueDate < @now",
                    con);

                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.Parameters.AddWithValue("@now", DateTime.Now);

                con.Open();
                object result = cmd.ExecuteScalar();

                return result != null;
            }
        }

    }
}
