using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class PlantDto
    {
        public int IdPlant { get; set; }

        public string? Name { get; set; }

        public string? PlacePlant { get; set; }

        public string? Container { get; set; }

        public int? Humidity { get; set; }

        public int? Clarity { get; set; }

        public int IdUser { get; set; }

        public int IdPlantReference { get; set; }

        public PlantReferenceDto IdPlantReferenceNavigation { get; set; }

        public UserDto IdUserNavigation { get; set; }

        public List<ConversationDto> IdConversations { get; set; }

        public List<PictureDto> IdPictures { get; set; }
    }
}
