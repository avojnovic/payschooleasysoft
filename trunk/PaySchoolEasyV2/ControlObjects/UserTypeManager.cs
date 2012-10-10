using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
   public static class UserTypeManager
    {


        public static IEnumerable<UserType> Get(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.UserType
                      where c.Id == id
                      select c;

            return res.ToList();
        }

        public static IEnumerable<UserType> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.UserType
                      select c;

            return res.ToList();
        }


        public static void Update(UserType x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.UserType
                       where o.Id == x.Id
                       select o).First();

            res.Descripcion = x.Descripcion;
            res.Borrado = x.Borrado;


            dbContext.SaveChanges();
        }



        public static void Insert(UserType x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();
            dbContext.UserType.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.UserType
                      where c.Id == id
                      select c;

            if (res.Count() > 0)
            {
                dbContext.UserType.Remove(res.First());
                dbContext.SaveChanges();
            }
        }
    }
}
