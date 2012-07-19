using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Inscripción
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Int64 _idAlumno;

        public Int64 IdAlumno
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
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
