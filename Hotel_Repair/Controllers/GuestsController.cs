using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class GuestsController : Controller
    {
        public GuestsController(IGuestsRespository repository)
        {
            _respository = repository;
        }

        public IGuestsRespository _respository { get; }

        public async Task<IActionResult> GetGuest()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
