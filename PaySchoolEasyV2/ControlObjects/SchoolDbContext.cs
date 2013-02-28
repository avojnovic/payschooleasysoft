using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BussinesObjects;

namespace ControlObjects
{
    public class SchoolDbContext : DbContext
    {
       
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Cuota> Cuota { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<Pago> Pago { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserType> UserType { get; set; }

    }
}