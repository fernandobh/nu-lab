using System;

namespace Nu.BankAccount.Domain.Entities
{
    public class Transaction
    {
        public string Merchant { get; }
        public int Amount { get; }
        public DateTime LocalDateTime { get; }


        public Transaction(string merchant, int amount, DateTime localDateTime)
        {
            Merchant = merchant;
            Amount = amount;
            LocalDateTime = localDateTime;
        }
    }
}
