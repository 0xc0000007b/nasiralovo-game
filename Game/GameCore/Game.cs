using System;
using System.Runtime.CompilerServices;
using Game.GameCore.Levels;
using Game.GameCore.Utils;

namespace Game.GameCore
{
    public class Game
    {
        private string[] menuOPtions = new[] { "Play", "Credits", "Exit" };
        private AsciiArts arts = new AsciiArts();
        private Menu m = new Menu();
        private TrainLevel tl = new TrainLevel();
        
        public void Start()
        {
            Console.Title = $"{arts.GameTitle}";
            MainMenu();
        }

        private void MainMenu()
        {
            string prompt = $"{arts.GameTitle}";
            string[] options = new[] { "Play", "Credit", "Exit" };
            m.MainMenu(prompt, options);
            int selectedOpt = m.Run();


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
            m.MainMenu(credits, opts);
            m.Run();
            int seloOpt = m.selectedOpt;
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
            string prmpt = $"{arts.Train}";
            m.MainMenu( prmpt, opts);
            int selectStep = m.selectedOpt;
            switch (selectStep)
            {
                case 0:
                    Console.Clear();
                    tl.StartGame();
                    break;
            }
        }
        
    }
}