using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
   public static class RecargoManager
    {
        public static IEnumerable<Recargos> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Recargos
                      where c.Id == id
                      select c;

            return res.ToList();
        }


        public static IEnumerable<Recargos> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Recargos
                      select c;

            return res.ToList();
        }
    }
}
