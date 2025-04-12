using System.ComponentModel.DataAnnotations;

namespace Nestin.Core.Dtos.Accounts
{
    public class RegisterDto
    {
        [EmailAddress]
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(12)]
        public string Password { get; set; }
    }
}
