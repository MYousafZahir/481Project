using System.Collections.Generic;
using PlayerLink.Models;

namespace PlayerLink.Services
{
    public class LobbyDataService
    {
        public List<Lobby> Lobbies { get; set; }

        public LobbyDataService()
        {
            Lobbies = CreateSampleLobbies();
        }
        public void AddLobby(Lobby newLobby)
        {
            Lobbies.Add(newLobby);
        }

        private List<Lobby> CreateSampleLobbies()
        {
            return new List<Lobby>
            {
                new Lobby
                {
                    LobbyID = 1,
                    NumPlayers = 2,
                    MissingPlayers = 3,
                    Game = "Valorant",
                    LobbyName = "Lobby Alpha",
                    DesiredTags = new List<string> { "Casual", "Friendly" },
                    UndesiredTags = new List<string> { "Competitive", "Toxic" },
                    DescribeYourself = "A relaxed and friendly environment for casual players."
                },
                new Lobby
                {
                    LobbyID = 2,
                    NumPlayers = 1,
                    MissingPlayers = 4,
                    Game = "League of Legends",
                    LobbyName = "Lobby Beta",
                    DesiredTags = new List<string> { "Competitive", "Teamwork" },
                    UndesiredTags = new List<string> { "Trolling", "AFK" },
                    DescribeYourself = "Focused on competitive gameplay and team coordination."
                },
                new Lobby
                {
                    LobbyID = 3,
                    NumPlayers = 1,
                    MissingPlayers = 1,
                    Game = "League of Legends",
                    LobbyName = "Lobby Gamma",
                    DesiredTags = new List<string> { "Strategy", "Competitive" },
                    UndesiredTags = new List<string> { "Solo", "Ragequit" },
                    DescribeYourself = "I need a duo who is female."
                }
            };
        }
    }
}
