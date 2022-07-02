using System;
using System.Collections.Generic;

namespace Nu.BankAccount.Domain.Entities
{
    public class Account
    {
        public bool Active { get; }
        public int AvailableLimite { get; }
        public IList<Transaction> History { get; }

        public Account(bool active, int availableLimite)
        {
            Active = active;
            AvailableLimite = availableLimite;
            History = new List<Transaction>();
        }
    }
}
