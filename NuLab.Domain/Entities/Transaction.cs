namespace NuLab.Domain.Entities
{
    public class Transaction
    {
        public string Merchant { get; set; } = string.Empty;
        public int Amount { get; set; }
        public DateTime LocalDateTime { get; set; }
    }
}
