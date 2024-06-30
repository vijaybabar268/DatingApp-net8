using API.Data;
using Microsoft.EntityFrameworkCore;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<DatingDataContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultCS"));
});

// Configure the HTTP request pipeline.
var app = builder.Build();
app.MapControllers();
app.Run();
