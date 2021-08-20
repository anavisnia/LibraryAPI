using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Entities.Base
{
    public class Entity
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public int? Year { get; set; }
    }
}
