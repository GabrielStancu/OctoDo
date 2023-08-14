using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OctoDo.Server.Application.Interfaces;
using OctoDo.Server.Application.Services;
using OctoDo.Server.Infrastructure.Authentication;
using OctoDo.Server.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);
var connection = builder.Environment.IsDevelopment() 
    ? builder.Configuration.GetConnectionString("AzureSqlConnectionString") 
    : Environment.GetEnvironmentVariable("AzureSqlConnectionString");

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connection));

// Identity
builder.Services.AddDbContext<AppIdentityDbContext>(options =>
    options.UseSqlServer(connection));
builder.Services.AddIdentity<AppUser, IdentityRole>(options => {
        options.SignIn.RequireConfirmedAccount = false;
    }).AddEntityFrameworkStores<AppDbContext>();

// Cors
builder.Services.AddCors(opt => {
    opt.AddPolicy(name: "AllowOrigins", policy => {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Services
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<IJwtService, JwtService>();

// Configurations
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("Jwt"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowOrigins");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
