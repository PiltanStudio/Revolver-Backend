using System.ComponentModel.DataAnnotations;

namespace RevolverBackend.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }
        public int Score { get; set; }
    }
}
