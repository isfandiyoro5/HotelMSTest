using HotelMSTestDataAccess.Models;

namespace HotelMSTestService.DTO.ResponseDTO
{
    public class HotelResponseDto
    {
        public int HotelId { get; set; }

        public string HotelName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public StarRating StarRating { get; set; }
    }
}