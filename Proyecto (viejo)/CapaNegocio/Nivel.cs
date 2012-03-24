using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Nivel
    {
        private Int64 codigoNivel;
        private String descripcion;
        private float valorCuota;
        private float valorMatricula;

        #region CONSTRUCTOR
        public Nivel(Int64 cn, String d, float vc, float vm)
        {
            codigoNivel = cn;
            descripcion = d;
            valorCuota = vc;
            valorMatricula = vm;
        }
        #endregion;

        #region GETTERS Y SETTERS
        public Int64 CodigoNivel
        {
            get { return codigoNivel; }
            set { codigoNivel = value; }
        }
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public float ValorCuota
        {
            get { return valorCuota; }
            set { valorCuota = value; }
        }
        public float ValorMatricula
        {
            get { return valorMatricula; }
            set { valorMatricula = value; }
        }
        #endregion;
    }
}
