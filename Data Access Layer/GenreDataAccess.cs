using System.Collections.Generic;
using System.Linq;
using Library_Juggle.Data_Access_Layer.Entities;

namespace Library_Juggle.Data_Access_Layer
{
    public class GenreDataAccess
    {
        private readonly LibraryJuggleDbContext _db;

        public GenreDataAccess()
        {
            _db = new LibraryJuggleDbContext();
        }

        public List<Genre> GetAllGenres()
        {
            return _db.Genres.ToList();
        }

        public Genre GetGenre(int genreId)
        {
            return _db.Genres.FirstOrDefault(g=> g.GenreId == genreId);
        }
        public void CreateGenre(Genre genre)
        {
            _db.Genres.AddAsync(genre);
            _db.SaveChangesAsync();
        }

        public void UpdateGenre(int genreId, string genreName)
        {
            var currentGenre = GetGenre(genreId);
            currentGenre.GenreName = genreName;
            _db.Genres.Update(currentGenre);
            _db.SaveChangesAsync();
        }

        public void DeleteGenre(int genreId)
        {
            _db.Genres.Remove(GetGenre(genreId));
            _db.SaveChangesAsync();
        }
    }
}