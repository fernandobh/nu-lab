namespace Nu.BankAccount.Application.Usecases
{
    public interface ICreateAccountUseCase
    {
        void Execute(IOutput output, CreateAccountInput input);
    }
}
