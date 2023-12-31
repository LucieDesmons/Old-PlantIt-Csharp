﻿using System.ComponentModel.DataAnnotations;

namespace PlantIt.DATA.DTO
{
    public class AuthentificationDto
    {
        public int IdAuthentification { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public List<PasswordHistoricDto> PasswordHistoricCollection { get; set; }
    }
}
