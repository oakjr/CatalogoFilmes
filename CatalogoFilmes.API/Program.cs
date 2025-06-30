using CatalogoFilmes.Application.Repositories;
using CatalogoFilmes.Application.Services;
using CatalogoFilmes.Domain.Interfaces;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Injeção de dependência
builder.Services.AddSingleton<IFilmeRepository, FilmeRepositoryMock>();
builder.Services.AddTransient<FilmeService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
