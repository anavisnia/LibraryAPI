using LibraryAPI.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryAPI.Interfaces
{
    public interface IAuthorRepository
    {
        Task Delete(int id);
        Task<List<AuthorDto>> GetAll();
        Task Upsert(AuthorDto authorDto);
    }
}