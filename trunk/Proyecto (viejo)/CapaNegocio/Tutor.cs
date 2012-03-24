using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
   public class Tutor : Usuario
    {
       
       private String direccion;
       private String telefono;

       #region CONSTRUCTOR
       public Tutor(String e, String c, String d, String a, String n, String dir, String t)
           : base(e, c, d, a, n)
       {          
           direccion = dir;
           telefono = t;
       }
       public Tutor() : base() { }
#endregion;

       #region PROPIEDADES
       public String Direccion
       {
           get { return direccion; }
           set { direccion = value; }
       }
       public String Telefono
       {
           get { return telefono; }
           set { telefono = value; }
       }
       #endregion;

       public override bool sosTutor()
       {
           return true;
       }

       public override void armarObjeto(ArrayList datos)
       {
           dni = datos[0].ToString();
           nombre = datos[1].ToString();
           apellido = datos[2].ToString();
           email = datos[3].ToString();
           contraseña = datos[4].ToString();          
           telefono = datos[6].ToString();
           direccion = datos[7].ToString();
       }

       public bool sePuedeEliminar()
       {
           return Datos.tutorRegistroAlumno(dni);
       }

       public bool eliminarse()
       {
           if (sePuedeEliminar())
           {
               Datos.eliminarTutor(dni);
               return true;
           }
           else
               return false;
       }
    }
}
