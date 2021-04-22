using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Juggle.model
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
