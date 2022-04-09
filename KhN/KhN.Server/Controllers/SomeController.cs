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


        [HttpGet("Get")]
        public IActionResult Get()
        {
            DoSomeCode1Command commande = new DoSomeCode1Command() { SomeProperty = "Hello LegoLearn.ir" };
            _mediatR.Send(commande);

            return Ok("OKkkk");
        }


        [HttpGet("Get2")]
        public IActionResult Get2()
        {
            DoSomeCode2Command commande = new DoSomeCode2Command() { SomeProperty = "Hello LegoLearn.ir" };
            _mediatR.Send(commande);

            return Ok("OKkkk");
        }


        [HttpGet("Get3")]
        public IActionResult Get3()
        {
            DoSomeCode3Command commande = new DoSomeCode3Command() { SomeProperty = "Hello LegoLearn.ir" };
            string message = _mediatR.Send<string>(commande).Result;

            return Ok(message);
        }
    }
}