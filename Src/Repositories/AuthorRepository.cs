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
    public class AuthorRepository : IAuthorRepository
    {
        readonly DataContext _dataContext;
        readonly IMapper _mapper;

        public AuthorRepository(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<AuthorDto>> GetAll()
        {
            var entities = await _dataContext.Authors.ToListAsync();

            return _mapper.Map<List<AuthorDto>>(entities);
        }

        public async Task Upsert(AuthorDto authorDto)
        {
            var entity = _mapper.Map<Author>(authorDto);

            if (entity.Name == authorDto.Name && entity.Year == authorDto.Year)
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
            var entity = _dataContext.Set<Author>().FirstOrDefault(a => a.Id == id);

            if (entity != null)
            {
                _dataContext.Remove(entity);
            }

            await _dataContext.SaveChangesAsync();
        }
    }
}
