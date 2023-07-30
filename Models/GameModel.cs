using System.Text.Json.Serialization;

namespace Gameapp.Models
{
    // GameModel represents the model class for storing information about a video game.
    public class GameModel
    {
        // The title of the game.
        public string Title { get; set; }

        // The platform(s) on which the game is available.
        public string Platform { get; set; }

        // The genre or category of the game 
        public string Genre { get; set; }

        // The release date of the game.
        public string ReleaseDate { get; set; }

        // The URL to the image representing the game's cover or logo.
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }
    }
}
