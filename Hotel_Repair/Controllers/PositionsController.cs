using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class PositionsController : Controller
    {
        IPositionsRespository _respository { get; }

        public PositionsController(IPositionsRespository repository)
        {
            _respository = repository;
        }

        public async Task<IActionResult> GetListPositions()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
