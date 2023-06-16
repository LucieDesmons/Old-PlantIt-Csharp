using System;
using System.Collections.Generic;

namespace PlantIt.DATA.DAL.entities;

public partial class User
{
    public int IdUser { get; set; }

    public string? Name { get; set; }

    public string? FirstName { get; set; }

    public string? Phone { get; set; }

    public string? Degree { get; set; }

    public string? Specialization { get; set; }

    public string? Hobbies { get; set; }

    public int IdAddress { get; set; }

    public int IdUserType { get; set; }

    public int AuthentificationId { get; set; }

    public virtual Authentification Authentification { get; set; } = null!;

    public virtual ICollection<BankDetails> BankDetails { get; set; } = new List<BankDetails>();

    public virtual ICollection<Conversation> ConversationIdUser1Navigations { get; set; } = new List<Conversation>();

    public virtual ICollection<Conversation> ConversationIdUser2Navigations { get; set; } = new List<Conversation>();

    public virtual ICollection<CreatedBy> CreatedBies { get; set; } = new List<CreatedBy>();

    public virtual Address IdAddressNavigation { get; set; } = null!;

    public virtual UserType IdUserTypeNavigation { get; set; } = null!;

    public virtual ICollection<Manage> ManageIdUserBotanistNavigations { get; set; } = new List<Manage>();

    public virtual ICollection<Manage> ManageIdUserCustomerNavigations { get; set; } = new List<Manage>();

    public virtual ICollection<Plant> Plants { get; set; } = new List<Plant>();

    public virtual ICollection<UserHistoric> UserHistorics { get; set; } = new List<UserHistoric>();

    public virtual ICollection<Maintenance> IdMaintenances { get; set; } = new List<Maintenance>();
}
