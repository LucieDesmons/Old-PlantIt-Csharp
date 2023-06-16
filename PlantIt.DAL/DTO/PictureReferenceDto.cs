using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class PictureReferenceDto
    {
        public int IdPictureReference { get; set; }

        public string? Path { get; set; }

        public DateTime? ModificationDate { get; set; }

        public List<PlantReferenceDto> IdPlantReferences { get; set; }
    }
}
