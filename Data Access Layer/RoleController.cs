using System.Collections.Generic;
using System.Linq;
using Library_Juggle.Data_Access_Layer.Entities;

namespace Library_Juggle.Data_Access_Layer
{
    public class RoleController
    {
        private readonly LibraryJuggleContext _db;

        public RoleController()
        {
            _db = new LibraryJuggleContext();
        }

        public List<Role> GetAllRoles()
        {
            return _db.Roles.ToList();
        }
    }
}
