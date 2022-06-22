using NuLab.Domain.Entities;

namespace NuLab.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Account Get();
        void CreateOrUpdate(Account account);
    }
}
