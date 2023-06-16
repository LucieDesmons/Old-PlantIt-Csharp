using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class MaintenanceDto
    {
        public int IdMaintenance { get; set; }

        public DateTime? PredictedDate { get; set; }

        public DateTime? RealizedDate { get; set; }

        public string? Report { get; set; }

        public List<PictureDto> IdPictures { get; set; }

        public List<UserDto> IdUsers { get; set; }
    }
}
