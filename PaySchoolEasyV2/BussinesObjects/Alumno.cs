using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaySchoolEasyV2;

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

        private User _usuario;

        public User Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private Nivel _nivel;

        public Nivel Nivel
        {
            get { return _nivel; }
            set { _nivel = value; }
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

        public string NivelNombre
        {
            get {
                if (Nivel != null)
                    return Nivel.Descripcion;
                else
                    return "";
                }
        }
    }


    public static class AlumnoManager
    {
      



        public static IEnumerable<Alumno> GetAlumnoDetail(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var alumno = from c in dbContext.Alumno.Include("Nivel")
                         where c.Id == id
                         select c;
                      
            return alumno.ToList();
        }


        public static void Update(Alumno alu)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var alumno = (from o in dbContext.Alumno
                          where o.Id == alu.Id
                        select o).First();

            alumno.Apellido = alu.Apellido;
            alumno.Borrado = alu.Borrado;
            alumno.Dni = alu.Dni;
            alumno.FechaNacimiento = alu.FechaNacimiento;
            alumno.Nivel = alu.Nivel;
            alumno.Nombre = alu.Nombre;
            alumno.NroMatricula = alu.NroMatricula;
            alumno.Usuario = alu.Usuario;

            dbContext.SaveChanges();
        }


    }
}



   
     
