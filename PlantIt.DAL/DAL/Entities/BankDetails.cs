using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class BankDetails
{
    public int IdBankDetails { get; set; }

    public string? Details { get; set; }

    public int IdUser { get; set; }

    public virtual User User { get; set; } = null!;
}
