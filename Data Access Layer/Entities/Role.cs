using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        [Key]
        public int RoleId { set; get; }

        [Required]
        [StringLength(30)]
        public string RoleName { set; get; }

        public ICollection<User> Users { get; set; }
    }
}
