using Nu.BankAccount.Domain.Entities;

namespace Nu.BankAccount.Application.Usecases
{
    public class CreateAccountUseCase : ICreateAccountUseCase
    {
        private IOutput _output;

        public void Execute(IOutput output, CreateAccountInput input)
        {
            _output = output;
            var account = new Account(input.Active, input.AvailableLimite);
            _output.Ok(account);
        }
    }
}
