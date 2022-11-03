using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    
    public class CityLevel
    {
        private Menu menu = new Menu();
        private AsciiArts arts = new AsciiArts();

        public void StartLevel()
        {
            Console.Clear();
            string[] opts = new[] { "go to shop", "go to home" };
            string prompt = $"{arts.City}";
            menu.MainMenu(prompt, opts);
            menu.Run();
            int selectOpt = menu.selectedOpt;
            switch (selectOpt)
            {
                case 1:
                    Home home = new Home();
                    home.StartLevel();
                    break;
                
            }
        }
    }
}