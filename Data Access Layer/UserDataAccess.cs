using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library_Juggle.Data_Access_Layer
{
     public class UserDataAccess
    {
        private readonly LibraryJuggleDbContext _db;

        public UserDataAccess()
        {
            _db = new LibraryJuggleDbContext();
        }

        public void CreateUser(User user)
        {
            user.Token = Guid.NewGuid();
            _db.Users.AddAsync(user);
            _db.SaveChangesAsync();
        }

        public int DuplicateUser(string email)
        {
            return _db.Users.Count(e => e.Email == email);
            
        }

        public User Authentication(string email, string password)
        {
            password = StaticMethods.CreateMd5(password);
            var currentUser = _db.Users.Include(r => r.Role).FirstOrDefault(u => u.Email == email && u.Password == password);
            if (currentUser == null) return null;
            File.WriteAllText(@"cookie.key", currentUser.Token.ToString());
            return currentUser;
        }

        public User CurrentUser()
        {
            if (!File.Exists(@"cookie.key")) return null;
            var token = Guid.Parse(File.ReadAllText(@"cookie.key"));
            return _db.Users.Include(r => r.Role).FirstOrDefault(u => u.Token == token);
        }

        public List<User> GetAllUsers()
        {
            return _db.Users.Include(r => r.Role).ToList();
        }


        public User GetUser(int userId)
        {
           return _db.Users.FirstOrDefault(u => u.UserId == userId);
        }

        public void UpdateRole(int userId, int roleId)
        {
            var currentUser = GetUser(userId);
            currentUser.RoleId = roleId;
            _db.Users.Update(currentUser);
            _db.SaveChangesAsync();
        }
    }
}
