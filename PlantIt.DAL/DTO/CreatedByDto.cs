namespace PlantIt.DATA.DTO
{
    public class CreatedByDto
    {
        public int IdPlantReference { get; set; }

        public int IdUser { get; set; }

        public int? OrderNum { get; set; }

        public DateTime? UpdateDate { get; set; }

        public PlantReferenceDto IdPlantReferenceNavigation { get; set; }

        public UserDto IdUserNavigation { get; set; }
    }
}
