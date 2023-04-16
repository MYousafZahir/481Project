namespace PlayerLink.Models
{
    public class Lobby
    {
        public int LobbyID { get; set; }
        public int NumPlayers => Users.Count;
        public int MissingPlayers => MaxUsers - NumPlayers;
        public string Game { get; set; } = "";
        public string LobbyName { get; set; } = "";
        public List<string> DesiredTags { get; set; } = new List<string>();
        public List<string> UndesiredTags { get; set; } = new List<string>();
        public List<string> DescribeYourselfTags { get; set; } = new List<string>();
        public List<User> Users { get; set; } = new List<User>();
        public int MaxUsers { get; set; } = 5; // Set the maximum number of users allowed in a lobby

        public bool IsFull()
        {
            return Users.Count >= MaxUsers;
        }

        public bool AddUser(User user)
        {
            if (!IsFull())
            {
                Users.Add(user);
                return true;
            }
            return false;
        }
    }
}
