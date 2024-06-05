using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BondHealth.Models
{
  public class Specialty
  {
    // A good part of models have ID
    [Key]
    public int Id {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public string Status {get; set;}
    [JsonIgnore]
    public List<Doctor>? Doctors {get; set;}
  }
}
