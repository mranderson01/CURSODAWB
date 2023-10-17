using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnimalApp.Models;

namespace AnimalApp.Data
{
    public class AnimalAppContext : DbContext
    {
        public AnimalAppContext (DbContextOptions<AnimalAppContext> options)
            : base(options)
        {
        }
        public DbSet<AnimalApp.Models.Animal>? Animal { get; set; }
        public DbSet<AnimalApp.Models.Propietario>? Propietario { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasOne(p=>p.propietario)
                .WithMany(a=>a.Animales)
                .HasForeignKey(a => a.idPropietario);

            // Otras configuraciones de modelo aquí, si las tienes
            modelBuilder.Entity<Animal>().HasData(
                    new Animal
                    {
                        Id = 1,
                        Name = "Fitipanlis",
                        Description = "Es un gato de color negro y blanco",
                        idPropietario= 1,
                    },
                    new Animal
                    {
                        Id = 2,
                        Name = "Renekton",
                        Description = "Es un crocodilo muy grande",
                        idPropietario= 2,
                    }
            );

            modelBuilder.Entity<Propietario>().HasData(
                new Propietario
                {
                    Id = 1,
                    Name = "Jhenny",
                    Surname = "Alaca",
                    Number = "666 666 666",
                    Animales = { }
                },
                new Propietario
                {
                    Id = 2,
                    Name = "Rodrigo",
                    Surname = "Sucapuca Alaca",
                    Number = "666 666 666",
                    Animales = { }
                }
            );
        } 
        

    }
}
