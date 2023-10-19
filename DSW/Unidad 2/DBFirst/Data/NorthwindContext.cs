using System;
using System.Collections.Generic;
using DBFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DBFirst.Data;

public partial class NorthwindContext : DbContext
{
    public NorthwindContext()
    {
    }

    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Supplier> Suppliers { get; set; }
    public virtual DbSet<Shipper> Shippers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //EXCLUIR TABLAS
        modelBuilder.Entity<Supplier>().ToTable("Suppliers",t=>t.ExcludeFromMigrations());
        modelBuilder.Entity<Shipper>().ToTable("Shippers", t => t.ExcludeFromMigrations());

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasIndex(e => e.CompanyName, "CompanyName");

            entity.HasIndex(e => e.PostalCode, "PostalCode");

            entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.ContactName).HasMaxLength(30);
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Region).HasMaxLength(15);
        });

        //SEEDER COMPANY
        modelBuilder.Entity<Company>().HasData(
           new Company
           {
               Id = 1,
               Name = "OneCompany",
               Description = "Es la primera compañia",
           },
           new Company
           {
               Id = 2,
               Name = "TwoCompany",
               Description = "Es la segunda compañia",
           },
           new Company
           {
               Id = 3,
               Name = "ThreeCompany",
               Description = "Es la tercera compañia",
           }
       );

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public DbSet<Company>? Company { get; set; }            
}
