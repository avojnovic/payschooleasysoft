using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
   public static class InscripcionManager
    {

        
        public static IEnumerable<Inscripcion> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno")
                      where c.Id == id
                      select c;

            return res.ToList();
        }


        public static IEnumerable<Inscripcion> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno")
                      select c;

            return res.ToList();
        }

        public static void Update(Inscripcion x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Inscripcion
                       where o.Id == x.Id
                       select o).First();

            res.FechaInscripción = x.FechaInscripción;
            res.Inscripto = x.Inscripto;
            res.Alumno = AlumnoManager.Get((int)x.Alumno.Id).First();

            //Para que la BD no entienda el valor como un valor nuevo y lo intente guardar.
            //Solo para clases con clases asociadas.
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
