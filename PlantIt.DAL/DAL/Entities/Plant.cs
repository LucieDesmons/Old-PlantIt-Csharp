using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class Plant
{
    public int IdPlant { get; set; }

    public string? Name { get; set; }

    public string? PlacePlant { get; set; }

    public string? Container { get; set; }

    public int? Humidity { get; set; }

    public int? Clarity { get; set; }

    public int IdUser { get; set; }

    public int IdPlantReference { get; set; }

    public virtual PlantReference IdPlantReferenceNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<Conversation> IdConversations { get; set; } = new List<Conversation>();

    public virtual ICollection<Picture> IdPictures { get; set; } = new List<Picture>();
}
