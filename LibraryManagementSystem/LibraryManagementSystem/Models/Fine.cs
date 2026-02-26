using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Fine
    {
        public int FineId { get; set; }
        public int BorrowId { get; set; }

        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
    }
}
