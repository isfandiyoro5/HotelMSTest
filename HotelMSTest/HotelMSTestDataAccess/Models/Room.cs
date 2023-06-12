using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMSTestDataAccess.Models
{
    public class Room
    {
        public int RoomNumber { get; set; }

        public int RoomId { get; set; }

        public int RoomTypeId { get; set; }

        public int HotelId { get; set; }

        public Occupancy Occupancy { get; set; }

        public RoomTypes RoomTypes { get; set; }

        public double RoomPrice { get; set; }

        public string RoomImage { get; set; }

        public string RoomsDescription { get; set; }


        public Hotel Hotel { get; set; }
    }

    public enum Occupancy
    {
        Empty,
        Busy
    }

    public enum RoomTypes
    {
        Standard,
        Deluxe,
        JuniorSuite,
        SeniorSuite
    }
}
