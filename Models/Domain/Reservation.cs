namespace HotelManagementProject.Models.Domain
{
    public class Reservation
    {
        public string _id { get; set; }
        public string HotelId { get; set; } // Reference to the hotel at which the booking is made
        public string GuestName { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuests { get; set; }
    }
}
