
using App.Domain.AppServices.Units;
using App.Domain.Core.Units.AppServices;
using App.Domain.Core.Units.Data.Repositories;
using App.Domain.Core.Units.Services;
using App.Domain.Services.Units;
using App.Infa.Data.Db.SqlServer.Ef.DbCtx;
using App.Infra.Data.Repos.Ef.Units;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


    ;

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(@"Server=DESKTOP-OG56BKU;Integrated Security=true;Database=BamdadShopDb3;TrustServerCertificate=True;").LogTo(Console.WriteLine));

builder.Services.AddIdentity<User, Role>(option =>
{
    option.Password.RequireUppercase = false;
    option.Password.RequireLowercase = false;
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequiredLength = 6;
    option.Password.RequiredUniqueChars = 2;
}
).AddEntityFrameworkStores<AppDbContext>();



builder.Services.AddScoped<IUnitAppService , UnitAppService>();
builder.Services.AddScoped<IUnitService, UnitService>();
builder.Services.AddScoped<IUnitQueryRepository, UnitQueryRepository>();
builder.Services.AddScoped<IUnitCommandRepository, UnitCommandRepository>();




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



app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//      name: "areas",
//      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );
//})


app.Run();
