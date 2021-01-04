using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class RoomsBookedRespository : IRoomsTypesRespository
    {
        HotelDbCotext _hotelDbContext { get; }
        public RoomsBookedRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<RoomsBooked>> FindAllAsync()
        {
            return _hotelDbContext.roomsBookeds.ToListAsync();
        }
    }
}
