using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    internal class BookService
    {
        private readonly BookRepository bookRepo = new BookRepository();
        private readonly AuditService auditService = new AuditService();

        // 1️⃣ ADD NEW BOOK
        public void AddBook(Book book)
        {
            if (book == null)
                throw new Exception("Book data is missing");

            if (string.IsNullOrWhiteSpace(book.Title))
                throw new Exception("Book title is required");

            if (book.TotalCopies <= 0)
                throw new Exception("Total copies must be greater than zero");

            // When adding a new book, all copies are available
            book.AvailableCopies = book.TotalCopies;
            book.IsActive = true;

            bookRepo.Add(book);

            auditService.Log($"Book added: {book.Title}");
        }

        // 2️⃣ UPDATE BOOK DETAILS
        public void UpdateBook(Book book)
        {
            if (book == null)
                throw new Exception("Book data is missing");

            if (book.BookId <= 0)
                throw new Exception("Invalid Book ID");

            if (book.TotalCopies < book.AvailableCopies)
                throw new Exception("Total copies cannot be less than available copies");

            bookRepo.Update(book);

            auditService.Log($"Book updated: {book.Title}");
        }

        // 3️⃣ DELETE (SOFT DELETE) BOOK
        public void DeleteBook(int bookId)
        {
            if (bookId <= 0)
                throw new Exception("Invalid Book ID");

            bookRepo.Deactivate(bookId);

            auditService.Log($"Book deactivated (ID: {bookId})");
        }

        // 4️⃣ GET ALL ACTIVE BOOKS
        public List<Book> GetAllBooks()
        {
            return bookRepo.GetAll();
        }

        // 5️⃣ GET BOOK BY ID
        public Book GetBookById(int bookId)
        {
            if (bookId <= 0)
                throw new Exception("Invalid Book ID");

            return bookRepo.GetById(bookId);
        }

        // 6️⃣ SEARCH BOOKS (TITLE / AUTHOR)
        public List<Book> SearchBooks(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAllBooks();

            return bookRepo.Search(keyword);
        }

        // 7️⃣ CHECK AVAILABILITY
        public bool IsBookAvailable(int bookId)
        {
            Book book = bookRepo.GetById(bookId);

            if (book == null)
                return false;

            return book.IsActive && book.AvailableCopies > 0;
        }

        // 8️⃣ DECREASE AVAILABLE COPIES (ON BORROW)
        public void DecreaseAvailableCopies(int bookId)
        {
            Book book = bookRepo.GetById(bookId);

            if (book == null)
                throw new Exception("Book not found");

            if (book.AvailableCopies <= 0)
                throw new Exception("No copies available");

            book.AvailableCopies--;

            bookRepo.UpdateAvailableCopies(bookId, book.AvailableCopies);
        }

        // 9️⃣ INCREASE AVAILABLE COPIES (ON RETURN)
        public void IncreaseAvailableCopies(int bookId)
        {
            Book book = bookRepo.GetById(bookId);

            if (book == null)
                throw new Exception("Book not found");

            if (book.AvailableCopies >= book.TotalCopies)
                throw new Exception("Available copies cannot exceed total copies");

            book.AvailableCopies++;

            bookRepo.UpdateAvailableCopies(bookId, book.AvailableCopies);
        }
    }
}
