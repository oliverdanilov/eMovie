using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMovie.Core.Entities;

namespace eMovie.Infrastructure.Data
{
    public class eMovieDbContext : DbContext
    {
        public eMovieDbContext(string cnnString)
            :base(cnnString)
        {

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
