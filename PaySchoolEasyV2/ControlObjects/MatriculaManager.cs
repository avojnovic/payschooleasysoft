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

            var res = from c in dbContext.Matricula.Include("Nivel")
                      where c.Id == id
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Matricula> GetByYear(long year)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Matricula.Include("Nivel")
                      where c.Año == year
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Matricula> GetByYearNivel(long year,long nivel)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Matricula.Include("Nivel")
                      where c.Año == year && c.Nivel.Id==nivel
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Matricula> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Matricula.Include("Nivel")
                      select c;

            return res.ToList();
        }

        public static void Update(Matricula x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Matricula.Include("Nivel")
                       where o.Id == x.Id
                       select o).First();

            res.Año = x.Año;
            res.Descuento = x.Descuento;
            res.Monto= x.Monto;

            res.Nivel = NivelManager.Get((int)x.Nivel.Id).First();
            dbContext.Entry(res.Nivel).State = System.Data.EntityState.Unchanged;

            dbContext.SaveChanges();
        }



        public static void Insert(Matricula x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            x.Nivel = NivelManager.Get((int)x.Nivel.Id).First();
            dbContext.Entry(x.Nivel).State = System.Data.EntityState.Unchanged;

            dbContext.Matricula.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Matricula.Include("Nivel")
                      where c.Id == id
                      select c;

            if (res.Count() > 0)
            {
                dbContext.Matricula.Remove(res.First());
                dbContext.SaveChanges();
            }
        }

    }
}
