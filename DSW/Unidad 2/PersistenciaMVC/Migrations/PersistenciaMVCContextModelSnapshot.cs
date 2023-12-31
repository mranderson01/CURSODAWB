﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersistenciaMVC.Data;
using PersistenciaMVC.Models;

#nullable disable

namespace PersistenciaMVC.Migrations
{
    [DbContext(typeof(PersistenciaMVCContext))]
    partial class PersistenciaMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            #pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersistenciaMVC.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMamifero")
                        .HasColumnType("int");

                    b.Property<int>("IdReptil")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animal");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Animal");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("PersistenciaMVC.Models.Mamifero", b =>
                {
                    b.HasBaseType("PersistenciaMVC.Models.Animal");

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.HasIndex("AnimalId");

                    b.HasDiscriminator().HasValue("Mamifero");
                });

            modelBuilder.Entity("PersistenciaMVC.Models.Reptil", b =>
                {
                    b.HasBaseType("PersistenciaMVC.Models.Animal");

                    b.Property<int?>("AnimalId")
                        .HasColumnType("int");

                    b.HasIndex("AnimalId");

                    b.ToTable("Animal", t =>
                        {
                            t.Property("AnimalId")
                                .HasColumnName("Reptil_AnimalId");
                        });

                    b.HasDiscriminator().HasValue("Reptil");
                });

            modelBuilder.Entity("PersistenciaMVC.Models.Mamifero", b =>
                {
                    b.HasOne("PersistenciaMVC.Models.Animal", null)
                        .WithMany("Mamifero")
                        .HasForeignKey("AnimalId");
                });

            modelBuilder.Entity("PersistenciaMVC.Models.Reptil", b =>
                {
                    b.HasOne("PersistenciaMVC.Models.Animal", null)
                        .WithMany("Reptil")
                        .HasForeignKey("AnimalId");
                });

            modelBuilder.Entity("PersistenciaMVC.Models.Animal", b =>
                {
                    b.Navigation("Mamifero");

                    b.Navigation("Reptil");
                });
                #pragma warning restore 612, 618
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Animal>().HasData(
                new Animal
                {
                     Id = 1,
                     Name = "Fido",
                     Description = "Un perro juguetón",
                     Age = 3
                }, 
                new Animal{
                    Id = 2,
                    Name = "Whiskers",
                    Description = "Un gato curioso",
                    Age = 2
                },

                new Animal
                {
                    Id = 3,
                    Name = "Polly",
                    Description = "Un loro parlante",
                    Age = 5
                }

            ); ;
        }
    }
}
