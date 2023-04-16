using System.Collections.Generic;
using PlayerLink.Models;

namespace PlayerLink.Services
{
    public class LobbyDataService
    {
        public List<Lobby> Lobbies { get; set; }
        private UserDataService UserDataService { get; set; }

        public LobbyDataService()
        {
            UserDataService = new UserDataService();
            Lobbies = CreateSampleLobbies();
        }
        public event Action OnLobbyAdded;

        public void AddLobby(Lobby lobby)
        {
            Lobbies.Add(lobby);
            OnLobbyAdded?.Invoke();
        }

        private List<Lobby> CreateSampleLobbies()
        {
            var userAlice = UserDataService.GetUserByUsername("Alice");
            var userBob = UserDataService.GetUserByUsername("Bob");
            var userCharlie = UserDataService.GetUserByUsername("Charlie");

            return new List<Lobby>
            {
                new Lobby
                {
                    LobbyID = 1,
                    MaxUsers = 5,
                    Game = "Valorant",
                    LobbyName = "Lobby Alpha",
                    DesiredTags = new List<string> { "Casual", "Friendly" },
                    UndesiredTags = new List<string> { "Competitive", "Toxic" },
                    DescribeYourselfTags = new List<string> { "Relaxed", "FriendlyEnvironment", "CasualPlayers" },
                    Users = new List<User> { userAlice, userBob }
                },
                new Lobby
                {
                    LobbyID = 2,
                    MaxUsers = 5,
                    Game = "League of Legends",
                    LobbyName = "Lobby Beta",
                    DesiredTags = new List<string> { "Competitive", "Teamwork" },
                    UndesiredTags = new List<string> { "Trolling", "AFK" },
                    DescribeYourselfTags = new List<string> { "Focused", "CompetitiveGameplay", "TeamCoordination" },
                    Users = new List<User> { userAlice }
                },
                new Lobby
                {
                    LobbyID = 3,
                    MaxUsers = 2,
                    Game = "League of Legends",
                    LobbyName = "Lobby Gamma",
                    DesiredTags = new List<string> { "Strategy", "Competitive" },
                    UndesiredTags = new List<string> { "Solo", "Ragequit" },
                    DescribeYourselfTags = new List<string> { "DuoNeeded", "Female" },
                    Users = new List<User> { userCharlie }
                }
            };
        }

    }
}
