using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Core.Entities
{
    public class Movie :BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }
    }
}
