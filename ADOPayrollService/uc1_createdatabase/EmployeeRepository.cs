using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc1_createdatabase
{
    class EmployeeRepository
    {
        //Give path for Database Connection
        public static string connection = @"Server=.;Database=EmployeeServices;Trusted_Connection=True;";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connection);
    }
}
