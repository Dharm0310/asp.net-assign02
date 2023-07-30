using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gameapp.Services;
using Gameapp.Models;
using System.Collections.Generic;

namespace Gameapp.Pages
{
    public class GameListModel : PageModel
    {
        private readonly GameServices _gameServices;

        public List<GameModel> Games { get; private set; }

        public GameListModel(GameServices gameServices)
        {
            _gameServices = gameServices;
        }

        public void OnGet()
        {
            // Retrieve the games using the GameServices
            IEnumerable<GameModel> gameModels = _gameServices.GetProducts();
            Games = new List<GameModel>(gameModels);
        }
    }
}
