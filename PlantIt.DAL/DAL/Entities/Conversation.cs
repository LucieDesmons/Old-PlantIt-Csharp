using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class Conversation
{
    public int IdConversation { get; set; }

    public int IdUser1 { get; set; }

    public int IdUser2 { get; set; }

    public virtual User IdUser1Navigation { get; set; } = null!;

    public virtual User IdUser2Navigation { get; set; } = null!;

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Plant> IdPlants { get; set; } = new List<Plant>();
}
