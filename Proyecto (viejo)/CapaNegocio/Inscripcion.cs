using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Inscripcion
    {
        private Int64 nroInscripcion;
        private DateTime fechaInscripcion;
        private bool abonoMatricula;
        private bool estaEnEspera;
        private Curso curso;
        private Descuento descuento;
        private Alumno alumno;

        #region CONSTRUCTOR
        public Inscripcion(Int64 ni, DateTime fi, bool am, bool eee, Curso c, Descuento d, Alumno a)
        {
            nroInscripcion=ni;
            fechaInscripcion = fi;
            abonoMatricula=am;
            estaEnEspera = eee;
            curso = c;
            descuento = d;
            alumno = a;
        }
        #endregion;

        #region GETTERS Y SETTERS
        public Int64 NroInscripcion
        {
            get { return nroInscripcion; }
            set { nroInscripcion = value; }
        }
        public DateTime FechaInscripcion
        {
            get { return fechaInscripcion; }
            set { fechaInscripcion = value; }
        }
        public bool AbonoMatricula
        {
            get { return abonoMatricula; }
            set { abonoMatricula = value; }
        }
        public bool EstaEnEspera
        {
            get { return estaEnEspera; }
            set { estaEnEspera = value; }
        }
        public Curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public Descuento Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public Alumno Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }
        #endregion;
    }
}
