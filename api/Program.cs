
using Microsoft.EntityFrameworkCore;
using persistence;
using persistence.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddDbContext<AppDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("Server=DESKTOP-6H6EI1H\\SQLEXPRESS;Database=healthCare;Trusted_Connection=True;MultipleActiveResultSets=true"));
//});
builder.Services.AddAppDbContext();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
