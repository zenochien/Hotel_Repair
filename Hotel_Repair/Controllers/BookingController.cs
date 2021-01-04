using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class BookingController : Controller
    {
        public BookingController(IBookingRespository repository)
        {
            _respository  = repository;
        }

        public IBookingRespository _respository { get; }

        public async Task<IActionResult> GetListBooking()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
