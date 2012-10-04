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
    }
}
