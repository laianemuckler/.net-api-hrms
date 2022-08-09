using HRMS.Domain.Interfaces.Repositories;
using HRMS.Domain.Interfaces.Services;
using HRMS.Domain.Services;
using HRMS.Infrastructure.Context;
using HRMS.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IContractRepository, ContractRepository>();

builder.Services.AddScoped<IContractService, ContractService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(builder.Configuration
                 .GetConnectionString("DefaultConnection"),
                 b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

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
