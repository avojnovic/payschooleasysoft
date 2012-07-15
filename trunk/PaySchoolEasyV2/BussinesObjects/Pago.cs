using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    class Pago
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Int64 _idCuota;

        public Int64 IdCuota
        {
            get { return _idCuota; }
            set { _idCuota = value; }
        }

        private Int64 _idAlumno;

        public Int64 IdAlumno
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }

        private Int64 _idFactura;

        public Int64 IdFactura
        {
            get { return _idFactura; }
            set { _idFactura = value; }
        }

        private Int64 _idMatricula;

        public Int64 IdMatricula
        {
            get { return _idMatricula; }
            set { _idMatricula = value; }
        }

        private Int64 _idRecargos;

        public Int64 IdRecargos
        {
            get { return _idRecargos; }
            set { _idRecargos = value; }
        }
    }
}
