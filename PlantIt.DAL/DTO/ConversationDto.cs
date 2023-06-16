namespace PlantIt.DATA.DTO
{
    public class ConversationDto
    {
        public int IdConversation { get; set; }

        public int IdUser1 { get; set; }

        public int IdUser2 { get; set; }

        public UserDto IdUser1Navigation { get; set; }

        public UserDto IdUser2Navigation { get; set; }

        public List<MessageDto> Messages { get; set; }

        public List<PlantDto> IdPlants { get; set; }
    }
}
