using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class Picture
{
    public int IdPicture { get; set; }

    public string? Path { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual ICollection<Maintenance> IdMaintenances { get; set; } = new List<Maintenance>();

    public virtual ICollection<Plant> IdPlants { get; set; } = new List<Plant>();
}
