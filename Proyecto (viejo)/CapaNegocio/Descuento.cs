using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Descuento
    {
        private int codigoDescuento;
        private int porcentajeDescuento;
        private Nivel nivel;

        #region CONSTRUCTOR
        public Descuento(int cd, int pd, Nivel n)
        {
            codigoDescuento = cd;
            porcentajeDescuento = pd;
            nivel = n;
        }
        #endregion;

        #region GETTERS Y SETTERS
        public int CodigoDescuento
        {
            get { return codigoDescuento; }
            set { codigoDescuento = value; }
        }
        public int PorcentajeDescuento
        {
            get { return porcentajeDescuento; }
            set { porcentajeDescuento = value; }
        }
        public Nivel Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        #endregion;
    }
}
