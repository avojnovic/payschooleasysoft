using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Pago
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Cuota _cuota;

        public Cuota Cuota
        {
            get { return _cuota; }
            set { _cuota = value; }
        }

        private Alumno _alumno;

        public Alumno Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }

        private Factura _factura;

        public Factura Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        private Matricula _matricula;

        public Matricula Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        private Recargos _recargos;

        public Recargos Recargos
        {
            get { return _recargos; }
            set { _recargos = value; }
        }


        private bool _confirmado;

        public bool Confirmado
        {
            get { return _confirmado; }
            set { _confirmado = value; }
        }

    }
}
