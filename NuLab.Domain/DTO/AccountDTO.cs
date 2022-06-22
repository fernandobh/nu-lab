namespace NuLab.Domain.Entities.DTO
{
    public class AccountDTO
    {
        public bool Active { get; set; }
        public int AvailableLimite { get; set; }
        public IList<TransactionDTO> Transactions { get; set; }

        public AccountDTO()
        {
            Transactions = new List<TransactionDTO>();
        }
    }
}
