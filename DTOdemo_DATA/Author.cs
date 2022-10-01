namespace DTOdemo_DATA;

public class Author
{
    public Author()
    {
        Books = new List<Book>();
    }

    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string? MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Bio { get; set; } = string.Empty;
    public string? ImageUrl { get; set; } = String.Empty;

    public ICollection<Book> Books { get; set; }

}
