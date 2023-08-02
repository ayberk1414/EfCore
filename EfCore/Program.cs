using EfCore.Models.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContextPool<MyContext>(opt=>opt.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CodeFirstDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
var app = builder.Build();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=GetCategories}");

app.Run();
