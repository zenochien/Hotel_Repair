using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class PaymentStatusRepostory : IPaymentStatusRespository
    {
        HotelDbCotext _hotelDbContext { get; }

        public PaymentStatusRepostory(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<PaymentStatus>> FindAllAsync()
        {
            return _hotelDbContext.paymentStatuses.ToListAsync();
        }
    }
}
