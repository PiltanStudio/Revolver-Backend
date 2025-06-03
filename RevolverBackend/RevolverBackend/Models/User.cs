using System.ComponentModel.DataAnnotations;

namespace RevolverBackend.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }
    }
}
