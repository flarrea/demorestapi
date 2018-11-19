using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmpleadoWebApi.Models
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext (DbContextOptions<EmpleadoContext> options)
            : base(options)
        {
        }

        public DbSet<EmpleadoWebApi.Models.Empleado> Empleado { get; set; }
    }
}
