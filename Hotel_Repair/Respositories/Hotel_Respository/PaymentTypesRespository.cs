using System.Collections.Generic;
using System.Threading.Tasks;
using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;

namespace Hotel_APIs.Repositories
{
    public class PaymentTypesRespository : IPaymentTypeRepository
    {
        HotelDbCotext _hotelDbContext { get; }

        public PaymentTypesRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<PaymentTypes>> FindAllAsync()
        {
            return _hotelDbContext.paymentTypes.ToListAsync();
        }
    }
}