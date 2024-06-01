namespace BondHealth.Services.HttpMethods
{
  public interface IHttpPost<T>
  {
    T Create(T model); 
  }
}
