﻿using Hotel_APIs.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_APIs.IRespository
{
    public interface IBookingStatusRespository 
    {
        Task<List<BookingStatus>> FindAllAsync();
    }
}
