using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class AuditLog
    {
        public int AuditLogId { get; set; }

        public int UserId { get; set; }
        public string Action { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
