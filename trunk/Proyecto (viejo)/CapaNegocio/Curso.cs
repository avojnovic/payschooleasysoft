using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Curso
    {
        private Int64 codigoCurso;
        private int año;
        private int cupo;
        private Nivel nivel;

        #region CONSTRUCTOR
        public Curso(Int64 cc, int a, int c, Nivel n)
        {
            codigoCurso = cc;
            año = a;
            cupo = c;
            nivel = n;
        }
#endregion;

        #region GETTERS Y SETTERS
        public Int64 CodigoCurso
        {
            get { return codigoCurso; }
            set { codigoCurso = value; }
        }
        public int Año
        {
            get { return año; }
            set { año = value; }
        }
        public int Cupo
        {
            get { return cupo; }
            set { cupo = value; }
        }
        public Nivel Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        #endregion;
    }
}
