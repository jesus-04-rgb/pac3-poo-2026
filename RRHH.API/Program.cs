using Scalar.AspNetCore;
using RRHH.API.Services.Employees;
using RRHH.API.Services.Feedbacks;
using Microsoft.EntityFrameworkCore;
using RRHH.API.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddDbContext<RRHHDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IFeedbackService, FeedbackService>(); //inyección de dependencias para el servicio de feedbacks


var app = builder.Build();  


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
