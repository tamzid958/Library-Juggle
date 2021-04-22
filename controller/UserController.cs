using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Juggle.model;
using Library_Juggle.data;

namespace Library_Juggle.controller
{
     public class UserController
    {
        private readonly LibraryJuggleContext _db;

        public UserController()
        {
            _db = new LibraryJuggleContext();
        }

        public void CreateUser(User user)
        {
            _db.Users.AddAsync(user);
            _db.SaveChangesAsync();
        }

        public int DuplicateUser(string email)
        {
            return _db.Users.Count(e => e.Email == email);
            
        }
    }
}
