using NuLab.Domain.DTO;
using NuLab.Domain.Entities;
using NuLab.Domain.Entities.DTO;

namespace NuLab.Domain.Interfaces
{
    public class AccountServices : IAccountServices
    {
        private readonly IAccountRepository _accountRepository;
        private Account _account;

        public AccountServices(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
            _account = _accountRepository.Get();
        }


        public AccountDTO Get()
        {
            var accountDTO = new AccountDTO();

            if (_account == null)
                return accountDTO;

            accountDTO.Active = _account.Active;
            accountDTO.AvailableLimite = _account.AvailableLimite;

            _account.Transactions.ToList().ForEach(x => accountDTO.Transactions.Add(
                new TransactionDTO() { Amount = x.Amount, LocalDateTime = x.LocalDateTime, Merchant = x.Merchant}));

            return accountDTO;

        }


        public AccountResponseDTO Create(int availableLimite)
        {
            if (_account == null)
            {
                _account = new Account(true, availableLimite);
                _accountRepository.CreateOrUpdate(_account);

                return new AccountResponseDTO()
                {
                    Active = _account.Active,
                    AvailableLimite = _account.AvailableLimite
                };
            }
            else
            {
                throw new Exception("Account already initialized");
            }
        }

        
        public AccountResponseDTO Transaction(Transaction transaction)
        {
            if (_account == null)
                throw new Exception("Account not intialized");

            AccountResponseDTO response = new AccountResponseDTO()
            {
                Active = _account.Active,
                AvailableLimite = _account.AvailableLimite
            };

            if (_account.AddTransaction(transaction))
                response.AvailableLimite = _account.AvailableLimite;
            else
                response.Violation = "insuficient-limit";

            return response;
        }
    }
}