using HotelMSTestDataAccess.Models;

namespace HotelMSTestService.DTO.RequestDTO
{
    public class BillRequestDto
    {
        public DateTime IfLateCheckout { get; set; }

        public DateTime PaymentDate { get; set; }

        public PaymentMode PaymentMode { get; set; }

        public int RoomCharge { get; set; }

        public int RoomService { get; set; }

        public int RestaurantCharges { get; set; }

        public int BarCharges { get; set; }

        public int MiscellaneousCharges { get; set; }

        public string CreditCardNumber { get; set; }

        public DateTime ExpireDate { get; set; }
    }
}