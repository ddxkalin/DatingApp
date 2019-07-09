using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegistrationDto
    {
        [Required]
        public string Username { get; set; }
        
       [Required]
       [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters!")]
        public string Password { get; set; }
    }
}