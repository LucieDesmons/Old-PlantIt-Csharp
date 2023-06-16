using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class Message
{
    public int IdMessage { get; set; }

    public string? Label { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int IdConversation { get; set; }

    public virtual Conversation IdConversationNavigation { get; set; } = null!;
}
