using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantIt.DATA.DTO
{
    public class UserDto
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

        public AuthentificationDto Authentification { get; set; }

        public List<BankDetailsDto> BankDetails { get; set; }

        public List<ConversationDto> ConversationIdUser1Navigations { get; set; }

        public List<ConversationDto> ConversationIdUser2Navigations { get; set; }

        public List<CreatedByDto> CreatedBies { get; set; }

        public AddressDto IdAddressNavigation { get; set; }

        public UserTypeDto IdUserTypeNavigation { get; set; }

        public List<ManageDto> ManageIdUserBotanistNavigations { get; set; }

        public List<ManageDto> ManageIdUserCustomerNavigations { get; set; }

        public List<PlantDto> Plants { get; set; }

        public List<UserHistoricDto> UserHistorics { get; set; }

        public List<MaintenanceDto> IdMaintenances { get; set; }
    }
}
