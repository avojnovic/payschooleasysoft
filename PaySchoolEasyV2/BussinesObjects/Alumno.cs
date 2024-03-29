﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

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

        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }


        private User _usuario;

        public User Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
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


        public double edad
        {
            get { return DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1; }
        }
       
    }


    
}



   
     
