using Microsoft.EntityFrameworkCore;
using RoutingEngine.Domain.Repositories;
using RoutingEngine.Persistence;
using RoutingEngine.Services;
using RoutingEngine.Services.Abstractions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Dependecy Injection
builder.Services.AddScoped<ILogService, LogService>();
builder.Services.AddScoped<ILogRepository, LogRespository>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContextPool<RepositoryContext>(contextBuilder =>
{
    contextBuilder.UseSqlite(@"Data Source=./Logging.db");
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var allowedOrigins = "_allowedOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(allowedOrigins, corsBuilder =>
    {
        corsBuilder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(allowedOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
