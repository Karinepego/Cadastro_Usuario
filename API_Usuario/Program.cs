using Pomelo.EntityFrameworkCore.MySql;
using API_Usuario.Models;
using Microsoft.EntityFrameworkCore;
using API_Usuario.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<_DbContext>(x => x.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConection"),
        ServerVersion.Parse("10.4.22")// nao sei a versão do meu sql
    ));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

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
