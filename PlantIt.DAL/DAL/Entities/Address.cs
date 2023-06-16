using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class Address
{
    public int IdAddress { get; set; }

    public int? Number { get; set; }

    public string? PostalCode { get; set; }

    public string? Way { get; set; }

    public string? AdditionalAddress { get; set; }

    public string? Town { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
