using AutoMapper;
using LibraryAPI.Dtos;
using LibraryAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Author, AuthorDto>().ReverseMap();

            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
