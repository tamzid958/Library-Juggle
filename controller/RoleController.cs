using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Juggle.data;
using Library_Juggle.model;

namespace Library_Juggle.controller
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
