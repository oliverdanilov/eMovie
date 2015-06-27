using eMovie.Core.Entities;
using eMovie.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> :IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        protected eMovieDbContext _context;
        public BaseRepository(eMovieDbContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
