using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class PasswordHistoric
{
    public int IdHistoric { get; set; }

    public string? Password { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int AuthentificationId { get; set; }

    public virtual Authentification Authentification { get; set; } = null!;
}
