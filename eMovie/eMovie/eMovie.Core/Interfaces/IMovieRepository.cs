using eMovie.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Core.Interfaces
{
    public interface IMovieRepository : IBaseRepository<Movie>
    {
        int Count();
    }
}
