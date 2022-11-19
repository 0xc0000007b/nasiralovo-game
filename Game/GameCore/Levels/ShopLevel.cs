using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class ShopLevel
    {
        private AsciiArts _arts = new AsciiArts();
        private Menu _menu = new Menu();
        public void StartLevel()
        {
            string[] opts = new[] { "buy products", "go away", "go home"};
            string prompt = $"{_arts.Shop}";
            
            _menu.MainMenu(prompt, opts);
            _menu.Run();
            int selectItem = _menu.SelectedOpt;
            switch (selectItem)
            {
                case 0:
                    BuyProducts();
                    break;
                case 1:
                    CityLevel cl = new CityLevel();
                    cl.StartLevel();
                    break;
                case 2:
                    Home home = new Home();
                    home.StartLevel();
                    break;
            }
        }

        private void BuyProducts()
        {
            Console.Clear();
            string prompt = $"yoy have been buy the meat" +"\n"+
                            $"{_arts.products}" 
                            +
                            "\n"
                            +
                            "what are you wanna doing next?";
            string[] opts = new[] { "go home", "go away" };
            
            _menu.MainMenu(prompt, opts);
            _menu.Run();
            int selectOpt = _menu.SelectedOpt;
            switch (selectOpt)
            { 
                case 0:
                 Home home = new Home();
                 home.StartLevel();
                 break;
                case 1:
                    CityLevel city = new CityLevel();
                    city.StartLevel();
                    break;
            }
        }
    }
}