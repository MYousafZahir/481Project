using System.Collections.Generic;

namespace PlayerLink.Services
{
    public class GameDataService
    {
        public List<string> Games { get; set; }

        public GameDataService()
        {
            Games = new List<string>
            {
                "Counter-Strike: Global Offensive",
                "League of Legends",
                "Dota 2",
                "Fortnite",
                "PlayerUnknown's Battlegrounds",
                "Apex Legends",
                "Call of Duty: Warzone",
                "Overwatch",
                "Valorant",
                "Rocket League",
                "Minecraft",
                "Grand Theft Auto V",
                "Rainbow Six Siege",
                "Among Us",
                "Destiny 2",
                "Hearthstone",
                "Team Fortress 2",
                "StarCraft II",
                "World of Warcraft",
                "Path of Exile",
                "Warframe",
                "Paladins",
                "Battlefield V",
                "Genshin Impact",
                "The Division 2",
                "Smite",
                "Halo: The Master Chief Collection",
                "Splatoon 2",
                "Mario Kart 8 Deluxe",
                "Final Fantasy XIV Online"
            };
        }
    }
}
