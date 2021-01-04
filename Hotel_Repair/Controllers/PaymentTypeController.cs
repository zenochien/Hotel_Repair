using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class PaymentTypeController : Controller
    {
         IPaymentTypeRepository _respository { get; }

        public PaymentTypeController(IPaymentTypeRepository repository)
        {
            _respository = repository;
        }

        public async Task<IActionResult> GetListPaymentType()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}