using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class Datos
    {
        private static String strCon = "Data Source=.\\LOCALHOST;Initial Catalog=BD_PAYSCHOOLEASYSOFT;Integrated Security=SSPI";
        private static SqlDataAdapter da = null;
        private static SqlCommand cmd = null;
        private static DataSet ds = null;
        private static SqlConnection conexion = null;

        //RECUPERA UN ELEMENTO
        private static ArrayList traerElemento(string consulta)
        {
            ArrayList elemento = null;
            try
            {
                conexion = new SqlConnection(strCon);
                conexion.Open();
                da = new SqlDataAdapter(consulta, conexion);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    elemento = new ArrayList();
                    IEnumerator en = ds.Tables[0].Rows[0].ItemArray.GetEnumerator();
                    while (en.MoveNext())
                    {
                        elemento.Add(en.Current);
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    ds.Dispose();
                    da.Dispose();
                    conexion.Dispose();
                }
            }
            return elemento;
        }
       
        //RECUPERA VARIOS ELEMENTOS
        private static ArrayList traerTodos(string consulta)
        {
            ArrayList cada = null;
            ArrayList todos = null;
            try
            {
                todos = new ArrayList();
                conexion = new SqlConnection(strCon);
                conexion.Open();
                da = new SqlDataAdapter(consulta, conexion);
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cada = new ArrayList();
                    IEnumerator en = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (en.MoveNext())
                    {
                        cada.Add(en.Current);
                    }
                    todos.Add(cada);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    ds.Dispose();
                    da.Dispose();
                    conexion.Dispose();
                }
            }
            return todos;
        }

        //CAMBIAR CONTRASEÑA
        public static bool cambiarContraseña(String nuevaContraseña, String email)
        {
            try
            {
                string consulta = "UPDATE USUARIO_TBL SET CONTRASEÑA = '" + nuevaContraseña + "' WHERE USUARIO = '"+email+"'";
                conexion = new SqlConnection(strCon);
                conexion.Open();
                da = new SqlDataAdapter(consulta, conexion);
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    ds.Dispose();
                    da.Dispose();
                    conexion.Dispose();
                }
            }
                return true;
            }
        
        //RECUPERAR USUARIO
        public static ArrayList recuperarUsuarioPassDeBD(String email, String contraseña)
        {
            String consulta = "SELECT * FROM USUARIO_TBL " +
                            "WHERE USUARIO LIKE '"+ email.ToString() + "' AND CONTRASEÑA LIKE '" + contraseña.ToString() + "'";
            return Datos.traerElemento(consulta);
        }

        //USUARIO DISPONIBLE
        public static ArrayList usuarioDisponible(String email)
        {
            String consulta = "SELECT 'X' " +
                              "FROM USUARIO_TBL " +
                              "WHERE USUARIO LIKE '" + email.ToString() + "'";
            return Datos.traerElemento(consulta);
        }

        //DNI UNICO
        public static ArrayList buscarTutor(string dni)
        {
            String consulta = "SELECT * " +
                              "FROM USUARIO_TBL " +
                              "WHERE DNI LIKE '" + dni.ToString() + "'";
            return Datos.traerElemento(consulta);
        }

        //GUARDAR TUTOR
        public static void guardarTutor(ArrayList objetoTutor)
        {
            string consulta = String.Empty;

            string dni = objetoTutor[0].ToString();
            string nombre = objetoTutor[1].ToString();
            string apellido = objetoTutor[2].ToString();
            string email = objetoTutor[3].ToString();
            string contraseña = objetoTutor[4].ToString();
            string telefono = objetoTutor[5].ToString();
            string direccion = objetoTutor[6].ToString();
                        
            try
            {

                consulta = "INSERT INTO USUARIO_TBL (DNI,NOMBRE,APELLIDO,USUARIO,CONTRASEÑA,TIPO,TELEFONO,DIRECCION) Values ('" + dni + "','" + apellido + "','" + nombre + "','" + email + "','" + contraseña + "', 'TRUE', '" + telefono + "', '" + direccion + "' );";
                Datos.conexion = new SqlConnection(Datos.strCon);
                Datos.conexion.Open();
                Datos.cmd = new SqlCommand(consulta, Datos.conexion);
                Datos.cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                Datos.conexion.Close();
                Datos.conexion.Dispose();
                Datos.cmd.Dispose();

            }
        }

        //ELIMINAR TUTOR
        public static void eliminarTutor(String dni)
        {
            string consulta = "DELETE FROM USUARIO_TBL WHERE DNI= " + dni + "";

            try
            {
                conexion = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                conexion.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    ds.Dispose();
                    da.Dispose();
                    conexion.Dispose();
                }
            }
        }

        //TUTOR REGISTRO ALUMNO
        public static bool tutorRegistroAlumno(string dni)
        {
            string consulta = "SELECT 'X' FROM ALUMNO_TBL WHERE TUTOR= " + dni + "";
            return Datos.traerTodos(consulta)!= null;
        }

        //DAR NIVEL Y CURSO
        public static ArrayList darNivelCurso(int nroMatricula)
        {
            String consulta = "SELECT NIVEL, CURSO FROM CURSANDO_TRX WHERE ALUMNO = '" + nroMatricula + "'";
            return Datos.traerElemento(consulta);
        }
    }
}
