using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
     public static class NivelManager
    {


        public static IEnumerable<Nivel> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Nivel
                         where c.Id == id
                         select c;

            return res.ToList();
        }

        public static IEnumerable<Nivel> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Nivel
                         select c;

            return res.ToList();
        }


        public static void Update(Nivel x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Nivel
                          where o.Id == x.Id
                          select o).First();

            res.Descripcion = x.Descripcion;
            res.Descuento = x.Descuento;
            res.MontoMatricula = x.MontoMatricula;

            dbContext.SaveChanges();
        }



        public static void Insert(Nivel x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();
            dbContext.Nivel.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Nivel
                         where c.Id == id
                         select c;

            if (res.Count() > 0)
            {
                dbContext.Nivel.Remove(res.First());
                dbContext.SaveChanges();
            }
        }
    }
}
