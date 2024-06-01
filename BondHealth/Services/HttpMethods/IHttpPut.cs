namespace BondHealth.Services.HttpMethods
{
  public interface IHttpPut<T>
  {
    // T
    T Update(T model);
  }
}
