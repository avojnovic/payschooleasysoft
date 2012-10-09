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

        
        public static IEnumerable<Alumno> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Alumno.Include("Nivel")
                         where c.Id == id
                         select c;

            return res.ToList();
        }

        public static IEnumerable<Alumno> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Alumno.Include("Nivel")
                         select c;

            return res.ToList();
        }


        public static void Update(Alumno x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Alumno
                          where o.Id == x.Id
                          select o).First();

            res.Apellido = x.Apellido;
            res.Borrado = x.Borrado;
            res.Dni = x.Dni;
            res.FechaNacimiento = x.FechaNacimiento;
            res.Nivel = NivelManager.Get((int)x.Nivel.Id).First();
            
            dbContext.Entry(res.Nivel).State = System.Data.EntityState.Unchanged;
           
            res.Nombre = x.Nombre;
            res.NroMatricula = x.NroMatricula;
            res.Usuario = x.Usuario;

            dbContext.SaveChanges();
        }



        public static void Insert(Alumno x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();
            x.Nivel = NivelManager.Get((int)x.Nivel.Id).First();
            
            dbContext.Entry(x.Nivel).State = System.Data.EntityState.Unchanged;

            dbContext.Alumno.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Alumno
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
