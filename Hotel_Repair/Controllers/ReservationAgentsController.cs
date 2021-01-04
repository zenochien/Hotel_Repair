using Hotel_APIs.IRespository;
using Hotel_APIs.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class ReservationAgentsController : Controller
    {
        public ReservationAgentsController(IReservationAgentsRespository repository)
        {
            _respository = repository;
        }

        IReservationAgentsRespository _respository { get; }

        public async Task<IActionResult> GetListReservationAgents()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
