using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ejercicio2.Models;

namespace Ejercicio2.Data
{
    public class Ejercicio2Context : DbContext
    {
        public Ejercicio2Context (DbContextOptions<Ejercicio2Context> options)
            : base(options)
        {
        }

        public DbSet<Ejercicio2.Models.Game> Game { get; set; } = default!;

        public DbSet<Ejercicio2.Models.Genre>? Genre { get; set; }
    }
}
