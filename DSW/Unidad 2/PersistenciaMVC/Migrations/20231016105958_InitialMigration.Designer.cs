﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersistenciaMVC.Data;

#nullable disable

namespace PersistenciaMVC.Migrations
{
    [DbContext(typeof(PersistenciaMVCContext))]
    [Migration("20231016105958_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
    }
}
