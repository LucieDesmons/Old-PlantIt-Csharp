using System.ComponentModel.DataAnnotations;

namespace PlantIt.DATA.DTO
{
    public class AuthentificationDto
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public List<PasswordHistoricDto> PasswordHistorics { get; set; }
    }
}
