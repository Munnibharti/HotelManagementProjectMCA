namespace HotelManagementProject.Models.Domain
{
    public class Room
    {
        public string _id { get; set; }
        public string HotelId { get; set; } // Reference to the hotel to which the room belongs
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
