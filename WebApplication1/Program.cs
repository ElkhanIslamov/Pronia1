using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PronioDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
}

);

WebApplication app = builder.Build();


    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action/Index}/{id?}"

    );


    app.MapControllerRoute(
         name: "areas",
         pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
       );

app.UseStaticFiles();   



app.Run();
