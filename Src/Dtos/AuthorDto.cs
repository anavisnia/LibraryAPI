using LibraryAPI.Dtos.Base;
using LibraryAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Dtos
{
    public class AuthorDto : Dto
    {
        public string Surname { get; set; }

        public int BookId { get; set; }
    }
}
