﻿using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class PictureReference
{
    public int IdPictureReference { get; set; }

    public string? Path { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual ICollection<PlantReference> PlantReferenceCollection { get; set; } = new List<PlantReference>();
}
