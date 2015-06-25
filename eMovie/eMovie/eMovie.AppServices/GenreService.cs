using eMovie.AppServices.DTOs;
using eMovie.Core.Entities;
using eMovie.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMovie.AppServices
{
    public class GenreService
    {
        private IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public void AddGenre(GenreDto dto)
        {
            Genre entity = new Genre();
            entity.Name = dto.Name;
            _genreRepository.Add(entity);
            _genreRepository.Save();
        }
    }
}
