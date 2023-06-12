using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMSTestDataAccess.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
       
        public int HotelId { get; set; }
        
        public int GuestId { get; set; }
        
        public int RoomNumber { get; set; }
        
        public DateTime BookingDate { get; set; }
        
        public DateTime BookingTime { get; set; }
        
        public DateTime ArrivalDate { get; set; }
        
        public DateTime DepartureDate { get; set; }
        
        public int NumberAdults { get; set; }
        
        public int NumberChildren { get; set; }


        public List<Room> Rooms { get; set; }

        public Hotel Hotel { get; set; }

        public Guest Guest { get; set; }

        public Bill Bill { get; set; }
    }
}
