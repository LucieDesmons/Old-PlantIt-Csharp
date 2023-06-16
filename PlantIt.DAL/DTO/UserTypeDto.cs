using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class UserTypeDto
    {
        public int IdUserType { get; set; }

        public string? Label { get; set; }

        public List<UserDto> UserCollection { get; set; } = new List<UserDto>();
    }
}
