using System.Text;
using System.Text.Json;
using BondHealth.Helpers.Interfaces;
using BondHealth.Models.MailerSend;

namespace BondHealth.Helpers
{
  public sealed class MailerSendClient: IMailClient
  {
    private static MailerSendClient instance = null;
    private readonly HttpClient _httpClient = new HttpClient();
    private MailerSendClientOptions _options {get; set;}
    public static MailerSendClient Intance
    {
      get
      {
        if (instance == null)
        {
          instance = new MailerSendClient();
        }
        
        return instance;
      }
    }

    public void AddOptions(MailerSendClientOptions options)
    {
      _options = options;
    }

    public async Task<string> SendEmail(Email data)
    {
      using HttpResponseMessage response = await PostEmail(data);
      return await response.Content.ReadAsStringAsync();
    }

    private async Task<HttpResponseMessage> PostEmail (Email data)
    {
      // Serialize email information
      StringContent content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
      
      _httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");
      _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_options.ApiToken}");
      
      // using HttpRequestMessage request = new(HttpMethod.Post, _options.ApiUrl);
      // request.Headers.Add("ContentType", "application/json");
      // request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _options.ApiToken);
      // request.Content = content;

      // using HttpResponseMessage response = await _httpClient.SendAsync(request);
      HttpResponseMessage response = await _httpClient.PostAsync(_options.ApiUrl, content);

      response.EnsureSuccessStatusCode();

      var jsonResponse = await response.Content.ReadAsStringAsync();
      Console.WriteLine($"{jsonResponse}");

      return response;
    }
  }
}