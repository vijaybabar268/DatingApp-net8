using API.Data;
using Microsoft.EntityFrameworkCore;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<DatingDataContext>(opt => 
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultCS"));
});
builder.Services.AddCors();


// Configure the HTTP request pipeline.
var app = builder.Build();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200","https://localhost:4200"));
app.MapControllers();
app.Run();
