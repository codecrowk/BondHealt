using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BondHealth.Models
{
  public class Doctor
  {
    // A good part of models have ID
    [Key]
    public int Id {get; set;}
    public string FullName {get; set;}
    public string Email {get; set;}
    public string Phone {get; set;}
    public string Status {get; set;}
    public int IdSpecialty {get; set;}

    [ForeignKey("IdSpecialty")]
    public Specialty? Specialty {get; set;}
  }
}
