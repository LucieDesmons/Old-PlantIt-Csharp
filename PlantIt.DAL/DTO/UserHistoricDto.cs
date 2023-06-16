using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class UserHistoricDto
    {
        public int IdUserHistoric { get; set; }

        public int IdUser { get; set; }

        [Required]
        public string Action { get; set; }

        public string? Reason { get; set; }

        public DateTime Date { get; set; }

        public UserDto IdUserNavigation { get; set; }
    }
}
