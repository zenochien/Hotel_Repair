using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class BookingStatusController : Controller
    {
        public BookingStatusController(IBookingStatusRespository repository)
        {
            _respository = repository;
        }

        public IBookingStatusRespository _respository { get; }

        public async Task<IActionResult> GetListBookingStatus()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
