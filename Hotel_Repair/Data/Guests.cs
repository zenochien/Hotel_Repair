﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_APIs.Data
{
    public class Guests
    {
        [Key]
        public Guid GuestID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCOde { get; set; }
        public string Country { get; set; }
        [Required]
        [StringLength(15)]
        public string HomePhoneNumber { get; set; }
        public string CellularNumber { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string eMailAddress { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<BookingStatus> Bookings { get; set; }
    }
}
