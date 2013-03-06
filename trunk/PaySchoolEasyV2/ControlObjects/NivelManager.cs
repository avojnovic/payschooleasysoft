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

        public static IEnumerable<Nivel> GetByEdad(double edad)
        {

            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Nivel
                      where edad>=c.EdadMinima && edad<=c.EdadMaxima
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
            res.EdadMaxima= x.EdadMaxima;
            res.EdadMinima= x.EdadMinima;
            res.Descuento = x.Descuento;
            res.RecargoPrimerVencimiento = x.RecargoPrimerVencimiento;
            res.RecargoSegundoVencimiento = x.RecargoSegundoVencimiento;
       

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
