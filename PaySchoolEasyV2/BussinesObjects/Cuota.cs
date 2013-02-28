using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Cuota
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

        private Int64 _mes;

        public Int64 Mes
        {
            get { return _mes; }
            set { _mes = value; }
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
    }
}
