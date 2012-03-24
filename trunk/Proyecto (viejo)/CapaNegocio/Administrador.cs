using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Administrador : Usuario
    {

        #region CONSTRUCTOR
        public Administrador(String e, String c, String d, String a, String n)
            : base(e, c, d, a, n)
        { }
        public Administrador():base() { }
        #endregion;

        public override bool sosTutor()
        {
            return false;
        }
        
        public override void armarObjeto(ArrayList datos)
        {
            dni = datos[0].ToString();
            nombre = datos[1].ToString();
            apellido = datos[2].ToString();
            email = datos[3].ToString();
            contraseña = datos[4].ToString();
        }
    }
}
