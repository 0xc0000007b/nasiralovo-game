using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class TrainLevel
    {
        private Menu _menu = new Menu();
        private AsciiArts _arts = new AsciiArts();
        private StreetLevel _streetLevel = new StreetLevel();
            
        public void StartGame()
        {
            string[] options = new[] { "exit the carriage", "sleep", "exit the game" };
            string prompt = $"{_arts.Train}";
            _menu.MainMenu(prompt, options);
            _menu.Run();
            int select = _menu.SelectedOpt;
            switch (select)
            {
                case 0:
                    ExitTheTrain();
                    break;
                case 1:
                     Game g = new Game();
                    Console.Clear();
                    Sleep();
                    g.Exit();
                    break;
                case 2:
                    Game gm = new Game();
                    gm.Exit();
                    break;
            }
        }
        private void ExitTheTrain()
        {
            Console.WriteLine("You have exit from the carriage.");
            string prt = $"{_arts.Street}";
            Console.WriteLine(prt);
            _streetLevel.StartLevel();
        }
        public void Sleep()
        {
            Console.WriteLine($"{_arts.Sleep}");
            Console.WriteLine("you have fall down snd sleeping. And return in start city");
        }
    }
}