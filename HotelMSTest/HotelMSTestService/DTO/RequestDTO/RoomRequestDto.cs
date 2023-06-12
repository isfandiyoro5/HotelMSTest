using HotelMSTestDataAccess.Models;

namespace HotelMSTestService.DTO.RequestDTO
{
    public class RoomRequestDto
    {
        public int RoomNumber { get; set; }

        public Occupancy Occupancy { get; set; }

        public double RoomPrice { get; set; }

        public RoomTypes RoomTypes { get; set; }

        public string RoomsDescription { get; set; }
    }
}