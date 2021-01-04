using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class BookingStatusRespository : IBookingStatusRespository
    {
        HotelDbCotext _hotelDbContext { get; }

        public BookingStatusRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<BookingStatus>> FindAllAsync()
        {
            return _hotelDbContext.bookingStatuses.ToListAsync();
        }
    }
}
