using System.Collections.Generic;
using PlayerLink.Models;

namespace PlayerLink.Services {
    public class UserDataService
    {
        public List<User> Users { get; set; }

        public UserDataService()
        {
            Users = CreateSampleUsers();
        }
        // CRITICAL, CHANGE THIS TO GETUSERBYID since we can have duplicate usernames? maybe?
        public User GetUserByUsername(string username){
            return Users.FirstOrDefault(u => u.Username == username);
        }

        private List<User> CreateSampleUsers()
        {
            return new List<User>
            {
                new User
                {
                    Username = "Alice",
                    UserID = "0001",
                    ProfilePicture = "img/ProfilePicture-1.svg",
                    Status = "Online",
                    Description = "Hello, I'm Alice!",
                    Tags = new List<string> { "Friendly", "Casual", "Team player" },
                    Friends = new List<string> {"Bob", "Charlie"}
                },
                new User
                {
                    Username = "Bob",
                    UserID = "0002",
                    ProfilePicture = "img/ProfilePicture-2.svg",
                    Status = "Offline",
                    Description = "Hi, I'm Bob!",
                    Tags = new List<string> { "Competitive", "Strategy", "Communication" },
                    Friends = new List<string> {"Alice", "Charlie"}
                },
                new User
                {
                    Username = "Charlie",
                    UserID = "0003",
                    ProfilePicture = "img/ProfilePicture-3.svg",
                    Status = "Away",
                    Description = "Hey, I'm Charlie!",
                    Tags = new List<string> { "Adaptive", "Quick learner", "Supportive" },
                    Friends = new List<string> {"Alice", "Bob"}
                }
            };
        }
    }

}
