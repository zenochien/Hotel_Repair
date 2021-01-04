using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class HotelRepository : IHotelsRespository
    {
        HotelDbCotext _hotelDbContext { get; }

        public HotelRepository(HotelDbCotext hotelsDbContext) 
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<Hotels>> FindAllAsync()
        {
            return _hotelDbContext.hotels.ToListAsync();
        }
    }
}

