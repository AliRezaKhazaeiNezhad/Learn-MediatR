using MediatR;
using KhN.Server.Commands;
using Microsoft.AspNetCore.Mvc;
using FluentResults;
using KhN.Server.Notifications;

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


        [HttpGet("Get4")]
        public IActionResult Get4()
        {
            DoSomeCode4Command commande = new DoSomeCode4Command() { SomeProperty = "Hello LegoLearn.ir" };
            string message = _mediatR.Send<string>(commande).Result;

            return Ok(message);
        }


        [HttpGet("Get5")]
        public IActionResult Get5()
        {
            DoSomeCode5Command commande = new DoSomeCode5Command() { SomeProperty = "Hello LegoLearn.ir" };
            Result result = _mediatR.Send<Result>(commande).Result;

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet("Get6")]
        public IActionResult Get6()
        {
            DoSomeCode6Command commande = new DoSomeCode6Command() { SomeProperty = "Hello LegoLearn.ir" };
            Result<string> result = _mediatR.Send(commande).Result;

            if (result.IsSuccess)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.ToResult());
            }
        }


        [HttpGet("Get7")]
        public IActionResult Get7()
        {
            try
            {
                DoSomeCodeNotification notif = new DoSomeCodeNotification() { SomeProperty = "Hello LegoLearn.ir" };
                _mediatR.Publish(notif);

                return Ok("It is done");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}