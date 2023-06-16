using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class PlantReferenceDto
    {
        public int IdPlantReference { get; set; }

        public string? Name { get; set; }

        public string? Family { get; set; }

        public string? Size { get; set; }

        public string? FoodSource { get; set; }

        public string? Reproduction { get; set; }

        public string? Lifetime { get; set; }

        public string? PlaceLife { get; set; }

        public string? Description { get; set; }

        public List<CreatedByDto> CreatedBies { get; set; }

        public List<PlantDto> Plants { get; set; }

        public List<PictureReferenceDto> IdPictureReferences { get; set; }
    }
}
