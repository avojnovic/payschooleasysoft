using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Curso
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _anio;

        public string Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }
    

        private Int64 _cupo;

        public Int64 Cupo
        {
            get { return _cupo; }
            set { _cupo = value; }
        }

        private Nivel _nivel;

        public Nivel Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
        }
    }
}
