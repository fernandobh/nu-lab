using Nu.BankAccount.Domain.Entities;

namespace Nu.BankAccount.Application.Usecases
{
    public interface IOutput
    {
        void Ok(Account account);
    }
}
