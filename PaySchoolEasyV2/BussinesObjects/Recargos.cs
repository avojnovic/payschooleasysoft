using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    class Recargos
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private float _porcentajeVenc1;

        public float PorcentajeVenc1
        {
            get { return _porcentajeVenc1; }
            set { _porcentajeVenc1 = value; }
        }

        private float _porcentajeVenc2;

        public float PorcentajeVenc2
        {
            get { return _porcentajeVenc2; }
            set { _porcentajeVenc2 = value; }
        }
    }
}
