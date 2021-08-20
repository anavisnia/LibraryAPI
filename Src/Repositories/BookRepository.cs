using AutoMapper;
using LibraryAPI.Data;
using LibraryAPI.Dtos;
using LibraryAPI.Entities;
using LibraryAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        readonly DataContext _dataContext;
        readonly IMapper _mapper;

        public BookRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<BookDto>> GetAll()
        {
            var entities = await _dataContext.Books.ToListAsync();

            return _mapper.Map<List<BookDto>>(entities);
        }

        public async Task Upsert(BookDto bookDto)
        {
            var entity = _mapper.Map<Book>(bookDto);

            if (entity.Name == bookDto.Name && entity.Id != null)
            {
                _dataContext.Update(entity);
            }
            else
            {
                _dataContext.Add(entity);
            }

            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = _dataContext.Set<Book>().FirstOrDefault(b => b.Id == id);

            if (entity != null)
            {
                _dataContext.Remove(entity);
            }

            await _dataContext.SaveChangesAsync();
        }


    }
}
