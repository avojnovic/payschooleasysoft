using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BussinesObjects;
using System.Data.Objects;

namespace ControlObjects
{
   public static class InscripcionManager
    {

        
        public static IEnumerable<Inscripcion> Get(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                      where c.Id == id
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Inscripcion> GetByTutor(User user)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                      select c;

            List<Inscripcion> list = new List<Inscripcion>();
            foreach (Inscripcion i in res)
            {
                i.Alumno = AlumnoManager.Get(i.Alumno.Id).First();

                if (i.Alumno.Usuario.Id == user.Id)
                {
                    i.Curso=CursoManager.Get(i.Curso.Id).First();
                    list.Add(i);
                }

            }

            return list;
        }

        public static IEnumerable<Inscripcion> GetByAlumno(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                      where c.Alumno.Id == id
                      select c;

            return res.ToList();
        }

        public static IEnumerable<Inscripcion> GetByCurso(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                      where c.Curso.Id == id
                      select c;

            return res.ToList();
        }


        public static IEnumerable<Inscripcion> GetByAlumnoAnio(long idAlumno,int anio)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                      where c.Alumno.Id == idAlumno && c.FechaInscripción.Year==anio
                      select c;


            return res.ToList();
        }

        public static IEnumerable<Inscripcion> Get()
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                      select c;

            return res.ToList();
        }

        public static void Update(Inscripcion x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = (from o in dbContext.Inscripcion.Include("Alumno").Include("Curso")
                       where o.Id == x.Id
                       select o).First();

            res.FechaInscripción = x.FechaInscripción;
            res.Inscripto = x.Inscripto;
            res.EnListaDeEspera = x.EnListaDeEspera;


            res.Alumno = (from c in dbContext.Alumno.Include("Usuario")
                          where c.Id == x.Alumno.Id
                          select c).First();

            dbContext.Entry(res.Alumno).State = System.Data.EntityState.Unchanged;


            res.Curso = (from c in dbContext.Curso.Include("Nivel")
                      where c.Id == x.Curso.Id
                      select c).First();

            dbContext.Entry(res.Curso).State = System.Data.EntityState.Unchanged;
            
            dbContext.SaveChanges();
        }



        public static void Insert(Inscripcion x)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            x.Alumno = AlumnoManager.Get((int)x.Alumno.Id).First();
            dbContext.Entry(x.Alumno).State = System.Data.EntityState.Unchanged;

            x.Curso = CursoManager.Get((int)x.Curso.Id).First();
            dbContext.Entry(x.Curso).State = System.Data.EntityState.Unchanged;


            dbContext.Inscripcion.Add(x);
            dbContext.SaveChanges();
        }


        public static void Delete(long id)
        {
            SchoolDbContext dbContext = new SchoolDbContext();

            var res = from c in dbContext.Inscripcion
                      where c.Id == id
                      select c;

            if (res.Count() > 0)
            {
                dbContext.Inscripcion.Remove(res.First());
                dbContext.SaveChanges();
            }
        }


       
    }
}
