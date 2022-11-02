using System;
using Game.GameCore.Levels;
using Game.GameCore.Utils;

namespace Game.GameCore
{
    public class Game
    {
        private string[] menuOPtions = new[] { "Play", "Credits", "Exit" };
        private int selInd = 0;

        public void Start()
        {
            Console.Title = "Test Console Game";
                
            MainMenu();
           
        }

        private void MainMenu()
        {
            string prompt = @"
 _____         _                                
|_   _|       | |                               
  | | ___  ___| |_    __ _  __ _ _ __ ___   ___ 
  | |/ _ \/ __| __|  / _` |/ _` | '_ ` _ \ / _ \
  | |  __/\__ \ |_  | (_| | (_| | | | | | |  __/
  \_/\___||___/\__|  \__, |\__,_|_| |_| |_|\___|
                      __/ |                     
                     |___/
            Welcome to my game";
            string[] options = new[] { "Play", "Credit", "Exit" };
            Menu m = new Menu(prompt, options);
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
            Console.WriteLine("\nPress Any key To Exit");
            Console.ReadKey(true);
            Environment.Exit(0);
        }
        private void Credits()
        {
            Console.Clear();
            Console.WriteLine("Test game in console by the 0xc000007b");
            Console.WriteLine("https://t.me/0xc000007b");
            MainMenu();
            Console.ReadKey(true);
        }
        private void FirstChoice()
        {
            Console.WriteLine("you have waked up in the Carriage");
            string[] opts = new[] { "exit the carriage", "back to sleep" };
            string prmpt = @"____________.._____________,,_______-----__ I  
   //[]|| [][]#######    Amtrak   ###    800__I I  `~~~``~~~``~~~``~~~``~~~
  /  ==||===================================||I I            ,---,,---, I~I
 _|____--_____          ,         ___###I###||I_I_______     `~~~``~~~` I I
 ~/-'()===() `-------------------'--()===()~`-'~`-'O===O`---------------'-'";
            
            TrainLevel tl = new TrainLevel();
            tl.StartGame(opts, prmpt);
            int selectStep = tl.Select();
            switch (selectStep)
            {
                case 0:
                    Console.Clear();
                    tl.ExitTheTrain();
                    break;
            }
        }
        
    }
}