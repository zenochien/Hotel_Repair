using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    internal class StaffRoomsRespository : IStaffRoomsRespository
    {
        HotelDbCotext _hotelDbContext { get; }
        public StaffRoomsRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<StaffRooms>> FindAllAsync()
        {
            return _hotelDbContext.staffRooms.ToListAsync();
        }
    }
}
