using LibraryAPI.Dtos;
using LibraryAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        readonly IBookRepository _repository;

        public BookController(IBookRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<List<BookDto>> GetAll()
        {
            var entities = await _repository.GetAll();

            return entities;
        }

        [HttpPost]
        public async Task Upsert(BookDto bookDto)
        {
            await _repository.Upsert(bookDto);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
