using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public static class PaySchoolEasySoft
    {

        public static Usuario validarLoginUsuario(String email, String contraseña)
        {
            Usuario usuario = null;
            ArrayList lista = Datos.recuperarUsuarioPassDeBD(email, contraseña);
            if (lista != null)
            {
                if (lista[5].Equals(true))
                {
                    usuario = new Tutor();
                }
                else
                {
                    usuario = new Administrador();
                }
                usuario.armarObjeto(lista);
                return usuario;
            }
            else
                return null;
        }

        public static bool usuarioDisponible(String email)
        {
            ArrayList resultado = Datos.usuarioDisponible(email);
            return resultado == null;
        }

        public static Tutor buscarTutor(string dni)
        {
            Tutor tutor = new Tutor();          
            ArrayList lista = Datos.buscarTutor(dni);
            if (lista != null)
            {
                tutor.armarObjeto(lista);
                return tutor;
            }
            else 
                return null;
        }
        
        public static void registrarTutor(Tutor tutor)
        {
            ArrayList objetoTutor = new ArrayList();
            objetoTutor.Add(tutor.Dni);
            objetoTutor.Add(tutor.Nombre);
            objetoTutor.Add(tutor.Apellido);
            objetoTutor.Add(tutor.Email);
            objetoTutor.Add(tutor.Contraseña);
            objetoTutor.Add(tutor.Telefono);
            objetoTutor.Add(tutor.Direccion);
            Datos.guardarTutor(objetoTutor);
        }
    }
}
