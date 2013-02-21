using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;
using System.Data.Objects;

namespace ControlObjects
{
   public static class InscripcionManager
    {

        
        public static IEnumerable<Inscripcion> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                      where c.Id == id
                      select c;

            return res.ToList();
        }


        public static IEnumerable<Inscripcion> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                      select c;

            return res.ToList();
        }

        public static void Update(Inscripcion x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                       where o.Id == x.Id
                       select o).First();

            res.FechaInscripción = x.FechaInscripción;
            res.Inscripto = x.Inscripto;
           

            var alu =   from c in dbContext.Alumno.Include("Nivel")
                                   where c.Id == x.Alumno.Id
                                 select c;
            res.Alumno = alu.First();
            dbContext.Entry(res.Alumno).State = System.Data.EntityState.Unchanged;

            
            dbContext.SaveChanges();
        }



        public static void Insert(Inscripcion x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();
            x.Alumno = AlumnoManager.Get((int)x.Alumno.Id).First();

            dbContext.Entry(x.Alumno).State = System.Data.EntityState.Unchanged;

            dbContext.Inscripcion.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion
                      where c.Id == id
                      select c;

            if (res.Count() > 0)
            {
                dbContext.Inscripcion.Remove(res.First());
                dbContext.SaveChanges();
            }
        }

    }
}
