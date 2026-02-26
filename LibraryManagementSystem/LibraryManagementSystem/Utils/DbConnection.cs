using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Utils
{
    internal class DbConnection
    {
        private static readonly string connectionString =
        "Data Source=SALMAN\\SQLEXPRESS;Initial Catalog=LibraryMS;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
