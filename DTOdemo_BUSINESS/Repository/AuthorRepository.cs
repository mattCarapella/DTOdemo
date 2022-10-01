using AutoMapper;
using DTOdemo_BUSINESS.Repository.IRepository;
using DTOdemo_DATA;
using DTOdemo_DATA.Data;
using DTOdemo_MODELS;
using Microsoft.EntityFrameworkCore;

namespace DTOdemo_BUSINESS.Repository;

public class AuthorRepository : IAuthorRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public AuthorRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<AuthorDTO> Get(int id)
    {
        var author = await _db.Authors.Include(b => b.Books)
                                      .FirstOrDefaultAsync(a => a.Id == id);

        var authorDTO = _mapper.Map<AuthorDTO>(author);
        return authorDTO;
    }

    public async Task<List<AuthorDTO>> GetAll()
    {
        var authors = await _db.Authors.Include(b => b.Books)
                                       .ToListAsync();

        var authorDTOs = _mapper.Map<List<AuthorDTO>>(authors);
        return authorDTOs;
    }

    public async Task<AuthorDTO> Create(AuthorDTO authorDTO)
    {
        var author = _mapper.Map<Author>(authorDTO);
        var addedAuthor = _db.Authors.Add(author);
        await _db.SaveChangesAsync();
        return _mapper.Map<AuthorDTO>(addedAuthor.Entity);
    }   
    
    public async Task<AuthorDTO> Update(AuthorDTO authorDTO)
    {
        var author = await _db.Authors.Include(a=>a.Books)
                                      .FirstOrDefaultAsync(a => a.Id == authorDTO.Id);
        if (author is not null)
        {
            author.FirstName = authorDTO.FirstName;
            author.LastName = authorDTO.LastName;
            author.Bio = authorDTO.Bio;
            author.ImageUrl = authorDTO.ImageUrl;
            _db.Authors.Update(author);
            await _db.SaveChangesAsync();
            return _mapper.Map<AuthorDTO>(author);
        }
        return authorDTO;
    }

    public async Task<int> Delete(int id)
    {
        var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == id);
        if (author is not null)
        {
            _db.Authors.Remove(author);
            return await _db.SaveChangesAsync();
        }
        return 0;
    }

}