using HotelMSTestDataAccess.Models;

namespace HotelMSTestService.DTO.ResponseDTO
{
    public class RoomResponseDto
    {
        public int RoomId { get; set; }

        public int RoomNumber { get; set; }

        public int RoomTypeId { get; set; }

        public int HotelId { get; set; }

        public Occupancy Occupancy { get; set; }

        public double RoomPrice { get; set; }

        public string RoomImage { get; set; }

        public string RoomsDescription { get; set; }
    }
}