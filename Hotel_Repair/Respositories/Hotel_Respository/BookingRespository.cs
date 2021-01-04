using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    internal class BookingRespository : IBookingRespository
    {
        HotelDbCotext _hotelDbContext { get; }

        public BookingRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<BookingStatus>> FindAllAsync()
        {
            return _hotelDbContext.bookings.ToListAsync();
        }
    }
}