using Hotel_APIs.Data;
using Hotel_APIs.IRespository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Hotel_APIs.Repositories
{
    public class ReservationAgentsRespository : IReservationAgentsRespository
    {
        HotelDbCotext _hotelDbContext { get; }
        public ReservationAgentsRespository(HotelDbCotext hotelsDbContext) 
        {
            _hotelDbContext = hotelsDbContext;
        }

        public Task<List<ReservationAgents>> FindAllAsync()
        {
            return _hotelDbContext.reservationAgents.ToListAsync();
        }
    }
}
