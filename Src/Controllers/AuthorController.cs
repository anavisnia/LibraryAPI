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
    public class AuthorController : ControllerBase
    {
        readonly IAuthorRepository _repository;

        public AuthorController(IAuthorRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<List<AuthorDto>> GetAll()
        {
            var entities = await _repository.GetAll();

            return entities;
        }

        [HttpPost]
        public async Task Upsert(AuthorDto authorDto)
        {
            await _repository.Upsert(authorDto);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }


    }
}
