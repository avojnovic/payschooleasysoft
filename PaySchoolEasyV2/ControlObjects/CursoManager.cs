using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
   public static class CursoManager
    {
        public static IEnumerable<Curso> Get(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Curso.Include("Nivel")
                      where c.Id == id
                      select c;

            return res.ToList();
        }


        public static IEnumerable<Curso> GetByNivel(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Curso.Include("Nivel")
                      where c.Nivel.Id == id
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Curso> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Curso.Include("Nivel")
                      select c;

            return res.ToList();
        }


        public static void Update(Curso x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Curso.Include("Nivel")
                       where o.Id == x.Id
                       select o).First();

            res.Anio = x.Anio;
            res.Cupo = x.Cupo;


            var Nivel = from c in dbContext.Nivel
                      where c.Id == x.Nivel.Id
                      select c;
            res.Nivel = Nivel.First();
            dbContext.Entry(res.Nivel).State = System.Data.EntityState.Unchanged;


            dbContext.SaveChanges();
        }



        public static void Insert(Curso x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            x.Nivel = NivelManager.Get((int)x.Nivel.Id).First();
            dbContext.Entry(x.Nivel).State = System.Data.EntityState.Unchanged;

            dbContext.Curso.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Curso
                      where c.Id == id
                      select c;

            if (res.Count() > 0)
            {
                dbContext.Curso.Remove(res.First());
                dbContext.SaveChanges();
            }
        }

    }
}
