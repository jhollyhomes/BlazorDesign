namespace SideMenuDesign.Models;

public class QueryResult<T>
{
    public List<T> Data { get; set; }
    public int Count { get; set; }

}
