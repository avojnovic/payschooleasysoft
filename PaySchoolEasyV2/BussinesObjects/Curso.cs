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

        private Int64 _cupo;

        public Int64 Cupo
        {
            get { return _cupo; }
            set { _cupo = value; }
        }

        private Int64 _idNivel;

        public Int64 IdNivel
        {
            get { return _idNivel; }
            set { _idNivel = value; }
        }
    }
}
