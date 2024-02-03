using CleanMovie.Application;
using CleanMovie.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddScoped<IMovieRepository, MovieRepository>();

builder.Services.AddControllers();

// Register the IMovieService implementation with the DI container
builder.Services.AddScoped<IMovieService, MovieService>(); // Replace 'MovieServiceImpl' with your actual service implementation class

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
