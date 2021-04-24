using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public sealed class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int RoleId { get; set; }
        
        [Required]
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
