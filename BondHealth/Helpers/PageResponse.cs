namespace BondHealth.Helpers
{
  public class PageResponse<T>: Response<T>
  {
    public int CurrentPage {get; set;}
    public int NextPage {get; set;}
    public int PageSize {get; set;}

    public PageResponse(T data, int currentPage, int nextPage, int pageSize, string message)
    : base(data, message)
    {
      CurrentPage = currentPage;
      NextPage = nextPage;
      PageSize = pageSize;
    }
  }
}