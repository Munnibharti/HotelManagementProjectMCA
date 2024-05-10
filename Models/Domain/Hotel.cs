namespace HotelManagementProject.Models.Domain
{
    public class Hotel
    {
        public string _id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; } // Directly include phone number
        public string Email { get; set; } // Directly include email

    }
}
