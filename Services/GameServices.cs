using Gameapp.Models; // Import the GameModel class.
using System.Text.Json; // Import the System.Text.Json namespace for JSON serialization.

namespace Gameapp.Services
{
    // GameServices is a service class responsible for reading game data from a JSON file.
    public class GameServices
    {
        // Constructor to initialize GameServices with the provided WebHostEnvironment.
        public GameServices(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // The WebHostEnvironment instance that provides information about the web hosting environment.
        public IWebHostEnvironment WebHostEnvironment { get; }

        // The private property that returns the path to the JSON file containing game data.
        private string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "Data", "GameData.json");

        // Method to retrieve a list of GameModel objects by reading data from the JSON file.
        public IEnumerable<GameModel> GetProducts()
        {
    
            using var jsonFileReader = File.OpenText(JsonFileName);

            // Deserialize the JSON data into an array of GameModel objects using JsonSerializer.
            // The PropertyNameCaseInsensitive option allows the deserialization to be case-insensitive when mapping JSON properties to C# properties.
            return JsonSerializer.Deserialize<GameModel[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })!;
        }
    }
}
