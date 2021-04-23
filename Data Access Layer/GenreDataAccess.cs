using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Juggle.Data_Access_Layer
{
    public class GenreDataAccess
    {

        private readonly LibraryJuggleContext _db;

        public GenreDataAccess()
        {
            _db = new LibraryJuggleContext();
        }
    }
}
