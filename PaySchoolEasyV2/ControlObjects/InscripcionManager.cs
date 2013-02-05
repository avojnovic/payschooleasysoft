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

    }
}
