using BondHealth.Models;
using Microsoft.EntityFrameworkCore;

namespace BondHealth.Data
{
  public class BaseContext: DbContext
  {
    public BaseContext(DbContextOptions<BaseContext> options): base(options)
    { }

    // Remember that model is singular, and table is plural
    // DbSet<Model> SqlTable
    public DbSet<Doctor> Doctors {get; set;}
    public DbSet<Patient> Patients {get; set;}
    public DbSet<Specialty> Specialties {get; set;}

  }
}
