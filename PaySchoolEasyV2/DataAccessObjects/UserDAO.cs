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
    public static class UserDAO
    {



        public static User verificarUsuario(string usuario, string password)
        {

            Dictionary<long, User> _dicUsuario = obtenerTodos();

            var userL = from us in _dicUsuario.Values.ToList()
                       where us.Psw==password && us.Email.ToLower().Trim()==usuario.ToLower().Trim()
                        select us;

            if (userL.Any())
                return (User)userL.First();
            else
                return null;

    
        }

        public static Dictionary<long, User> obtenerTodos()
        {
            Dictionary<long, User> _dicUsuario = new Dictionary<long, User>();

            SqlConnection conn = SQLConn.getConnection();
            SqlCommand cmd = new SqlCommand(@" SELECT [ID]
                      ,[DNI]
                      ,[NOMBRE]
                      ,[APELLIDO]
                      ,[EMAIL]
                      ,[PSW]
                      ,[ID_TIPO]
                      ,[TELEFONO]
                      ,[DIRECCION]
                  FROM [USUARIO]", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                User u = new User();
                u.Id = dr.GetInt64(dr.GetOrdinal("ID"));
                u.Nombre = dr.GetString(dr.GetOrdinal("NOMBRE"));
                u.Apellido = dr.GetString(dr.GetOrdinal("APELLIDO"));
                u.Direccion = dr.GetString(dr.GetOrdinal("DIRECCION"));
                u.Dni = dr.GetString(dr.GetOrdinal("DNI"));
                u.Psw = dr.GetString(dr.GetOrdinal("PSW"));
                u.Telefono = dr.GetString(dr.GetOrdinal("TELEFONO"));
                u.Email = dr.GetString(dr.GetOrdinal("EMAIL"));

                _dicUsuario.Add(u.Id, u);
            }

            dr.Close();
            conn.Close();

            return _dicUsuario;
        }

        public static void insert(User u)
        {
            SqlConnection conn = SQLConn.getConnection();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO USUARIO
           ([DNI]
           ,[NOMBRE]
           ,[APELLIDO]
           ,[EMAIL]
           ,[PSW]
           ,[ID_TIPO]
           ,[TELEFONO]
           ,[DIRECCION])
            VALUES
           (:DNI
           ,:NOMBRE
           ,:APELLIDO
           ,:EMAIL
           ,:PSW
           ,:ID_TIPO
           ,:TELEFONO
           ,:DIRECCION)", conn);


            SetParameters(u, cmd);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void Update(User u)
        {
            SqlConnection conn = SQLConn.getConnection();
            SqlCommand cmd = new SqlCommand(@"UPDATE [USUARIO]
               SET [DNI] = :DNI
                  ,[NOMBRE] =:NOMBRE
                  ,[APELLIDO] = :APELLIDO
                  ,[EMAIL] = :EMAIL
                  ,[PSW] = :PSW
                  ,[ID_TIPO] =:ID_TIPO
                  ,[TELEFONO] = :TELEFONO
                  ,[DIRECCION] = :DIRECCION
             WHERE ID=:ID", conn);


            SetParameters(u, cmd);
            cmd.Parameters.Add(":ID", SqlDbType.BigInt).Value = u.Id;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }


        private static void SetParameters(User u, SqlCommand cmd)
        {
            cmd.Parameters.Add(":DNI", SqlDbType.VarChar, 8).Value = u.Dni;
            cmd.Parameters.Add(":NOMBRE", SqlDbType.VarChar, 20).Value = u.Nombre;
            cmd.Parameters.Add(":APELLIDO",SqlDbType.VarChar, 20).Value = u.Apellido;
            cmd.Parameters.Add(":EMAIL",SqlDbType.VarChar, 50).Value = u.Email;
            cmd.Parameters.Add(":PSW",SqlDbType.VarChar, 20).Value = u.Psw;
            cmd.Parameters.Add(":ID_TIPO",SqlDbType.BigInt).Value = u.TipoUsuario.Id;
            cmd.Parameters.Add(":TELEFONO", SqlDbType.VarChar, 8).Value = u.Telefono;
            cmd.Parameters.Add(":DIRECCION",SqlDbType.VarChar, 50).Value = u.Direccion;
        }
        
     


    }
}
