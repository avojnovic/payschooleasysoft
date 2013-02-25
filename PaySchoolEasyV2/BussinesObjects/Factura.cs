using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Factura
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _fechaEmisión;

        public DateTime FechaEmisión
        {
            get { return _fechaEmisión; }
            set { _fechaEmisión = value; }
        }

        private float _importeTotal;

        public float ImporteTotal
        {
            get { return _importeTotal; }
            set { _importeTotal = value; }
        }


    }
}
