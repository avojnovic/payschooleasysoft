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

           var res = from c in dbContext.Cuota
                     where c.Id == id
                     select c;

           return res.ToList();
       }

       public static IEnumerable<Cuota> GetByYear(long year)
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = from c in dbContext.Cuota
                     where c.Anio == year
                     select c;

           return res.ToList();
       }


       public static IEnumerable<Cuota> Get()
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = from c in dbContext.Cuota
                     select c;

           return res.ToList();
       }



    }
}
