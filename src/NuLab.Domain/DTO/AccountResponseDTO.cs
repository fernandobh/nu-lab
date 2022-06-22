namespace NuLab.Domain.DTO
{
    public class AccountResponseDTO
    {
        public bool Active { get; set; }
        public int AvailableLimite { get; set; }
        public string Violation { get; set; } = string.Empty;
    }
}
