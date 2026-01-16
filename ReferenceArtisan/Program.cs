using Microsoft.EntityFrameworkCore;
using ReferenceArtisan.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
  options.UseSqlServer("name=DefaultConnection")
);
var app = builder.Build();
app.MapControllers();
app.Run();