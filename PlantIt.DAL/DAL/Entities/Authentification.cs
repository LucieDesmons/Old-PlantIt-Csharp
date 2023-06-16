using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class Authentification
{
    public int IdAuthentification { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public virtual ICollection<PasswordHistoric> PasswordHistoricCollection { get; set; } = new List<PasswordHistoric>();
}
