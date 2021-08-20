using LibraryAPI.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryAPI.Interfaces
{
    public interface IBookRepository
    {
        Task Delete(int id);
        Task<List<BookDto>> GetAll();
        Task Upsert(BookDto bookDto);
    }
}