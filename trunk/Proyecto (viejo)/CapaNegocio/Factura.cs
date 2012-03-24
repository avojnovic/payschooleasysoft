using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
   public class Factura
    {
       protected Int64 codigoFactura;
       protected float importe;
       protected DateTime fechaEmision;
       protected DateTime vencimiento1;
       protected DateTime vencimiento2;
       protected Inscripcion inscripcion;

        #region CONSTRUCTOR
       public Factura(Int64 cf, float im, DateTime fe, DateTime v1, DateTime v2, Inscripcion i)
       {
           codigoFactura = cf;
           importe = im;
           fechaEmision = fe;
           vencimiento1 = v1;
           vencimiento2 = v2;
           inscripcion = i;
       }
        #endregion;

        #region GETTERS Y SETTERS
       public Int64 CodigoFactura
       {
           get { return codigoFactura; }
           set { codigoFactura = value; }
       }
       public float Importe
       {
           get { return importe; }
           set { importe = value; }
       }
       public DateTime FechaEmision
       {
           get { return fechaEmision; }
           set { fechaEmision = value; }
       }
       public DateTime Vencimiento1
       {
           get { return vencimiento1; }
           set { vencimiento1 = value; }
       }
       public DateTime Vencimiento2
       {
           get { return vencimiento2; }
           set { vencimiento2 = value; }
       }
       public Inscripcion Inscripcion
       {
           get { return inscripcion; }
           set { inscripcion = value; }
       }
        #endregion;
    }
}
