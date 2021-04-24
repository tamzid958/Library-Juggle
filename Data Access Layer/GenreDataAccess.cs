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

        public void CreateGenre(Genre genre)
        {
            _db.Genres.AddAsync(genre);
            _db.SaveChangesAsync();
        }
    }
}