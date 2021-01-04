using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class RoomsController : Controller
    {
        public RoomsController(IRoomsRespository repository)
        {
            _respository = repository;
        }

        IRoomsRespository _respository { get; }

        public async Task<IActionResult> GetListReservationAgents()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
