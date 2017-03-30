using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KillerApp_WoD.Database
{
    class Database
    {
        static string connectionString = "Data Source=DESKTOP-E33041D\\SQLEXPRESS;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlConnection myConnection = new SqlConnection(connectionString);


    }
}
