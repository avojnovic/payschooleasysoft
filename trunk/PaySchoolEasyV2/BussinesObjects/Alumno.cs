using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinesObjects
{
    public class Alumno
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

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private DateTime? _fechaNacimiento;

        public DateTime? FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        private Int64 _nroMatricula;

        public Int64 NroMatricula
        {
            get { return _nroMatricula; }
            set { _nroMatricula = value; }
        }

        private Int64 _idUsuario;

        public Int64 IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private Int64 _idNivel;

        public Int64 IdNivel
        {
            get { return _idNivel; }
            set { _idNivel = value; }
        }

        private Boolean _borrado;
    
        public Boolean Borrado
        {
            get { return _borrado; }
            set { _borrado = value; }
        }

        public string nombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }
    }
}



   
     
