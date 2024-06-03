namespace BondHealth.Models
{
  public class Patient
  {
    // A good part of models have ID
    public int Id {get; set;}
    public string Name {get; set;}
    public string LastName {get; set;}
    public DateOnly BirthDate {get; set;}
    public string Email {get; set;}
    public string Phone {get; set;}
    public string Address {get; set;}
    public string Status {get; set;}
  }
}
