using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
    public static class MatriculaManager
    {
        public static IEnumerable<Matricula> Get(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Matricula
                      where c.Id == id
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Matricula> GetByYear(long year)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Matricula
                      where c.Año == year
                      select c;

            return res.ToList();
        }


        public static IEnumerable<Matricula> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Matricula
                      select c;

            return res.ToList();
        }

    }
}
