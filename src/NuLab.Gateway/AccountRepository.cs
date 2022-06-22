using NuLab.Domain.Entities;
using NuLab.Domain.Interfaces;

namespace NuLab.Gateway
{
    public class AccountRepository : IAccountRepository
    {
        private Account _account;

        public Account Get()
        {
            return _account;
        }

        public void CreateOrUpdate(Account account)
        {
            _account = account;
        }
    }
}