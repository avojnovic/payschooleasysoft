using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using BussinesObjects;
using System.Data.SqlClient;

namespace DataAccessObjects
{
    class UserTypeDAO
    {
        public static Dictionary<long, UserType> obtenerTodos()
        {
            Dictionary<long, UserType> _dicTipoUsuario = new Dictionary<long, UserType>();

            SqlConnection conn = SQLConn.getConnection();
            SqlCommand cmd = new SqlCommand(@" SELECT [ID]
                      ,[DESCRIPCION]
                      ,[BORRADO]
                  FROM [TIPO_USUARIO]", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UserType u = new UserType();
                u.Id = dr.GetInt64(dr.GetOrdinal("ID"));
                u.Descripcion = dr.GetString(dr.GetOrdinal("DESCRIPCION"));
                u.Borrado = dr.GetBoolean(dr.GetOrdinal("BORRADO"));
                
                _dicTipoUsuario.Add(u.Id, u);
            }

            dr.Close();
            conn.Close();

            return _dicTipoUsuario;
        }

        public static void insert(UserType u)
        {
            SqlConnection conn = SQLConn.getConnection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO TIPO_USUARIO
           ([DESCRIPCION]
           ,[BORRADO])
            VALUES
           (:DESCRIPCION
           ,:BORRADO)", conn);

            SetParameters(u, cmd);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void Update(UserType u)
        {
            SqlConnection conn = SQLConn.getConnection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [TIPO_USUARIO]
               SET [DESCRIPCION] = :DESCRIPCION
                  ,[BORRADO] =:BORRADO
             WHERE ID=:ID", conn);


            SetParameters(u, cmd);
            cmd.Parameters.Add(":ID", SqlDbType.BigInt).Value = u.Id;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }


        private static void SetParameters(UserType u, SqlCommand cmd)
        {
            cmd.Parameters.Add(":DESCRIPCION", SqlDbType.VarChar, 8).Value = u.Descripcion;
            cmd.Parameters.Add(":BORRADO", SqlDbType.Bit).Value = u.Borrado;
        }
        
    }
}
