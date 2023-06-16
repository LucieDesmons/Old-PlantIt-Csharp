using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class CreatedBy
{
    public int IdPlantReference { get; set; }

    public int IdUser { get; set; }

    public int? OrderNum { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual PlantReference IdPlantReferenceNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
