using LibraryManagementSystem.Models;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    internal class FineService
    {
        private readonly FineRepository fineRepo = new FineRepository();
        private readonly BorrowRepository borrowRepo = new BorrowRepository();
        private readonly AuditService auditService = new AuditService();

        // ----------------------------------
        // 1️⃣ CALCULATE FINE FOR A BORROW
        // ----------------------------------
        public decimal CalculateFine(int borrowId)
        {
            if (borrowId <= 0)
                throw new Exception("Invalid borrow ID");

            Borrow borrow = borrowRepo.GetByBorrowId(borrowId);
            if (borrow == null)
                throw new Exception("Borrow record not found");

            if (!DateHelper.IsOverdue(borrow.DueDate))
                return 0;

            int lateDays = DateHelper.DaysBetween(borrow.DueDate, DateTime.Now);
            decimal finePerDay = 5; // fixed rate (can be changed later)

            return lateDays * finePerDay;
        }

        // ----------------------------------
        // 2️⃣ CREATE OR UPDATE FINE RECORD
        // ----------------------------------
        public void CreateOrUpdateFine(int borrowId)
        {
            if (borrowId <= 0)
                throw new Exception("Invalid borrow ID");

            decimal amount = CalculateFine(borrowId);

            if (amount <= 0)
                return;

            Fine existingFine = fineRepo.GetByBorrowId(borrowId);

            if (existingFine == null)
            {
                Fine fine = new Fine
                {
                    BorrowId = borrowId,
                    Amount = amount,
                    IsPaid = false
                };

                fineRepo.Add(fine);
            }
            else
            {
                fineRepo.UpdateAmount(existingFine.FineId, amount);
            }

            auditService.Log($"Fine calculated/updated | BorrowID={borrowId} | Amount={amount}");
        }

        // ----------------------------------
        // 3️⃣ PAY FINE
        // ----------------------------------
        public void PayFine(int fineId)
        {
            if (fineId <= 0)
                throw new Exception("Invalid fine ID");

            Fine fine = fineRepo.GetById(fineId);

            if (fine == null)
                throw new Exception("Fine not found");

            if (fine.IsPaid)
                throw new Exception("Fine already paid");

            fineRepo.MarkAsPaid(fineId);

            auditService.Log($"Fine paid | FineID={fineId}");
        }

        // ----------------------------------
        // 4️⃣ GET UNPAID FINES BY USER
        // ----------------------------------
        public List<Fine> GetUnpaidFinesByUser(int userId)
        {
            if (userId <= 0)
                throw new Exception("Invalid user ID");

            return fineRepo.GetUnpaidByUser(userId);
        }

        // ----------------------------------
        // 5️⃣ GET ALL UNPAID FINES (ADMIN)
        // ----------------------------------
        public List<Fine> GetAllUnpaidFines()
        {
            return fineRepo.GetAllUnpaid();
        }

        // ----------------------------------
        // 6️⃣ CHECK IF USER HAS UNPAID FINES
        // ----------------------------------
        public bool HasUnpaidFines(int userId)
        {
            if (userId <= 0)
                return false;

            return fineRepo.HasUnpaidFines(userId);
        }

        

        public DataTable GetFineReport()
        {
            return fineRepo.GetFineReport();
        }
    }
}
