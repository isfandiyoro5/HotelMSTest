﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMSTestDataAccess.Models
{
    public class Guest
    {
        public int GuestId { get; set; }

        public int BookingId { get; set; }

        public GuestPriority GuestPriority { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PassportNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }


        public List<Booking> Bookings { get; set; }

        public Bill Bill { get; set; }
    }

    public enum GuestPriority
    {
        Standart,
        CIP,
        VIP,
        DIP
    }
}
