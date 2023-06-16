using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class PictureDto
    {
        public int IdPicture { get; set; }

        public string? Path { get; set; }

        public DateTime? UpdateDate { get; set; }

        public List<MaintenanceDto> IdMaintenances { get; set; }

        public List<PlantDto> IdPlants { get; set; }
    }
}
