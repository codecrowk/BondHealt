using BondHealth.Data;
using BondHealth.Services.DoctorsRepository;
using BondHealth.Services.PatientsRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//----- PERSONAL SERVICES -----//

// BaseContext: Intance of DbContext
builder.Services.AddDbContext<BaseContext> ( options => 
  options.UseMySql
  (
    // MySqlConnection: Alias use in appsettings.json to link mysql database
    builder.Configuration.GetConnectionString("MySqlConnection"),

    // 8.0.20-mysql: Version of Pomelo SQL
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")
  )
);

// Inyection of dependencies in Controllers
builder.Services.AddScoped<IDoctorsRepository, DoctorsRepository>();
builder.Services.AddScoped<IPatientsRepository, PatientsRepository>();

//----- END PERSONAL SERVICES -----//
var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
