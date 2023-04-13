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
                    Tags = new List<string> { "tag1", "tag2", "tag3" }
                },
                new User
                {
                    Username = "Bob",
                    UserID = "0002",
                    ProfilePicture = "img/ProfilePicture-2.svg",
                    Status = "Offline",
                    Description = "Hi, I'm Bob!",
                    Tags = new List<string> { "tag1", "tag4", "tag5" }
                },
                new User
                {
                    Username = "Charlie",
                    UserID = "0003",
                    ProfilePicture = "img/ProfilePicture-3.svg",
                    Status = "Away",
                    Description = "Hey, I'm Charlie!",
                    Tags = new List<string> { "tag2", "tag4", "tag6" }
                }
            };
        }
    }

}
