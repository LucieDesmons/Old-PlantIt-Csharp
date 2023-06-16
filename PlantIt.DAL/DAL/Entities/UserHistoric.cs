using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class UserHistoric
{
    public int IdUserHistoric { get; set; }

    public int IdUser { get; set; }

    public string Action { get; set; } = null!;

    public string? Reason { get; set; }

    public DateTime Date { get; set; }

    public virtual User User { get; set; } = null!;
}
