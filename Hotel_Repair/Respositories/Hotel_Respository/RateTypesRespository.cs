using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class RateTypesRespository : IRateTypesRespository
    {
        HotelDbCotext _hotelDbContext { get; }
        public RateTypesRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<RateTypes>> FindAllAsync()
        {
            return _hotelDbContext.rateTypes.ToListAsync();
        }
    }
}
