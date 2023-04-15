namespace PlayerLink.Models {
    public class Lobby
    {
        public int LobbyID { get; set; }
        public int NumPlayers {get; set; }
        public int MissingPlayers {get; set; }
        public string Game { get; set; } = "";
        public string LobbyName { get; set; } ="";
        public List<string> DesiredTags { get; set; } = new List<string>();
        public List<string> UndesiredTags { get; set; } = new List<string>();
        public string DescribeYourself { get; set; } = "";
    }
}