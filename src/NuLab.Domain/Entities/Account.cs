using NuLab.Domain.DTO;

namespace NuLab.Domain.Entities
{
    public class Account
    {
        public Account(bool active, int availableLimite)
        {
            _active = active;
            _availableLimite = availableLimite;
            _transactions = new List<Transaction>();
        }


        private bool _active;
        public bool Active
        {
            get { return _active; }
        }

        
        private int _availableLimite;
        public int AvailableLimite
        {
            get 
            { 
                return _availableLimite - Transactions.ToList().Sum(x => x.Amount); 
            }
        }

        
        private IList<Transaction> _transactions;
        public IList<Transaction> Transactions
        {
            get { return _transactions; }
        }
        
        
        public bool AddTransaction(Transaction value)
        {
            if (AvailableLimite < value.Amount)
                return false;
            
            Transactions.Add(value);
            return true;                
        }
    }
}
