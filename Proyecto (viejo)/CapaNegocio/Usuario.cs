using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public abstract class Usuario
    {
        protected String email;
        protected String contraseña;
        protected String dni;
        protected String apellido;
        protected String nombre;

        #region CONSTRUCTOR
        public Usuario(String e, String c, String d, String a, String n)
        {
            email = e;
            contraseña = c;
            dni = d;
            apellido = a;
            nombre = n;
        }
        public Usuario() { }
        #endregion;

        #region GETTERS Y SETTERS
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion;

        public abstract bool sosTutor();
        public abstract void armarObjeto(ArrayList lista);
        public bool cambiarContraseña(String nuevaContraseña, String email)
        {
            return Datos.cambiarContraseña(nuevaContraseña, email);
        }
    }
}
