using Microsoft.AspNetCore.Mvc;
using Nu.BankAccount.Application.Usecases;
using Nu.BankAccount.Domain.Entities;

namespace Nu.BankAccount.API.Controllers
{
    public class CreateAccountOutput : IOutput
    {
        public IActionResult CreateAccountResult { get; set; }

        public void Ok(Account account)
        {
            var createAccountDTO = new CreateAccountResult()
            {
                Active = account.Active,
                AvailableLimite = account.AvailableLimite
            };

            CreateAccountResult = new OkObjectResult(account);
        }
    }
}
