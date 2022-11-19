using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    
    public class CityLevel
    {
        private Menu _menu = new Menu();
        private AsciiArts _arts = new AsciiArts();

        public void StartLevel()
        {
            Console.Clear();
            string[] opts = new[] { "go to shop", "go to home", "go to street station"};
            string prompt = $"{_arts.City}";
            _menu.MainMenu(prompt, opts);
            _menu.Run();
            int selectOpt = _menu.SelectedOpt;
            switch (selectOpt)
            {
                case 0:
                    Console.Clear();
                    ShopLevel shop = new ShopLevel();
                    shop.StartLevel();
                    break;
                case 1:
                    Console.Clear();
                    Home home = new Home();
                    home.StartLevel();
                    break;
                case 2:
                    Console.Clear();
                    StreetLevel street = new StreetLevel();
                    street.StartLevel();
                    break;
            }
        }
    }
}