namespace BondHealth.Services.HttpMethods
{
  public interface IHttpGet<T>
  {
    // IEnumerable<T> 
    IEnumerable<T> GetAll();

    // T
    T GetById(int id); 
  }
}
