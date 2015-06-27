using eMovie.Core.Entities;
using eMovie.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Infrastructure.Data.Repositories
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        public MovieRepository(eMovieDbContext context)
            : base(context)
        {

        }

        public int Count()
        {
            return _context.Movies.Count();
        }
    }
}
