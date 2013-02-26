using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Matricula
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Int64 _anio;

        public Int64 Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        private Nivel _nivel;

        public Nivel Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }

        public string nombreNivel
        {
            get { return _nivel.Descripcion; }
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
