using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BankingWebApi.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BankingWebApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevDb") 
            ?? throw new InvalidOperationException("Connection string 'DevDb' not found.")));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
