using System;
using System.Collections.Generic;
using System.Linq;

namespace Nu.CreditCard.Domain.Entities
{
    /// <summary>
    /// Regras:
    /// Cartão duplicado
    /// Estourar Limite
    /// Inativo
    /// Cancelado não tem como "descancelar"
    /// </summary>
    public class CreditCard
    {
        private readonly int _id;
        private bool _active;
        private readonly string _holder; 
        private bool _deprecated;
        private readonly int _availableLimit;
        private readonly IList<CC_Transaction> _transactions;
        

        public int Id { get => _id; }
        public string Holder { get => _holder; }
        public bool Deprecated { get => _deprecated; }
        public IList<CC_Transaction> Transactions { get => _transactions; }


        public CreditCard(int id, string holder, int availableLimit)
        {
            _id = id;
            _active = false;
            _holder = Holder;
            _availableLimit = availableLimit > 0 ? availableLimit : throw new Exception("Available limit should be more than zero");
            _transactions = new List<CC_Transaction>();
        }


        public bool Active
        {
            get => _active;
            set => _active = !Deprecated ? value : throw new Exception("Credit card already is cancel");
        }

        public int AvailableLimit
        {
            get => (_availableLimit - Transactions.Sum(x => x.Amount));
        }


        public void AddTransaction(CC_Transaction transaction)
        {
            if(transaction == null)
                throw new ArgumentNullException(nameof(transaction));
            
            if (!Active)
                throw new Exception("It's inactive");

            if (Deprecated)
                throw new Exception("It's deprecated");

            if (AvailableLimit < transaction.Amount)
                throw new Exception("It's aren't available limit");

            _transactions.Add(transaction);
        }

        
        public void CancelCreditCart()
        {
            _deprecated = true;
            _active = false;
        }
    }
}
