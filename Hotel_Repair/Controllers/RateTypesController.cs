using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class RateTypesController : Controller
    {
        IRateTypesRespository _respository { get; }

        public RateTypesController(IRateTypesRespository repository)
        {
            _respository = repository;
        }

        public async Task<IActionResult> GetListRateType()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
