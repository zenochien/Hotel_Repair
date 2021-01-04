using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class RatesRespository :  IRatesRespository
    {
        private HotelDbCotext _hotelDbContext;
        public RatesRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<Rates>> FindAllAsync()
        {
            return _hotelDbContext.rates.ToListAsync();
        }

    }
}
