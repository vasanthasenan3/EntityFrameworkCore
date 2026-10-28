using Asp.netpractice;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var conection = builder.Configuration.GetConnectionString("JsCon");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conection));
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(name: "default",
    pattern: "{Controller=Home}/{Action=SaveData}/{ID?}");

app.Run();
