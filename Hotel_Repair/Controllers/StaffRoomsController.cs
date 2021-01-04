using Hotel_APIs.IRespository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_APIs.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class StaffRoomsTypeController : Controller
    {
        public StaffRoomsTypeController(IStaffRoomsRespository repository)
        {
            _respository = repository;
        }

        IStaffRoomsRespository _respository { get; }

        public async Task<IActionResult> GetListStaffRooms()
        {
            return Json(await _respository.FindAllAsync());
        }
    }
}
