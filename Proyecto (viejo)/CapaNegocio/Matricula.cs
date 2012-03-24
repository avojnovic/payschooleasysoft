using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Matricula : Factura
    {
        #region CONSTRUCTOR
        public Matricula(Int64 cf, float im, DateTime fe, DateTime v1, DateTime v2, Inscripcion i) : base(cf, im, fe, v1, v2, i) { }
        #endregion;

    }
}
