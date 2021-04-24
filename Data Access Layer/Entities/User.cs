﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public sealed class User
    {
        public User()
        {
            Books = new HashSet<Book>();
            Genres = new HashSet<Genre>();
            Loans = new HashSet<Loan>();
        }

        [Key]
        public int UserId { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public Guid Token { get; set; }
        
        [Required]
        public int RoleId { get; set; }

        public Role Role { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
