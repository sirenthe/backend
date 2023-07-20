using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using P330Pronia.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});


var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute(

	name:"default",
	pattern:"{controller=Home}/{action=Id?}"
	);

app.Run();
