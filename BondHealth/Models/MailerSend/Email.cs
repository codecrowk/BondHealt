using System.Text.Json.Serialization;
// using Newtonsoft.Json;

namespace BondHealth.Models.MailerSend
{
  public class Email
  {
    [JsonPropertyName("from")]
    public Recipent? From {get; set;}

    [JsonPropertyName("to")]
    public Recipent[]? To {get; set;}

    [JsonPropertyName("subject")]
    public string? Subject {get; set;}

    [JsonPropertyName("text")]
    public string? Text {get; set;}

    [JsonPropertyName("html")]
    public string? Html {get; set;}
  }
}