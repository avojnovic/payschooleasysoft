using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace CapaDatos
{
   public static class SQLConn
    {
       public static SqlConnection getConnection()
       {
           return new SqlConnection("server=PC5\\SQLEXPRESS;integrated security=yes;database=SCHOOLSYS");
       }

    }
}
