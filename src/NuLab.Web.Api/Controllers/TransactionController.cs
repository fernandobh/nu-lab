using Microsoft.AspNetCore.Mvc;
using NuLab.Domain.Entities;
using NuLab.Domain.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NuLab.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private IAccountServices _service;


        public TransactionController(IAccountServices service)
        {
            _service = service;
        }


        // POST api/<AccountController>
        [HttpPost]
        public ActionResult Post([FromBody] Transaction transaction)
        {
            var response = _service.Transaction(transaction);

            if (string.IsNullOrEmpty(response.Violation))
                return Ok(response);
            else
                return BadRequest(response);
        }
    }
}
