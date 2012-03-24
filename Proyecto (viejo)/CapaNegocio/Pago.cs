using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Pago
    {
        private Int64 codigoPago;
        private DateTime fechaPago;
        private Factura factura;

        #region CONSTRUCTOR
        public Pago(Int64 cp, DateTime fp, Factura f)
        {
            codigoPago = cp;
            fechaPago = fp;
            factura = f;
        }
        #endregion;

        #region GETTERS Y SETTERS
        public Int64 CodigoPago
        {
            get { return codigoPago; }
            set { codigoPago = value; }
        }
        public DateTime FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }
        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }
        #endregion;
    }
}
