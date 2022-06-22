namespace NuLab.Domain.Entities.DTO
{
    public class TransactionDTO
    {
        public string Merchant { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime LocalDateTime { get; set; }
    }
}
