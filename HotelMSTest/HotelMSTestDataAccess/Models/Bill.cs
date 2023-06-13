namespace HotelMSTestDataAccess.Models
{
    public class Bill
    {
        public int InvoiceNumber { get; set; }

        public int BookingId { get; set; }

        public int GuestId { get; set; }

        public int RoomCharge { get; set; }

        public int RoomService { get; set; }

        public int RestaurantCharges { get; set; }

        public int BarCharges { get; set; }

        public int MiscellaneousCharges { get; set; }

        public DateTime IfLateCheckout { get; set; }

        public DateTime PaymentDate { get; set; }

        public PaymentMode PaymentMode { get; set; }

        public string CreditNumber { get; set; }

        public DateTime ExpireDate { get; set; }

        public string ChequeNumber { get; set; }


        public Guest Guest { get; set; }

        public Booking Booking { get; set; }
    }

    public enum PaymentMode
    {
        Uzcard,
        Humo,
        VisaCard,
        Cash
    }
}