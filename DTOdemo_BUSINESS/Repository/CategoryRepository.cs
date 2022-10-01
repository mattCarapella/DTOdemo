using AutoMapper;
using DTOdemo_BUSINESS.Repository.IRepository;
using DTOdemo_DATA;
using DTOdemo_DATA.Data;
using DTOdemo_MODELS;
using Microsoft.EntityFrameworkCore;

namespace DTOdemo_BUSINESS.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public CategoryRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    
    public async Task<CategoryDTO> Get(int id)
    {
        var category = await _db.Categories.Include(c => c.Books)
                                               .ThenInclude(b => b.Authors)
                                           .FirstOrDefaultAsync(c => c.Id == id);

        if (category is not null) return _mapper.Map<CategoryDTO>(category);
        return new CategoryDTO();
    }

    public async Task<IEnumerable<CategoryDTO>> GetAll()
    {
        var categories = await _db.Categories.Include(c => c.Books)
                                                .ThenInclude(b => b.Authors)
                                             .ToListAsync();    

        return _mapper.Map<IEnumerable<CategoryDTO>>(categories);
    }
    public async Task<CategoryDTO> Create(CategoryDTO categoryDTO)
    {
        var category = _mapper.Map<Category>(categoryDTO);
        var addedCategory = _db.Categories.Add(category);
        await _db.SaveChangesAsync();
        return _mapper.Map<CategoryDTO>(addedCategory.Entity);
    }

    public async Task<CategoryDTO> Update(CategoryDTO categoryDTO)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == categoryDTO.Id);
        if (category is not null)
        {
            category.Name = categoryDTO.Name;
            _db.Categories.Update(category);
            await _db.SaveChangesAsync();
            return _mapper.Map<CategoryDTO>(category);
        }
        return categoryDTO;
    }

    public async Task<int> Delete(int id)
    {
        var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);

        if (category is not null)
        {
            _db.Categories.Remove(category);
            return await _db.SaveChangesAsync();
        }

        return 0;
    }
}
