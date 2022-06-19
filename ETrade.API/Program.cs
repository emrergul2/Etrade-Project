using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using ETrade.API.Identity;
using ETrade.API.Modules;
using ETrade.Repository.Contexts;
using ETrade.Service.Mapping;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var sqlConBuilder = new SqlConnectionStringBuilder();
sqlConBuilder.ConnectionString = builder.Configuration.GetConnectionString("ETradeMsSql");
sqlConBuilder.UserID = builder.Configuration["UserId"];
sqlConBuilder.Password = builder.Configuration["Password"];

builder.Services.AddDbContext<ETradeMsSqlContext>(x =>
{
    x.UseSqlServer(sqlConBuilder.ConnectionString, option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(ETradeMsSqlContext)).GetName().Name);
    });
});

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepositoryServiceModule()));

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

var sqlConBuilder2 = new SqlConnectionStringBuilder();
sqlConBuilder2.ConnectionString = builder.Configuration.GetConnectionString("IdentityMsSql");
sqlConBuilder2.UserID = builder.Configuration["UserId"];
sqlConBuilder2.Password = builder.Configuration["Password"];
builder.Services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(sqlConBuilder2.ConnectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<AppIdentityDbContext>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
        .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
        {
            options.SlidingExpiration = true;
            options.ExpireTimeSpan = new TimeSpan(0, 1, 0);
        });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
