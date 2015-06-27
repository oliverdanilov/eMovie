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
    public class MovieService
    {
        private IMovieRepository _movieRepository;
        private IGenreRepository _genreRepository;
        public MovieService(IMovieRepository movieRepository,
            IGenreRepository genreRepository)
        {
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
        }
        public void AddMovie(MovieDto dto)
        {
            Movie entity = new Movie();
            entity.Title = dto.Title;
            entity.Description =dto.Description;
            entity.Genre = _genreRepository.GetById(dto.GenreId);
            _movieRepository.Add(entity);
            _movieRepository.Save();
        }
        public List<MovieDto> GetAll()
        {
            var movies = _movieRepository.GetAll();
            return movies.Select(x => new MovieDto()
            {
                Title = x.Title,
                Description = x.Description,
                GenreName = x.Genre.Name
            }).ToList();
        }
    }
}
