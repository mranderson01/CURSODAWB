using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace seguridad2.Data;

public class seguridad2Context : IdentityDbContext
{
    public seguridad2Context(DbContextOptions<seguridad2Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { 

            }
        );
        base.OnModelCreating(builder); 
    }
}
