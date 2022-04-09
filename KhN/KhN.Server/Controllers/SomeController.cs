using MediatR;
using KhN.Server.Commands;
using Microsoft.AspNetCore.Mvc;

namespace KhN.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SomeController : ControllerBase
    {
        protected IMediator _mediatR { get; set; }

        public SomeController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }


        [HttpGet]
        public IActionResult Get()
        {
            DoSomeCode1Command commande = new DoSomeCode1Command() { SomeProperty = "Hello LegoLearn.ir" };
            _mediatR.Send(commande);

            return Ok("OKkkk");
        }
    }
}