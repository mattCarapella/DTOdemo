using DTOdemo_MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOdemo_BUSINESS.Repository.IRepository;

public interface IAuthorRepository
{
    public Task<AuthorDTO> Get(int id);
    public Task<List<AuthorDTO>> GetAll();
    public Task<AuthorDTO> Create(AuthorDTO objDTO);
    public Task<AuthorDTO> Update(AuthorDTO objDTO);
    public Task<int> Delete(int id);

}