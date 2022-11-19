using System;
using System.Runtime.CompilerServices;
using Game.GameCore.Levels;
using Game.GameCore.Utils;

namespace Game.GameCore
{
    public class Game
    {
        private string[] m_enuOPtions = new[] { "Play", "Credits", "Exit" };
        private AsciiArts _arts = new AsciiArts();
        private Menu _menu = new Menu();
        private TrainLevel _trainLevel = new TrainLevel();
        
        public void Start()
        {
            Console.Title = $"{_arts.GameTitle}";
            MainMenu();
        }

        private void MainMenu()
        {
            string prompt = $"{_arts.GameTitle}";
            string[] options = new[] { "Play", "Credit", "Exit" };
            _menu.MainMenu(prompt, options);
            int selectedOpt = _menu.Run();


            switch (selectedOpt)
            {
                case 0:
                    Console.Clear();
                    FirstChoice();
                    break;
                case 1:
                    Credits();
                    break;
                case 2:
                    Exit();
                    break;
            }
        }

        public void Exit()
        {
            Console.WriteLine("Thanks for playing");
            Console.WriteLine("\nPress Any key To Exit");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
        private void Credits()
        {
            Console.Clear();
            
            string credits = "this game made by 0xc000007b" + "\n" + "https://t.me/NullRefExcept";
            string[] opts = new[] { "Main menu", "exit" };
            _menu.MainMenu(credits, opts);
            _menu.Run();
            int seloOpt = _menu.SelectedOpt;
            switch (seloOpt)
            {
                case 0: 
                    MainMenu();
                    break;
                case 1:
                    Exit();
                    break;
            }
        }
        private void FirstChoice()
        {
            Console.WriteLine("you have waked up in the Carriage");
            string[] opts = new[] { "exit the carriage", "back to sleep" };
            string prmpt = $"{_arts.Train}";
            _menu.MainMenu( prmpt, opts);
            int selectStep = _menu.SelectedOpt;
            switch (selectStep)
            {
                case 0:
                    Console.Clear();
                    _trainLevel.StartGame();
                    break;
            }
        }
        
    }
}