using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesObjects
{
    public class UserType
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _dni;

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private bool _borrado;

        public bool Borrado
        {
            get { return _borrado; }
            set { _borrado = value; }
        }
    }
}
