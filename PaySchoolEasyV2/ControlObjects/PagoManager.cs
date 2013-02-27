using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
    public static class PagoManager
    {

        public static IEnumerable<Pago> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Pago
                      where c.Id == id
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Pago> GetByCuota(long idCuota,long idAlumno)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Pago.Include("Cuota").Include("Alumno")
                      where c.Cuota.Id == idCuota && c.Alumno.Id == idAlumno
                      select c;

            return res.ToList();
        }


        public static IEnumerable<Pago> GetByMatricula(long idMatricula, long idAlumno)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Pago.Include("Matricula").Include("Alumno")
                      where c.Matricula.Id == idMatricula && c.Alumno.Id == idAlumno
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Pago> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Pago
                      select c;

            return res.ToList();
        }


        public static void Update(Pago x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Pago
                       where o.Id == x.Id
                       select o).First();


            res.Alumno = (from c in dbContext.Alumno.Include("Usuario")
                          where c.Id == x.Alumno.Id
                          select c).First();
            dbContext.Entry(res.Alumno).State = System.Data.EntityState.Unchanged;

            if (x.Cuota != null)
            {
                res.Cuota = (from c in dbContext.Cuota.Include("Nivel")
                             where c.Id == x.Cuota.Id
                             select c).First();
                dbContext.Entry(res.Cuota).State = System.Data.EntityState.Unchanged;
            }

            res.Factura = (from c in dbContext.Factura
                           where c.Id == x.Factura.Id
                           select c).First();
            dbContext.Entry(res.Factura).State = System.Data.EntityState.Unchanged;

            if (x.Matricula != null)
            {
                res.Matricula = (from c in dbContext.Matricula.Include("Nivel")
                                 where c.Id == x.Matricula.Id
                                 select c).First();
                dbContext.Entry(res.Matricula).State = System.Data.EntityState.Unchanged;
            }

            if (x.Recargos != null)
            {
                res.Recargos = (from c in dbContext.Recargos
                                where c.Id ==x.Recargos.Id
                                select c).First();
                dbContext.Entry(res.Recargos).State = System.Data.EntityState.Unchanged;
            }

            res.Confirmado = x.Confirmado;
        

            dbContext.SaveChanges();
        }



        public static void Insert(Pago x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            x.Alumno = AlumnoManager.Get((int)x.Alumno.Id).First();
            dbContext.Entry(x.Alumno).State = System.Data.EntityState.Unchanged;

            if (x.Cuota != null)
            {
                x.Cuota = (from c in dbContext.Cuota.Include("Nivel")
                             where c.Id == x.Cuota.Id
                             select c).First();
                dbContext.Entry(x.Cuota).State = System.Data.EntityState.Unchanged;
            }

            //if (x.Factura != null)
            //{
            //    x.Factura = FacturaManager.Get((int)x.Factura.Id).First();
            //    dbContext.Entry(x.Factura).State = System.Data.EntityState.Unchanged;
            //}

            if (x.Matricula != null)
            {
                x.Matricula = (from c in dbContext.Matricula.Include("Nivel")
                                 where c.Id == x.Matricula.Id
                                 select c).First();
                dbContext.Entry(x.Matricula).State = System.Data.EntityState.Unchanged;
            }

            if (x.Recargos != null)
            {
                x.Recargos = (from c in dbContext.Recargos
                                where c.Id == x.Recargos.Id
                                select c).First();
                dbContext.Entry(x.Recargos).State = System.Data.EntityState.Unchanged;
            }



            dbContext.Pago.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Pago
                      where c.Id == id
                      select c;

            if (res.Count() > 0)
            {
                dbContext.Pago.Remove(res.First());
                dbContext.SaveChanges();
            }
        }
    }
}
