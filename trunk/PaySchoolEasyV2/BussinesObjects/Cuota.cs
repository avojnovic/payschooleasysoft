using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    class Cuota
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

        private float _montoCuota;

        public float MontoCuota
        {
            get { return _montoCuota; }
            set { _montoCuota = value; }
        }

        private DateTime _fechaVenc1;

        public DateTime FechaVenc1
        {
            get { return _fechaVenc1; }
            set { _fechaVenc1 = value; }
        }


        private DateTime _fechaVenc2;

        public DateTime FechaVenc2
        {
            get { return _fechaVenc2; }
            set { _fechaVenc2 = value; }
        }
    }
}
