using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OctoDo.Authentication.Business.Authentication;
using OctoDo.Authentication.Business.Configuration;
using OctoDo.Authentication.Business.Identity;
using OctoDo.Authentication.Business.Jwt;
using OctoDo.Authentication.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Identity
builder.Services.AddDbContext<AppIdentityDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityDb")));
builder.Services.AddIdentity<AppUser, IdentityRole>(options => {
    options.SignIn.RequireConfirmedAccount = false;
}).AddEntityFrameworkStores<AppIdentityDbContext>();

// Services
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<IJwtService, JwtService>();

// Configurations
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection(JwtSettings.Jwt));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
