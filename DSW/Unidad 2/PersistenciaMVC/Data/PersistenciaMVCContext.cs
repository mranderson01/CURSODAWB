using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PersistenciaMVC.Models;

namespace PersistenciaMVC.Data
{
    public class PersistenciaMVCContext : DbContext
    {
        public PersistenciaMVCContext (DbContextOptions<PersistenciaMVCContext> options)
            : base(options)
        {
        }

        public DbSet<PersistenciaMVC.Models.Animal> Animal { get; set; } = default!;

        public DbSet<PersistenciaMVC.Models.Mamifero> Mamifero { get; set; }

        public DbSet<PersistenciaMVC.Models.Reptil> Reptil { get; set; }


    }
}
