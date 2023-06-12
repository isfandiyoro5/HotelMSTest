﻿using HotelMSTestDataAccess.Models;

namespace HotelMSTestService.DTO.ResponseDTO
{
    public class GuestResponseDto
    {
        public int GuestId { get; set; }

        public int BookingId { get; set; }

        public GuestPriority GuestPriority { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}