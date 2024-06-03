namespace BondHealth.Models
{
  public class Doctor
  {
    // A good part of models have ID
    public int Id {get; set;}
    public string FullName {get; set;}
    public string Email {get; set;}
    public string Phone {get; set;}
    public string Status {get; set;}
    public int IdSpeciality {get; set;}
  }
}
