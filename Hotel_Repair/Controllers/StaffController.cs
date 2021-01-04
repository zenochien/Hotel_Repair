using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class StaffController : Controller
    {
        public StaffController(IStaffRespository repository)
        {
            _respository = repository;
        }

        IStaffRespository _respository { get; }

        public async Task<IActionResult> GetListStaff()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
