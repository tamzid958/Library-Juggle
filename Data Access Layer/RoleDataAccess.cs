﻿using System.Collections.Generic;
using System.Linq;
using Library_Juggle.Data_Access_Layer.Entities;

namespace Library_Juggle.Data_Access_Layer
{
    public class RoleDataAccess
    {
        private readonly LibraryJuggleContext _db;

        public RoleDataAccess()
        {
            _db = new LibraryJuggleContext();
        }

        public List<Role> GetAllRoles()
        {
            return _db.Roles.ToList();
        }

        public int GetRoleByName(string roleName)
        {
            return _db.Roles.FirstOrDefault(r => r.RoleName == roleName)!.RoleId;
        }
    }
}
