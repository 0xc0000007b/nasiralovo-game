using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class StreetLevel
    {
        private AsciiArts arts = new AsciiArts();
        private Menu menu = new Menu();
        private StationLevel sl = new StationLevel();
        private CityLevel city = new CityLevel();
        public void StartLevel()
        {
            Console.Clear();
            string prompt = $"{arts.Street}";
            string[] opts = new[] {  "go to city", "go to station", "return to carriage"};
            menu.MainMenu(prompt,opts);
            menu.Run();
            int select = menu.selectedOpt;
            switch (select)
            {
                case 0:
                    Console.Clear();
                    city.StartLevel();
                    break;
                case 1:
                    Console.Clear();
                    sl.StartLevel();
                    break;
                case 2:
                    Console.Clear();
                    TrainLevel tl = new TrainLevel();
                    tl.StartGame();
                    break;
            }
        }
    }
}