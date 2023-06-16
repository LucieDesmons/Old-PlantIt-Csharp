using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class PlantReference
{
    public int IdPlantReference { get; set; }

    public string? Name { get; set; }

    public string? Family { get; set; }

    public string? Size { get; set; }

    public string? FoodSource { get; set; }

    public string? Reproduction { get; set; }

    public string? Lifetime { get; set; }

    public string? PlaceLife { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CreatedBy> CreatedBies { get; set; } = new List<CreatedBy>();

    public virtual ICollection<Plant> Plants { get; set; } = new List<Plant>();

    public virtual ICollection<PictureReference> IdPictureReferences { get; set; } = new List<PictureReference>();
}
