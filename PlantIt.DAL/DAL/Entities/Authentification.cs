using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class Authentification
{
    public int Id { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public virtual ICollection<PasswordHistoric> PasswordHistorics { get; set; } = new List<PasswordHistoric>();
}
