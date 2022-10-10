using DTOdemo_MODELS;

namespace DTOdemo_BUSINESS.Repository.IRepository;

public interface IBookRepository
{
    public Task<BookDTO> Get(int id);
    public Task<List<BookDTO>> GetAll();
    public Task<BookDTO> Create(BookDTO objDTO);
    public Task<BookDTO> Update(BookDTO objDTO);
    public Task<int> Delete(int id);
    public Task<BookDTO> AddAuthorToBook(AddBookAuthorDTO objDTO);
}
