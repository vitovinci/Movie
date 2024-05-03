using AutoMapper;
using BLL.Service;
using BLL.Service.Interfaces;
using DAL;
using DAL.Repository;
using DAL.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using PL.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MovieDbContext>(options =>
{
	options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
});

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "cors",
		 policy =>
		 {
			 policy.WithOrigins("http://localhost:4200")
			  .AllowAnyMethod()
			  .AllowAnyHeader()
			  .AllowCredentials();
		 });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors("cors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
