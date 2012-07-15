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
    class AlumnoDAO
    {
        public static Dictionary<long, Alumno> obtenerTodos()
        {
            Dictionary<long, Alumno> _dicAlumno = new Dictionary<long, Alumno>();

            SqlConnection conn = SQLConn.getConnection();
            SqlCommand cmd = new SqlCommand(@" SELECT [ID]
                      ,[DNI]
                      ,[NOMBRE]
                      ,[APELLIDO]
                      ,[FECHA_NACIMIENTO]
                      ,[NRO_MATRICULA]
                      ,[ID_USUARIO]
                      ,[ID_NIVEL]
                      ,[BORRADO]
                  FROM [ALUMNO]", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Alumno a = new Alumno();
                a.Id = dr.GetInt64(dr.GetOrdinal("ID"));
                a.Nombre = dr.GetString(dr.GetOrdinal("NOMBRE"));
                a.Apellido = dr.GetString(dr.GetOrdinal("APELLIDO"));
                a.Direccion = dr.GetDateTime(dr.GetOrdinal("FECHA_NACIMIENTO"));
                a.Dni = dr.GetString(dr.GetOrdinal("NRO_MATRICULA"));
                a.Psw = dr.GetString(dr.GetOrdinal("ID_USUARIO"));
                a.Telefono = dr.GetString(dr.GetOrdinal("ID_NIVEL"));
                a.Email = dr.GetString(dr.GetOrdinal("EMABORRADOIL"));

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
            cmd.Parameters.Add(":APELLIDO", SqlDbType.VarChar, 20).Value = u.Apellido;
            cmd.Parameters.Add(":EMAIL", SqlDbType.VarChar, 50).Value = u.Email;
            cmd.Parameters.Add(":PSW", SqlDbType.VarChar, 20).Value = u.Psw;
            cmd.Parameters.Add(":ID_TIPO", SqlDbType.BigInt).Value = u.TipoUsuario.Id;
            cmd.Parameters.Add(":TELEFONO", SqlDbType.VarChar, 8).Value = u.Telefono;
            cmd.Parameters.Add(":DIRECCION", SqlDbType.VarChar, 50).Value = u.Direccion;
        }
        
    }
}
