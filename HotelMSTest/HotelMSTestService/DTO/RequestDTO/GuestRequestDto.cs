using HotelMSTestDataAccess.Models;

namespace HotelMSTestService.DTO.RequestDTO
{
    public class GuestRequestDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string PassportNumber { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public GuestPriority GuestPriority { get; set; }
    }
}