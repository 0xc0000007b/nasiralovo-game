using System;
using Game.GameCore.Utils;
using Game.GameCore.Utils.Dialogues;


namespace Game.GameCore.Levels
{
    public class StationLevel
    {
        
        private AsciiArts _arts = new AsciiArts();
        private Menu _menu = new Menu();
       
           

        public void StartLevel()
        {
            
            string prompt = $"{_arts.Station}";
            string[] opts = new[] { "enter the station", "go away" };
            _menu.MainMenu(prompt,opts);
            _menu.Run();
            int selOpt = _menu.SelectedOpt;
            switch (selOpt)
            {
                case 0:
                    Console.Clear();
                    EnterTheStation();
                    break;
                case 1:
                    Console.Clear();
                    StreetLevel street = new StreetLevel();
                    street.StartLevel();
                    break;
            }
        }
        
        public void EnterTheStation()
        {
            string[] options = new[] { "ask question", "go away" };
            string promt = $"{_arts.Men}";
            Console.WriteLine("you have enter the station and seeing the men");
            _menu.MainMenu(promt, options);
            
            Console.WriteLine("what are you wanna doing?");
            _menu.Run();
            int selectItem = _menu.SelectedOpt;
            switch (selectItem)
            {
                case 0:
                    DialSystem dial = new DialSystem();
                    dial.StartDialog();
                    break;
                case 1:
                    StreetLevel street = new StreetLevel();
                    street.StartLevel();
                    break;
            }
        }
    }
}


