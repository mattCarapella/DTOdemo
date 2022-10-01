namespace DTOdemo_MODELS;

public class BookAuthorDTO
{
    public int Id { get; set; }

    //public string FirstName { get; set; } = string.Empty;
    //public string LastName { get; set; } = string.Empty;

    // Updated MappingProfile to combine FirstName & LastName 
    public string Name { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }
}