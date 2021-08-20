using LibraryAPI.Dtos.Base;
using LibraryAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Dtos
{
    public class BookDto : Dto
    {
        public string ISBN { get; set; }

        public int AuthorId { get; set; }
    }
}
