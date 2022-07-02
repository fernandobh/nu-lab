using Microsoft.AspNetCore.Mvc;
using Nu.BankAccount.Application.Usecases;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nu.BankAccount.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private ICreateAccountUseCase _createAccountUseCase;

        public AccountController(ICreateAccountUseCase createAccountUseCase)
        {
            _createAccountUseCase = createAccountUseCase;
        }


        [HttpPost]
        public IActionResult Post(
            [FromForm][Required] bool active,
            [FromForm][Required] int availableLimite)
        {
            try
            {
                var output = new CreateAccountOutput();
                var input = new CreateAccountInput()
                {
                    Active = active,
                    AvailableLimite = availableLimite
                };

                _createAccountUseCase.Execute(output, input);
                return output.CreateAccountResult;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
