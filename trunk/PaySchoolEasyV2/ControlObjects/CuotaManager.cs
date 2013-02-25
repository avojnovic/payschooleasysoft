using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
   public static class CuotaManager
    {

       public static IEnumerable<Cuota> Get(long id)
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = from c in dbContext.Cuota.Include("Nivel")
                     where c.Id == id
                     select c;

           return res.ToList();
       }

       public static IEnumerable<Cuota> GetByYear(long year)
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = from c in dbContext.Cuota.Include("Nivel")
                     where c.Anio == year
                     select c;

           return res.ToList();
       }

       public static IEnumerable<Cuota> GetByYearNivel(long year,long nivel)
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = from c in dbContext.Cuota.Include("Nivel")
                     where c.Anio == year && c.Nivel.Id==nivel
                     select c;

           return res.ToList();
       }

       public static IEnumerable<Cuota> Get()
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = from c in dbContext.Cuota.Include("Nivel")
                     select c;

           return res.ToList();
       }

       public static void Update(Cuota x)
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = (from o in dbContext.Cuota.Include("Nivel")
                      where o.Id == x.Id
                      select o).First();

           res.Anio = x.Anio;
           res.FechaVenc1 = x.FechaVenc1;
           res.FechaVenc2= x.FechaVenc2;
           res.Mes= x.Mes;

           res.MontoCuota= x.MontoCuota;


           res.Nivel = (from c in dbContext.Nivel
                        where c.Id == x.Nivel.Id
                        select c).First();

           dbContext.Entry(res.Nivel).State = System.Data.EntityState.Unchanged;


           dbContext.SaveChanges();
       }



       public static void Insert(Cuota x)
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           x.Nivel = NivelManager.Get((int)x.Nivel.Id).First();
           dbContext.Entry(x.Nivel).State = System.Data.EntityState.Unchanged;

           dbContext.Cuota.Add(x);
           dbContext.SaveChanges();
       }


       public static void Delete(int id)
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = from c in dbContext.Cuota.Include("Nivel")
                     where c.Id == id
                     select c;

           if (res.Count() > 0)
           {
               dbContext.Cuota.Remove(res.First());
               dbContext.SaveChanges();
           }
       }


       public static bool Validar(Cuota x, bool update)
       {
           SchoolDbContext dbContext = new SchoolDbContext();
           int count = 0;

           if (update)
           {
               var res = (from o in dbContext.Cuota.Include("Nivel")
                          where o.Id != x.Id && o.Anio == x.Anio && o.Mes==x.Mes && o.Nivel.Id==x.Nivel.Id
                          select o);
               count = res.Count();

           }
           else
           {
               var res = (from o in dbContext.Cuota.Include("Nivel")
                          where o.Anio == x.Anio && o.Mes == x.Mes && o.Nivel.Id == x.Nivel.Id
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

    }
}
