using Microsoft.EntityFrameworkCore;
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

// Cors
builder.Services.AddCors(opt => {
    opt.AddPolicy(name: "AllowOrigins", policy => {
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Services

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
