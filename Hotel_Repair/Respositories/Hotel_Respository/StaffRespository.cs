using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class StaffRespository : IStaffRespository
    {
         HotelDbCotext _hotelDbContext { get; }
        public StaffRespository(HotelDbCotext hotelsDbContext)
        {
            _hotelDbContext = hotelsDbContext;
        }
       
        public Task<List<Staff>> FindAllAsync()
        {
            return _hotelDbContext.staffs.ToListAsync();
        }
    }
}
