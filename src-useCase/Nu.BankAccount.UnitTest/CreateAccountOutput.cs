using Nu.BankAccount.Application.Usecases;
using Nu.BankAccount.Domain.Entities;

namespace Nu.BankAccount.UnitTest
{
    public class CreateAccountOutput : IOutput
    {
        public Account CreateAccountResult { get; set; }

        public void Ok(Account account)
        {
            CreateAccountResult = account;
        }
    }
}
