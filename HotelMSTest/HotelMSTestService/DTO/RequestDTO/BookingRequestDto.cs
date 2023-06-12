namespace HotelMSTestService.DTO.RequestDTO
{
    public class BookingRequestDto
    {
        public DateTime BookingDate { get; set; }

        public DateTime BookingTime { get; set; }

        public DateTime ArrivalDate { get; set; }

        public DateTime DepartureDate { get; set; }

        public int NumberAdults { get; set; }

        public int NumberChildren { get; set; }
    }
}