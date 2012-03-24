using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class Alumno
    {
        private Int64 dni;
        private String nombre;
        private DateTime fechaNacimiento;
        private Int64 nroMatricula;
        private Int64 codigoBarras;
        private Tutor tutor;

        #region CONSTRUCTOR
        public Alumno(Int64 d, String n, DateTime fn, Int64 nm, Int64 cb, Tutor t)
        {
            dni = d;
            nombre = n;
            fechaNacimiento = fn;
            nroMatricula = nm;
            codigoBarras = cb;
            tutor = t;
        }
        #endregion;

        #region GETTERS Y SETTERS
        public Int64 Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public Int64 NroMatricula
        {
            get { return nroMatricula; }
            set { nroMatricula = value; }
        }
        public Int64 CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }
        public Tutor Tutor
        {
            get { return tutor; }
            set { tutor = value; }
        }
        #endregion;

        #region MÉTODOS
        public string darNivel
        {
            return (Datos.darNivel(nroMatricula)).ToString;
        }
#endregion;
    }
}
