using Myproject;
using Solid.Core.Repository;
using Solid.Core.Servise;
using Solid.Data;
using Solid.Servise;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<DataContext>();
builder.Services.AddScoped<ICityServise, CityServise>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<ICourseServise, CorseServise>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();


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
