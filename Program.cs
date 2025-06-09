using backend.Context;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using Microsoft.Extensions.Options;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

string conn = Environment.GetEnvironmentVariable("MY_CONN_STRING");

// Add services to the container.


builder.Services.AddControllers();

builder.Services.AddDbContext<CspsContext>(opt =>
   opt.UseMySql(
                conn,
                new MySqlServerVersion(new Version(10, 5, 0))
                )
);
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
