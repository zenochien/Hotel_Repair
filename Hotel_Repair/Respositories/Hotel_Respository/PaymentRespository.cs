using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class PaymentRespository : IPaymentsRespository
    {
        HotelDbCotext _hotelDbContext { get; }

        public PaymentRespository(HotelDbCotext hotelsDbContext) 
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<Payments>> FindAllAsync()
        {
            return _hotelDbContext.payments.ToListAsync();
        }
    }
}
