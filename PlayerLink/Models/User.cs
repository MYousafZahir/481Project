namespace PlayerLink.Models {
    public class User
    {
        public string Username { get; set; } = "";
        public string UserID { get; set; } = "001";
        public string ProfilePicture { get; set; } = "";
        public string Status { get; set; } = "";
        public string? Description { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
    }

}
