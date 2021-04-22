using System.ComponentModel.DataAnnotations;

namespace Library_Juggle.model
{
    public class User
    {
        [Key]
        public int UserId { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { set; get; }

        [Required]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { set; get; }

        [Required]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { set; get; }

        [Required]
        public int RoleId { set; get; }

        public virtual Role Role { set; get; }
    }
}
