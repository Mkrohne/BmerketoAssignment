using WebApp.Contexts;
using WebApp.Models.ViewModels;
using WebApp.Helpers.Services;
using WebApp.Helpers.Repositories;
using WebApp.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<UserAdminService>();

//Context
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("sql")));

//Auth
builder.Services.AddIdentity<UserEntity, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<DataContext>();

//Reops
builder.Services.AddScoped<AddressRepo>();
builder.Services.AddScoped<UserAddressRepo>();
builder.Services.AddScoped<ContactFormRepo>();
builder.Services.AddScoped<ProductRepo>();
builder.Services.AddScoped<ProductCategoryRepo>();
builder.Services.AddScoped<CategoryRepo>();

builder.Services.AddTransient<GridCollectionItemViewModel>();
builder.Services.AddTransient<ProductEntity>();
builder.Services.AddTransient<ProductCategoryEntity>();
builder.Services.AddTransient<CategoryEntity>();
builder.Services.AddTransient<ContactFormEntity>();



var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
