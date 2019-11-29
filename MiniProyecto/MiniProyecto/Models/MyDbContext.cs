using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MiniProyecto.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("Conexion")
        {

        }

        public DbSet<Empleados> empleados { get; set; }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<Cargo> cargos { get; set; }
    }
}