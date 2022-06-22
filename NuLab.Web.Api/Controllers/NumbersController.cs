using Microsoft.AspNetCore.Mvc;
using NuLab.Domain.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NuLab.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        IPrimeNumberCheckerUseCase _useCase;

        public NumbersController(IPrimeNumberCheckerUseCase useCase)
        {
            this._useCase = useCase;
        }


        // POST api/<NumbersController>
        [HttpPost("PrimeNumberChecker")]
        public bool PrimeNumberChecker(int value)
        {
            return _useCase.Execute(value);
        }
    }
}
