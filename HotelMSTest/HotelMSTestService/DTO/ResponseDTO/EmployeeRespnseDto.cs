﻿namespace HotelMSTestService.DTO.ResponseDTO
{
    public class EmployeeRespnseDto
    {
        public int EmployeeId { get; set; }

        public int HotelId { get; set; }

        public int RoleId { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public double Salary { get; set; }
    }
}