namespace DTOdemo_MODELS;

public class CategoryBookDTO
{
    public CategoryBookDTO()
    {
        Authors = new List<BookAuthorDTO>();
    }

    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }

    public IEnumerable<BookAuthorDTO> Authors { get; set; }

}