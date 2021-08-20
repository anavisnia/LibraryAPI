using LibraryAPI.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI.Entities
{
    public class Author : Entity
    {
        public string Surname { get; set; }

        public List<Book> Books { get; set; }
    }
}
