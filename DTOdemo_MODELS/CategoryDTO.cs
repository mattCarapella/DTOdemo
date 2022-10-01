namespace DTOdemo_MODELS;

public class CategoryDTO
{
    public CategoryDTO()
    {
        Books = new List<CategoryBookDTO>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<CategoryBookDTO> Books { get; set; }

}
