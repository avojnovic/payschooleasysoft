using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Inscripcion
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Alumno _alumno;

        public Alumno Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }
        
        public string alumnoNombre
        {
            get { return Alumno.nombreCompleto; }
        }

      
        private DateTime _fechaInscripción;

        public DateTime FechaInscripción
        {
            get { return _fechaInscripción; }
            set { _fechaInscripción = value; }
        }

        private Boolean _inscripto;

        public Boolean Inscripto
        {
            get { return _inscripto; }
            set { _inscripto = value; }
        }

        private Boolean _enListaDeEspera;

        public Boolean EnListaDeEspera
        {
            get { return _enListaDeEspera; }
            set { _enListaDeEspera = value; }
        }


        private Curso _curso;

        public Curso Curso
        {
            get { return _curso; }
            set { _curso = value; }
        }


        public string CursoDescripcion
        {
             get
            {
                return _curso.Anio;
            }
        }

        public string NivelDescripcion
        {
            get
            {
                return _curso.Nivel.Descripcion;
            }
        }
 
        public string StatusInscripto
        {
            get
            {
                if (Inscripto)
                    return "Si";
                else
                    return "No";
                
            
            }
        }

        public string StatusEspera
        {
            get
            {
                if (EnListaDeEspera)
                    return "Si";
                else
                    return "No";


            }
        }


    }
}
