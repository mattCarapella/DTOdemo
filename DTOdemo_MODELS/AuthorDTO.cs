namespace DTOdemo_MODELS;

public class AuthorDTO
{
    public AuthorDTO()
    {
        Books = new List<BookDTO>();
    }

    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string? ImageUrl { get; set; }

    public string FullName
    {
        get
        {
            if (MiddleName is not null)
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
            else
            {
                return FirstName + " " + LastName;
            }
            
        }
    }

    public ICollection<BookDTO> Books { get; set; }

}