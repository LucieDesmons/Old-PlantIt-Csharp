namespace PlantIt.DATA.DTO
{
    public class BankDetailsDto
    {
        public int IdBankDetails { get; set; }

        public string? Details { get; set; }

        public int IdUser { get; set; }

        public UserDto User { get; set; }
    }
}
