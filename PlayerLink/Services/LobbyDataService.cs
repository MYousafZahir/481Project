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
            lobby.UpdateMissingPlayers();
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
                    NumPlayers = 2,
                    MaxUsers = 5,
                    Game = "Valorant",
                    LobbyName = "Lobby Alpha",
                    DesiredTags = new List<string> { "Casual", "Friendly" },
                    UndesiredTags = new List<string> { "Competitive", "Toxic" },
                    DescribeYourself = "A relaxed and friendly environment for casual players.",
                    Users = new List<User> { userAlice, userBob }
                },
                new Lobby
                {
                    LobbyID = 2,
                    NumPlayers = 1,
                    MaxUsers = 5,
                    Game = "League of Legends",
                    LobbyName = "Lobby Beta",
                    DesiredTags = new List<string> { "Competitive", "Teamwork" },
                    UndesiredTags = new List<string> { "Trolling", "AFK" },
                    DescribeYourself = "Focused on competitive gameplay and team coordination.",
                    Users = new List<User> { userAlice }
                },
                new Lobby
                {
                    LobbyID = 3,
                    NumPlayers = 1,
                    MaxUsers = 2,
                    Game = "League of Legends",
                    LobbyName = "Lobby Gamma",
                    DesiredTags = new List<string> { "Strategy", "Competitive" },
                    UndesiredTags = new List<string> { "Solo", "Ragequit" },
                    DescribeYourself = "I need a duo who is female.",
                    Users = new List<User> { userCharlie }
                }
            };
        }
        
    }
}
