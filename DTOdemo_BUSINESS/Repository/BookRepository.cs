using AutoMapper;
using DTOdemo_BUSINESS.Repository.IRepository;
using DTOdemo_DATA;
using DTOdemo_DATA.Data;
using DTOdemo_MODELS;
using Microsoft.EntityFrameworkCore;

namespace DTOdemo_BUSINESS.Repository;

public class BookRepository : IBookRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public BookRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<BookDTO> Get(int id)
    {
        var book = await _db.Books.Include(b => b.Authors)
                                  .FirstOrDefaultAsync(b => b.Id == id);

        var bookDTO = _mapper.Map<BookDTO>(book);
        return bookDTO;
    }

    public async Task<List<BookDTO>> GetAll()
    {
        var books = await _db.Books.Include(b => b.Authors)
                                   .ToListAsync();

        var bookDTOs = _mapper.Map<List<BookDTO>>(books);
        return bookDTOs;
    }

    public async Task<BookDTO> Create(BookDTO bookDTO)
    {
        var book = _mapper.Map<Book>(bookDTO);
        var addedBook = _db.Books.Add(book);
        await _db.SaveChangesAsync();
        return _mapper.Map<BookDTO>(addedBook.Entity);
    }

    public async Task<BookDTO> Update(BookDTO bookDTO)
    {
        var book = await _db.Books.Include(b => b.Authors)
                                  .FirstOrDefaultAsync(b => b.Id == bookDTO.Id);

        if (book is not null)
        {
            book.Title = bookDTO.Title;
            book.Description = bookDTO.Description;
            book.Pages = bookDTO.Pages;
            book.Edition = bookDTO.Edition;
            book.Publisher = bookDTO.Publisher;
            book.YearPublished = bookDTO.YearPublished;
            book.Isbn13 = bookDTO.Isbn13;
            book.Isbn10 = bookDTO.Isbn10;
            book.PurchaseUrl = bookDTO.PurchaseUrl;
            book.ImageUrl = bookDTO.ImageUrl;
            _db.Books.Update(book);
            await _db.SaveChangesAsync();
            return _mapper.Map<BookDTO>(book);
        }
        return bookDTO;
    }

    public async Task<int> Delete(int id)
    {
        var book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
        if (book is not null)
        {
            _db.Books.Remove(book);
            return await _db.SaveChangesAsync();
        }
        return 0;
    }

    

}






//public async Task<List<BookDTO>> GetAll()
//{
//    var books = await _db.Books.Include(b => b.Authors).ToListAsync();
//    var bookDTOs = new List<BookDTO>();

//    books.ForEach(book =>
//    {
//        var bookDTO = new BookDTO
//        {
//            Id = book.Id,
//            Title = book.Title,
//        };

//        foreach (var author in book.Authors)
//        {
//            var authorDTO = new BookAuthorDTO
//            {
//                FirstName = author.FirstName,
//                LastName = author.LastName,
//                Bio = author.Bio
//            };

//            bookDTO.Authors.Add(authorDTO);
//        }
//        bookDTOs.Add(bookDTO);
//    });

//    return bookDTOs;
//}