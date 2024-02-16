using ControleDeUsuarios.Data;
using ControleDeUsuarios.Repositorios;
using ControleDeUsuarios.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurando o contexto do EntityFramework
builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<ControleUsuariosDbContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database"))
    );

// Injeção de dependência
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

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
