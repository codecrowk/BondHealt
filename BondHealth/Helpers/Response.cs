namespace BondHealth.Helpers
{
  public class Response<T>
  {
    public T Data {get; set;}
    public bool Succeded {get; set;}
    public string Message {get; set;}
    public Response()
    { }

    public Response(T data, string message)
    {
      Succeded = true;
      Message = message;
      Data = data;
    }
  }
}