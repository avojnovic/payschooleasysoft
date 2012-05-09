using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccessObjects
{
   public static class SQLConn
    {
       public static SqlConnection getConnection()
       {
            return new SqlConnection("server=.\\localhost;integrated security=yes;database=schoolsys");
       }

    }
}
