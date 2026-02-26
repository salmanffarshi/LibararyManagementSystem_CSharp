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
    internal class BookRepository
    {
        // 1️⃣ Add new book (Admin)
        public void Add(Book book)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"INSERT INTO Books
                            (Title, Author, ISBN, TotalCopies, AvailableCopies, IsActive)
                            VALUES (@t, @a, @i, @tc, @ac, 1)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@t", book.Title);
                cmd.Parameters.AddWithValue("@a", book.Author);
                cmd.Parameters.AddWithValue("@i", book.ISBN);
                cmd.Parameters.AddWithValue("@tc", book.TotalCopies);
                cmd.Parameters.AddWithValue("@ac", book.AvailableCopies);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 2️⃣ Update book info (Admin / Librarian)
        public void Update(Book book)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                string query = @"UPDATE Books SET
                            Title=@t, Author=@a, ISBN=@i,
                            TotalCopies=@tc, AvailableCopies=@ac
                            WHERE BookId=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@t", book.Title);
                cmd.Parameters.AddWithValue("@a", book.Author);
                cmd.Parameters.AddWithValue("@i", book.ISBN);
                cmd.Parameters.AddWithValue("@tc", book.TotalCopies);
                cmd.Parameters.AddWithValue("@ac", book.AvailableCopies);
                cmd.Parameters.AddWithValue("@id", book.BookId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 3️⃣ Soft delete (Admin)
        public void Deactivate(int bookId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("UPDATE Books SET IsActive=0 WHERE BookId=@id", con);

                cmd.Parameters.AddWithValue("@id", bookId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 4️⃣ Get all active books
        public List<Book> GetAll()
        {
            return GetBooks("SELECT * FROM Books WHERE IsActive=1");
        }

        // 5️⃣ Get book by ID
        public Book GetById(int bookId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM Books WHERE BookId=@id AND IsActive=1", con);

                cmd.Parameters.AddWithValue("@id", bookId);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return MapBook(reader);
                }
            }
            return null;
        }

        // 6️⃣ Search books (Student / Librarian)
        public List<Book> Search(string keyword)
        {
            string query = @"SELECT * FROM Books
                         WHERE IsActive=1 AND
                         (Title LIKE @k OR Author LIKE @k OR ISBN LIKE @k)";

            return GetBooks(query, new SqlParameter("@k", "%" + keyword + "%"));
        }

        // 7️⃣ Update available copies (Borrow / Return)
        public void UpdateAvailableCopies(int bookId, int newCount)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd =
                    new SqlCommand("UPDATE Books SET AvailableCopies=@c WHERE BookId=@id", con);

                cmd.Parameters.AddWithValue("@c", newCount);
                cmd.Parameters.AddWithValue("@id", bookId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 🔧 COMMON HELPERS (PRIVATE)

        private List<Book> GetBooks(string query, params SqlParameter[] parameters)
        {
            var books = new List<Book>();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(MapBook(reader));
                }
            }
            return books;
        }

        private Book MapBook(SqlDataReader reader)
        {
            return new Book
            {
                BookId = (int)reader["BookId"],
                Title = reader["Title"].ToString(),
                Author = reader["Author"].ToString(),
                ISBN = reader["ISBN"].ToString(),
                TotalCopies = (int)reader["TotalCopies"],
                AvailableCopies = (int)reader["AvailableCopies"],
                IsActive = (bool)reader["IsActive"]
            };
        }
    }
}
