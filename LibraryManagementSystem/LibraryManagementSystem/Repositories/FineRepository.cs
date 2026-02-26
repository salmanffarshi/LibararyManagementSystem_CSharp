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
    internal class FineRepository
    {
        public void Add(Fine fine)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO Fines
                            (BorrowId, Amount, IsPaid)
                            VALUES (@b, @a, @p)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@b", fine.BorrowId);
                cmd.Parameters.AddWithValue("@a", fine.Amount);
                cmd.Parameters.AddWithValue("@p", fine.IsPaid);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void MarkAsPaid(int fineId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("UPDATE Fines SET IsPaid = 1 WHERE FineId = @id", con);

                cmd.Parameters.AddWithValue("@id", fineId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Fine GetByBorrowId(int borrowId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT TOP 1 * FROM Fines WHERE BorrowId=@bid ORDER BY FineId DESC", con);

                cmd.Parameters.AddWithValue("@bid", borrowId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Fine
                    {
                        FineId = (int)reader["FineId"],
                        BorrowId = (int)reader["BorrowId"],
                        Amount = (decimal)reader["Amount"],
                        IsPaid = (bool)reader["IsPaid"]
                    };
                }
            }

            return null;
        }

        public void UpdateAmount(int fineId, decimal amount)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("UPDATE Fines SET Amount = @a WHERE FineId = @id", con);

                cmd.Parameters.AddWithValue("@a", amount);
                cmd.Parameters.AddWithValue("@id", fineId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public Fine GetById(int fineId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM Fines WHERE FineId = @id", con);

                cmd.Parameters.AddWithValue("@id", fineId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Fine
                    {
                        FineId = (int)reader["FineId"],
                        BorrowId = (int)reader["BorrowId"],
                        Amount = (decimal)reader["Amount"],
                        IsPaid = (bool)reader["IsPaid"]
                    };
                }
            }

            return null;
        }

        public List<Fine> GetUnpaidByUser(int userId)
        {
            var fines = new List<Fine>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT f.FineId, f.BorrowId, f.Amount, f.IsPaid
              FROM Fines f
              INNER JOIN Borrows b ON b.BorrowId = f.BorrowId
              WHERE b.UserId = @uid AND f.IsPaid = 0
              ORDER BY f.FineId DESC",
                    con);

                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    fines.Add(new Fine
                    {
                        FineId = (int)reader["FineId"],
                        BorrowId = (int)reader["BorrowId"],
                        Amount = (decimal)reader["Amount"],
                        IsPaid = (bool)reader["IsPaid"]
                    });
                }
            }

            return fines;
        }


        public List<Fine> GetAllUnpaid()
        {
            var fines = new List<Fine>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM Fines WHERE IsPaid = 0 ORDER BY FineId DESC", con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    fines.Add(new Fine
                    {
                        FineId = (int)reader["FineId"],
                        BorrowId = (int)reader["BorrowId"],
                        Amount = (decimal)reader["Amount"],
                        IsPaid = (bool)reader["IsPaid"]
                    });
                }
            }

            return fines;
        }

        public bool HasUnpaidFines(int userId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 1 1
              FROM Fines f
              INNER JOIN Borrows b ON b.BorrowId = f.BorrowId
              WHERE b.UserId = @uid AND f.IsPaid = 0",
                    con);

                cmd.Parameters.AddWithValue("@uid", userId);

                con.Open();

                object result = cmd.ExecuteScalar();
                return result != null;
            }
        }


        public DataTable GetFineReport(DateTime startDate, DateTime endDate)
        {
            if (startDate.Date > endDate.Date)
            {
                throw new Exception("Start date cannot be greater than end date.");
            }

            DataTable table = new DataTable();

            DateTime from = startDate.Date;
            DateTime toInclusive = endDate.Date.AddDays(1).AddTicks(-1);

            using (SqlConnection con = DbConnection.GetConnection())
            {
                const string query = @"
SELECT
    f.FineId,
    f.Amount,
    f.IsPaid,
    b.BorrowId,
    b.BorrowDate,
    b.DueDate,
    b.ReturnDate,
    b.IsReturned,
    u.UserId,
    u.Username,
    up.FullName,
    bk.BookId,
    bk.Title AS BookTitle,
    bk.ISBN
FROM Fines f
INNER JOIN Borrows b ON b.BorrowId = f.BorrowId
INNER JOIN Users u ON u.UserId = b.UserId
LEFT JOIN UserProfiles up ON up.UserId = u.UserId
INNER JOIN Books bk ON bk.BookId = b.BookId
WHERE b.BorrowDate >= @from AND b.BorrowDate <= @to
ORDER BY f.FineId DESC;";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@from", from);
                da.SelectCommand.Parameters.AddWithValue("@to", toInclusive);
                da.Fill(table);
            }

            return table;
        }

        public DataTable GetFineReport()
        {
            DataTable table = new DataTable();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                const string query = @"
SELECT
    f.FineId,
    f.Amount,
    f.IsPaid,
    b.BorrowId,
    b.BorrowDate,
    b.DueDate,
    b.ReturnDate,
    b.IsReturned,
    u.UserId,
    u.Username,
    up.FullName,
    bk.BookId,
    bk.Title AS BookTitle,
    bk.ISBN
FROM Fines f
INNER JOIN Borrows b ON b.BorrowId = f.BorrowId
INNER JOIN Users u ON u.UserId = b.UserId
LEFT JOIN UserProfiles up ON up.UserId = u.UserId
INNER JOIN Books bk ON bk.BookId = b.BookId
ORDER BY f.FineId DESC;";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(table);
            }

            return table;
        }

    }
}
