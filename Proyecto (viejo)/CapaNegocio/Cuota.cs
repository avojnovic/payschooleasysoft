using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
   public abstract class Cuota : Factura
    {
       private int nroCuota;
       private int añoCuota;
       private static int Aumento1;
       private static int Aumento2;

        #region CONSTRUCTOR
       public Cuota(Int64 nf, float im, DateTime fe, DateTime v1, DateTime v2, Inscripcion i, int nc, int ac)
           : base(nf, im, fe, v1, v2, i)
       {
           nroCuota = nc;
           añoCuota = ac;
       }
        #endregion;

        #region GETTERS Y SETTERS
       public int NroCuota
       {
           get { return nroCuota; }
           set { nroCuota = value; }
       }
       public int AñoCuota
       {
           get { return añoCuota; }
           set { añoCuota = value; }
       }
        #endregion;
    }
}
