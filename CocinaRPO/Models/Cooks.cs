using System.ComponentModel.DataAnnotations;

namespace CocinaRPO.Models
{
    public class Cooks
    {
        [Key]
        public int CookId { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public int UserId { get; set; }

        // ForenKey
        public Users? Users { get; set; }

    }
}
