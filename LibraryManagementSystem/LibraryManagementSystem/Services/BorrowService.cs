using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    internal class BorrowService
    {
        private readonly BorrowRepository borrowRepo = new BorrowRepository();
        private readonly BookRepository bookRepo = new BookRepository();
        private readonly FineRepository fineRepo = new FineRepository();
        private readonly AuditService auditService = new AuditService();

        // -------------------------------
        // 1️⃣ BORROW A BOOK
        // -------------------------------
        public void BorrowBook(int userId, int bookId)
        {
            if (userId <= 0 || bookId <= 0)
                throw new Exception("Invalid user or book");

            // Rule 1: Check borrow limit
            if (!borrowRepo.CanBorrow(userId))
                throw new Exception("Borrow limit reached");

            // Rule 2: Check availability
            Book book = bookRepo.GetById(bookId);
            if (book == null || !book.IsActive)
                throw new Exception("Book not available");

            if (book.AvailableCopies <= 0)
                throw new Exception("No copies available");

            // Reduce available copies
            bookRepo.UpdateAvailableCopies(bookId, book.AvailableCopies - 1);

            // Create borrow record
            Borrow borrow = new Borrow
            {
                UserId = userId,
                BookId = bookId,
                BorrowDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7), // default 7 days
                IsReturned = false
            };

            borrowRepo.Add(borrow);

            auditService.Log($"Book borrowed | BookID={bookId} | UserID={userId}");
        }

        // -------------------------------
        // 2️⃣ RETURN A BOOK
        // -------------------------------
        public void ReturnBook(int borrowId)
        {
            if (borrowId <= 0)
                throw new Exception("Invalid borrow ID");


            // little confused
            Borrow borrow = borrowRepo.GetByBorrowId(borrowId);

            if (borrow == null)
                throw new Exception("Borrow record not found");

            if (borrow.IsReturned)
                throw new Exception("Book already returned");

            // Mark as returned
            borrowRepo.MarkAsReturned(borrowId, DateTime.Now);

            // Increase available copies
            Book book = bookRepo.GetById(borrow.BookId);
            bookRepo.UpdateAvailableCopies(
                borrow.BookId,
                book.AvailableCopies + 1
            );

            // Calculate fine if overdue
            if (DateHelper.IsOverdue(borrow.DueDate))
            {
                int lateDays = DateHelper.DaysBetween(borrow.DueDate, DateTime.Now);
                decimal fineAmount = lateDays * 5; // fixed rate

                Fine fine = new Fine
                {
                    BorrowId = borrowId,
                    Amount = fineAmount,
                    IsPaid = false
                };

                fineRepo.Add(fine);
            }

            auditService.Log($"Book returned | BorrowID={borrowId}");
        }

        // -------------------------------
        // 3️⃣ GET ACTIVE BORROWS BY USER
        // -------------------------------
        public List<Borrow> GetActiveBorrowsByUser(int userId)
        {
            if (userId <= 0)
                throw new Exception("Invalid user");

            return borrowRepo.GetActiveBorrowsByUserId(userId);
        }

        // -------------------------------
        // 4️⃣ GET BORROW HISTORY BY USER
        // -------------------------------
        public List<Borrow> GetBorrowHistoryByUser(int userId)
        {
            if (userId <= 0)
                throw new Exception("Invalid user");

            return borrowRepo.GetHistoryByUser(userId);
        }

        // -------------------------------
        // 5️⃣ GET ALL OVERDUE BORROWS
        // -------------------------------
        public List<Borrow> GetOverdueBorrows()
        {
            return borrowRepo.GetOverdue();
        }

        // -------------------------------
        // 6️⃣ CHECK IF USER HAS OVERDUE
        // -------------------------------
        public bool HasOverdueBooks(int userId)
        {
            return borrowRepo.HasOverdue(userId);
        }

    }
}
