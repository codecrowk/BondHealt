using System.Text.Json.Serialization;

namespace BondHealth.Models.MailerSend
{
  public class Recipent
  {
    [JsonPropertyName("email")]
    public string Email {get; set;}

    [JsonPropertyName("name")]
    public string? Name {get; set;}
  }
}