using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class HotelsController : Controller
    {
        public HotelsController(IHotelsRespository repository)
        {
            _respository = repository;
        }

        public IHotelsRespository _respository { get; }

        public async Task<IActionResult> GetListHotels()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
