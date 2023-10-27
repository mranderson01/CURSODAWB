using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using seguridad2.Data;
using seguridad2.Models;

var builder = WebApplication.CreateBuilder(args);

//SEGURIDAD PARA USUARIO Y ROL
builder.Services
    .AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<seguridad2Context>();
 
//CONEXION a la base de datos de usuarios,etc
var connectionString = builder.Configuration
    .GetConnectionString("seguridad2") ?? throw new InvalidOperationException("Connection string 'seguridad2ContextConnection' not found.");
builder.Services
    .AddDbContext<seguridad2Context>(options =>options
    .UseSqlServer(connectionString));

//CONEXION a la base de datos de Northwind
var connectionString2 = builder.Configuration
    .GetConnectionString("Northwind") ?? throw new InvalidOperationException("Connection string 'Northwind' not found.");
builder.Services
    .AddDbContext<NorthwindContext>(options =>options.UseSqlServer(connectionString2));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//ESTO ES IMPORTANTE
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
