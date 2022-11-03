using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class TrainLevel
    {
        private Menu menu = new Menu();
        private AsciiArts arts = new AsciiArts();
        private StreetLevel sl = new StreetLevel();
            
        public void StartGame()
        {
            string[] options = new[] { "exit the carriage", "sleep", "exit the game" };
            string prompt = $"{arts.Train}";
            menu.MainMenu(prompt, options);
            menu.Run();
            int select = menu.selectedOpt;
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
            string prt = $"{arts.Street}";
            Console.WriteLine(prt);
            sl.StartLevel();
        }
        public void Sleep()
        {
            Console.WriteLine($"{arts.Sleep}");
            Console.WriteLine("you have fall down snd sleeping. And return in start city");
        }
    }
}