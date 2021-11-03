using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        public int Id {get; set;}
        [Required]
        [MaxLength(15)]
        
        public string UserName { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 6)]
        public string Password { get; set; }
    }
}