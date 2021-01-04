using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class RatesController : Controller
    {
        IRatesRespository _respository { get; }

        public RatesController(IRatesRespository repository)
        {
            _respository = repository;
        }

        public async Task<IActionResult> GetListRates()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
