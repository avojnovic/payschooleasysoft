﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Nivel
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private float _montoMatricula;

        public float MontoMatricula
        {
            get { return _montoMatricula; }
            set { _montoMatricula = value; }
        }

        private float _descuento;

        public float Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }
    }
}