namespace BondHealth.Services.HttpMethods
{
  public interface IHttpPut<T>
  {
    // T
    T Update(int id, T model);
  }
}