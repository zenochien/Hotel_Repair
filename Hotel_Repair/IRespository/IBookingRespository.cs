using Hotel_APIs.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.IRespository
{
    public interface IBookingRespository 
    {
        Task<List<BookingStatus>> FindAllAsync(); 
    }
}