namespace DTOdemo_DATA;

public class Book
{
    public Book()
    {
        Authors = new List<Author>();
    }

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Pages { get; set; }
    public string? Edition { get; set; }
    public string? Publisher { get; set; }
    public string? YearPublished { get; set; }
    public string? Isbn13 { get; set; }
    public string? Isbn10 { get; set; }
    public string? PurchaseUrl { get; set; }
    public string? ImageUrl { get; set; }

    public ICollection<Author> Authors { get; set; }
    public ICollection<Category> Categories { get; set; }

}
