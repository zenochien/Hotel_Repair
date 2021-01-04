using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    internal class RoomTypesRespository :  IRoomTypesRespository
    {
        HotelDbCotext _hotelDbContext { get; }
        public  RoomTypesRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<RoomTypes>> FindAllAsync()
        {
            return _hotelDbContext.roomTypes.ToListAsync();
        }
    }
}
