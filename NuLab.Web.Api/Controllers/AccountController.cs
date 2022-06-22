using Microsoft.AspNetCore.Mvc;
using NuLab.Domain.Entities.DTO;
using NuLab.Domain.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NuLab.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountServices _service;


        public AccountController(IAccountServices service)
        {
            _service = service;
        }


        // GET: api/<AccountController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var response = _service.Get();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST api/<AccountController>
        [HttpPost]
        public ActionResult Post([FromBody] int availableLimite)
        {
            try
            {
                var response = _service.Create(availableLimite);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
