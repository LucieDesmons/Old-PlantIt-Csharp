using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class UserType
{
    public int IdUserType { get; set; }

    public string? Label { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
