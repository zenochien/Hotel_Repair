using IdentityServer4.Models;
using System.Collections.Generic;

namespace HotelIdentityServer4.Controllers
{
    public class ApiScopes
    {
        public static IEnumerable<ApiScope> Configuration()
        {
            return new List<ApiScope>
            {
                new ApiScope("Hotel_Read"),
                new ApiScope("Hotel_Write")
            };
        }
    }
}
