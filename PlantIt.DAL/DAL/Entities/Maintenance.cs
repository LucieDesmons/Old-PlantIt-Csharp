﻿using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class Maintenance
{
    public int IdMaintenance { get; set; }

    public DateTime? PredictedDate { get; set; }

    public DateTime? RealizedDate { get; set; }

    public string? Report { get; set; }

    public virtual ICollection<Picture> PictureCollection { get; set; } = new List<Picture>();

    public virtual ICollection<User> UserCollection { get; set; } = new List<User>();
}
