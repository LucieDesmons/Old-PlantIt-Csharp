using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class MessageDto
    {
        public int IdMessage { get; set; }

        public string? Label { get; set; }

        public DateTime? UpdateDate { get; set; }

        public int IdConversation { get; set; }

        public ConversationDto Conversation { get; set; }
    }
}
