using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
    public static class FacturaManager
    {

        public static IEnumerable<Factura> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Factura
                      where c.Id == id
                      select c;

            return res.ToList();
        }


        public static IEnumerable<Factura> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Factura
                      select c;

            return res.ToList();
        }

    }
}
