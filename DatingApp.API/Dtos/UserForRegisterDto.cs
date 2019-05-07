using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, 
            ErrorMessage = "Password must be atleast 4 chars and maximum of 8!")]
        public string Password { get; set; }
    }
}