using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Pago
    {
        private Int64 _id;

        public Int64 Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private Cuota _cuota;

        public Cuota Cuota
        {
            get { return _cuota; }
            set { _cuota = value; }
        }

        private Alumno _alumno;

        public Alumno Alumno
        {
            get { return _alumno; }
            set { _alumno = value; }
        }

        private Factura _factura;

        public Factura Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        private Matricula _matricula;

        public Matricula Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }

        
        private bool _confirmado;

        public bool Confirmado
        {
            get { return _confirmado; }
            set { _confirmado = value; }
        }

        private DateTime? _fechaDePago;

        public DateTime? FechaDePago
        {
            get { return _fechaDePago; }
            set { _fechaDePago = value; }
        }

        public string StatusConfirmado
        {
            get
            {
                if (Confirmado)
                    return "Si";
                else
                    return "No";


            }
        }

        public string CuotaDescripcion
        {
            get
            {
                if (Cuota != null)
                { return Cuota.Anio.ToString() + "-" + Cuota.Mes.ToString(); }
                else
                { return ""; }
            }
        }

        public string MatriculaDescripcion
        {
            get
            {
                if (Matricula != null)
                { return Matricula.Anio.ToString(); }
                else
                { return ""; }
            }
        }


        public string AlumnoDescripcion
        {
            get
            {
                if (Alumno!= null)
                { return Alumno.Id.ToString()+" - "+ Alumno.nombreCompleto; }
                else
                { return ""; }
            }
        }

        public string FacturaNumero
        {
            get
            {
                if (Factura != null)
                { return Factura.Id.ToString(); }
                else
                { return ""; }
            }
        }

        public string FacturaFechaEmision
        {
            get
            {
                if (Factura != null)
                { return Factura.FechaEmisión.ToShortDateString(); }
                else
                { return ""; }
            }
        }
    }
}
