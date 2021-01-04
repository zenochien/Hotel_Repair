using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class PaymentStatusController : Controller
    {
        public PaymentStatusController(IPaymentStatusRespository repository)
        {
            _respository = repository;
        }

        public IPaymentStatusRespository _respository { get; }

        public async Task<IActionResult> GetListBooking()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
