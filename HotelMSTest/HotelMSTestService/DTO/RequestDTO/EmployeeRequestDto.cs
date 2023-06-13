using HotelMSTestDataAccess.Models;

namespace HotelMSTestService.DTO.RequestDTO
{
    public class EmployeeRequestDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public double Salary { get; set; }
    }
}