using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utils
{
    internal class DateHelper
    {
        public static int DaysBetween(DateTime start, DateTime end)
        {
            return (end.Date - start.Date).Days;
        }

        public static bool IsOverdue(DateTime dueDate)
        {
            return DateTime.Now.Date > dueDate.Date;
        }
    }
}
