using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;

namespace ControlObjects
{
   public static class UserManager
    {

       public static IEnumerable<User> Get(string username,string password)
       {
           SchoolDbContext dbContext = new SchoolDbContext();

           var res = from u in dbContext.User.Include("TipoUsuario")
                     where username == u.Email && password == u.Psw
                      select u;

           return res.ToList();
       }

        public static IEnumerable<User> Get(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.User.Include("TipoUsuario")
                      where c.Id == id
                      select c;

            return res.ToList();
        }


        public static IEnumerable<User> CheckUserName(long id, string username)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.User.Include("TipoUsuario")
                      where c.Id != id && c.Email == username
                      select c;

            return res.ToList();
        }

        public static IEnumerable<User> CheckUserName(string username)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.User.Include("TipoUsuario")
                      where c.Email == username
                      select c;

            return res.ToList();
        }

        public static IEnumerable<User> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.User.Include("TipoUsuario")
                      select c;

            return res.ToList();
        }

        public static IEnumerable<User> GetTutor()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.User.Include("TipoUsuario")
                      where c.TipoUsuario.Descripcion.ToLower().Contains("tutor")
                      select c;

            return res.ToList();
        }


        public static void Update(User x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.User
                       where o.Id == x.Id
                       select o).First();

            res.Apellido = x.Apellido;
            res.Direccion= x.Direccion;
            res.Dni = x.Dni;
            res.Email = x.Email;
            res.Nombre = x.Nombre;


            res.TipoUsuario = (from c in dbContext.UserType
                               where c.Id == x.TipoUsuario.Id
                               select c).First();

            dbContext.Entry(res.TipoUsuario).State = System.Data.EntityState.Unchanged;

            res.Psw = x.Psw;
            res.Telefono = x.Telefono;
            

            dbContext.SaveChanges();
        }



        public static void Insert(User x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();
            x.TipoUsuario = UserTypeManager.Get((int)x.TipoUsuario.Id).First();

            dbContext.Entry(x.TipoUsuario).State = System.Data.EntityState.Unchanged;

            dbContext.User.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(int id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.User
                      where c.Id == id
                      select c;

            if (res.Count() > 0)
            {
                dbContext.User.Remove(res.First());
                dbContext.SaveChanges();
            }
        }

    }
}
