using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;
using ControlObjects;

namespace ControlObjects
{
    public static class AlumnoManager
    {

        //Obtener un alumno por ID
        public static IEnumerable<Alumno> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Alumno.Include("Usuario")
                         where c.Id == id
                         select c;

            return res.ToList();
        }
        //Obtener todos los alumnos
        public static IEnumerable<Alumno> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Alumno.Include("Usuario")
                         select c;

            return res.ToList();
        }

        public static IEnumerable<Alumno> GetByTutor(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Alumno.Include("Usuario")
                      where c.Usuario.Id == id
                      select c;

            return res.ToList();

        }


        public static void Update(Alumno x)
        {

            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Alumno.Include("Usuario")
                          where o.Id == x.Id
                          select o).First();

            res.Apellido = x.Apellido;
            res.Borrado = x.Borrado;
            res.Dni = x.Dni;
            res.FechaNacimiento = x.FechaNacimiento;
            res.Nombre = x.Nombre;
            res.NroMatricula = x.NroMatricula;

            res.Usuario =  (from c in dbContext.User.Include("TipoUsuario")
                      where c.Id == x.Id
                      select c).First();

            dbContext.Entry(res.Usuario).State = System.Data.EntityState.Unchanged;


    
            dbContext.SaveChanges();
        }

        public static bool Validar(Alumno x, bool update)
        {
            SchoolDbContext dbContext = new SchoolDbContext();
            int count = 0;

            if (update)
            {
                var res = (from o in dbContext.Alumno.Include("Usuario")
                           where o.Id != x.Id && o.Dni==x.Dni
                           select o);
                count=res.Count();
               
            }
            else
            {
                var res = (from o in dbContext.Alumno.Include("Usuario")
                           where o.Dni == x.Dni
                           select o);
                count = res.Count();
            }


            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public static void Insert(Alumno x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            x.Usuario = UserManager.Get((int)x.Usuario.Id).First();
            dbContext.Entry(x.Usuario).State = System.Data.EntityState.Unchanged;

            dbContext.Alumno.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Alumno.Include("Usuario")
                         where c.Id == id
                         select c;

            if (res.Count() > 0)
            {
                dbContext.Alumno.Remove(res.First());
                dbContext.SaveChanges();
            }
        }


      
    }
}
