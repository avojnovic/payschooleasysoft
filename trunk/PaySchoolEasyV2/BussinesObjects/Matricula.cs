using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    class Matricula
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Int64 _año;

        public Int64 Año
        {
            get { return _año; }
            set { _año = value; }
        }

        private float _monto;

        public float Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }

        private float _descuento;

        public float Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
    }
}
