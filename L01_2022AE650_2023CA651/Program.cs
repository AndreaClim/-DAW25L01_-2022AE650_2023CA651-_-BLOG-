using Microsoft.EntityFrameworkCore;
using L01_2022AE650_2023CA651.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<usuariosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("blogDbConnection")));

builder.Services.AddDbContext<comentariosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("blogDbConnection")));

builder.Services.AddDbContext<publicacionesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("blogDbConnection")));



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
