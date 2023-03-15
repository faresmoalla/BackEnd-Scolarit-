using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Naxxum.Enlightenment.Salle.Application.Interfaces;
using Naxxum.Enlightenment.Salle.Application.Repositories;
using Naxxum.Enlightenment.Salle.Application.Services;
using Naxxum.Enlightenment.Salle.Infrastructure;

using Naxxum.Enlightenment.Salle.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
builder.Services.AddSqlServer<AppDbContext>(
    builder.Configuration.GetConnectionString("DefaultConnection"), null,
    optionsBuilder => optionsBuilder.EnableSensitiveDataLogging(builder.Environment.IsDevelopment()));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IBlocService, BlocService>();
builder.Services.AddCors();

builder.Services.AddScoped<IBlocRepository, BlocRepository>();
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddControllers();
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

/*
using (var context = new AppDbContext())
{
    context.Database.Migrate();
}*/
app.UseAuthorization();

app.MapControllers();

app.Run();
