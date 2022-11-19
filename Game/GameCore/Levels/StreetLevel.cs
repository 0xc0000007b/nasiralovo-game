using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class StreetLevel
    {
        private AsciiArts _arts = new AsciiArts();
        private Menu _menu = new Menu();
        private StationLevel _stationLevel = new StationLevel();
        private CityLevel _cityLevel = new CityLevel();
        public void StartLevel()
        {
            Console.Clear();
            string prompt = $"{_arts.Street}";
            string[] opts = new[] {  "go to city", "go to station", "return to carriage"};
            _menu.MainMenu(prompt,opts);
            _menu.Run();
            int select = _menu.SelectedOpt;
            switch (select)
            {
                case 0:
                    Console.Clear();
                    _cityLevel.StartLevel();
                    break;
                case 1:
                    Console.Clear();
                    _stationLevel.StartLevel();
                    break;
                case 2:
                    Console.Clear();
                    TrainLevel _trainLevel = new TrainLevel();
                    _trainLevel.StartGame();
                    break;
            }
        }
    }
}