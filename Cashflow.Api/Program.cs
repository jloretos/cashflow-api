
using Cashflow.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Cashflow.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<CashflowDbContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Database=cashflow;Username=postgres;Password=postgres"));

builder.Services.AddScoped<CashflowService>();    
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
