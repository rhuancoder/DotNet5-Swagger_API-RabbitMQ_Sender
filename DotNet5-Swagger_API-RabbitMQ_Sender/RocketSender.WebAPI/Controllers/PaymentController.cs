using RocketSender.Entities;
using Microsoft.AspNetCore.Mvc;

namespace RocketSender.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [Route("InsertPayment")]
        [HttpPost]
        public IActionResult InsertPayment(PaymentCommand payment)
        {
            return Ok();
        }
    }
}