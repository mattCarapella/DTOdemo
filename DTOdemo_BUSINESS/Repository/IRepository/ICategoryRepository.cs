using DTOdemo_MODELS;

namespace DTOdemo_BUSINESS.Repository.IRepository;

public interface ICategoryRepository
{
    public Task<CategoryDTO> Get(int id);

    public Task<IEnumerable<CategoryDTO>> GetAll();

    public Task<CategoryDTO> Create(CategoryDTO categoryDTO);

    public Task<CategoryDTO> Update(CategoryDTO categoryDTO);

    public Task<int> Delete(int id);

}