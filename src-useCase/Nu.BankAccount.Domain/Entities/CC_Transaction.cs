using System;

namespace Nu.CreditCard.Domain.Entities
{
    public class CC_Transaction
    {
        public string Trader { get; }
        public int Amount { get; }
        public DateTime Date { get; }

        public CC_Transaction(string trader, int amount, DateTime date)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "invald");

            if(string.IsNullOrEmpty(trader))
                throw new ArgumentNullException(nameof(trader));

            if (date <= DateTime.MinValue)
                throw new ArgumentOutOfRangeException(nameof(date), "invalid");

            Trader = trader;
            Amount = amount;   
            Date = date;
        }
    }
}