using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TurnosBack.Models;
using TurnosBack.Repositories;
using TurnosBack.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers() //agregue esto
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddDbContext<TurnosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString
    ("DefaultConnection")));

builder.Services.AddScoped<IServicioService, ServicioService>();
builder.Services.AddScoped<IServicioRepository, ServicioRepository>();

builder.Services.AddScoped<ITurnosService, TurnoService>();
builder.Services.AddScoped<ITurnosRepository, TurnoRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
