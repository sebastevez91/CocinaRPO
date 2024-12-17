using System.ComponentModel.DataAnnotations;

namespace CocinaRPO.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string PasswordHasd {  get; set; }
        [Required]

        public string Role {  get; set; }

    }
}
