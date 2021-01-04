using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class GuestRespository : IGuestsRespository
    {
        HotelDbCotext _hotelDbContext { get; }

        public GuestRespository(HotelDbCotext hotelsDbContext) 
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<Positions>> FindAllAsync()
        {
            return _hotelDbContext.positions.ToListAsync();
        }
    }
}
