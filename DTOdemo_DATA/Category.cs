namespace DTOdemo_DATA;

public class Category
{
    public Category()
    {
        Books = new List<Book>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Book> Books { get; set; }

}
