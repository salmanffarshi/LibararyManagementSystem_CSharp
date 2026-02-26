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
    internal class AuditService
    {
        private readonly AuditRepository auditRepo = new AuditRepository();

        // ----------------------------------
        // 1️⃣ LOG CURRENT USER ACTION
        // ----------------------------------
        public void Log(string action)
        {
            if (string.IsNullOrWhiteSpace(action))
                return;

            if (SessionManager.CurrentUser == null)
                return;

            AuditLog log = new AuditLog
            {
                UserId = SessionManager.CurrentUser.UserId,
                Action = action,
                Timestamp = DateTime.Now
            };

            auditRepo.Add(log);

            // Also write to file log (optional but useful)
            Logger.Log(action);
        }

        // ----------------------------------
        // 2️⃣ LOG ACTION FOR SPECIFIC USER
        // ----------------------------------
        public void LogForUser(int userId, string action)
        {
            if (userId <= 0 || string.IsNullOrWhiteSpace(action))
                return;

            AuditLog log = new AuditLog
            {
                UserId = userId,
                Action = action,
                Timestamp = DateTime.Now
            };

            auditRepo.Add(log);
            Logger.Log(action);
        }

        // ----------------------------------
        // 3️⃣ GET ALL AUDIT LOGS (SUPER ADMIN)
        // ----------------------------------
        public List<AuditLog> GetAllLogs()
        {
            return auditRepo.GetAll();
        }

        // ----------------------------------
        // 4️⃣ GET AUDIT LOGS BY USER
        // ----------------------------------
        public List<AuditLog> GetLogsByUser(int userId)
        {
            if (userId <= 0)
                throw new Exception("Invalid user ID");

            return auditRepo.GetByUserId(userId);
        }

        // ----------------------------------
        // 5️⃣ GET AUDIT LOGS BY DATE RANGE
        // ----------------------------------
        public List<AuditLog> GetLogsByDate(DateTime from, DateTime to)
        {
            if (from > to)
                throw new Exception("Invalid date range");

            return auditRepo.GetByDateRange(from, to);
        }
    }
}
