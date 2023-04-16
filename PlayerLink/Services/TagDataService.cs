using System.Collections.Generic;

namespace PlayerLink.Services
{
    public class TagDataService
    {
        public List<string> Tags { get; set; }

        public TagDataService()
        {
            Tags = new List<string>
            {
                "Strategy",
                "Action",
                "Adventure",
                "Puzzle",
                "Simulation",
                "Sports",
                "Racing",
                "RPG",
                "FPS",
                "Platformer",
                "Indie",
                "Multiplayer",
                "Casual",
                "Horror",
                "Sandbox",
                "Open World",
                "Survival",
                "Arcade",
                "Retro",
                "Turn-Based",
                "Shooter",
                "Singleplayer",
                "Story Rich",
                "Fantasy",
                "Sci-Fi",
                "Stealth",
                "Exploration",
                "Point & Click",
                "Visual Novel",
                "Fighting",
                "Card Game",
                "Board Game"
            };
        }
    }
}
