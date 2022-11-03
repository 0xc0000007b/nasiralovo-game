using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class Home
    {
        private Menu menu = new Menu();
        private AsciiArts arts = new AsciiArts();

        public void StartLevel()
        {
            string[] opts = new[] { "Enter the house", "go to shop" };
            string prompt = $"{arts.House}";
            menu.MainMenu(prompt, opts);
            menu.Run();
            int selectedOpt = menu.selectedOpt;
            switch (selectedOpt)
            {
                case 0:
                    EnterTheHouse();
                    break;
            }
        }
        private void EnterTheHouse()
        {
            string prompt = "Thanks for playing";
            string[] opts = new[] { "Main menu", "exit" };
            menu.MainMenu(prompt, opts);
            menu.Run();
            int selectItem = menu.selectedOpt;
            switch (selectItem)
            {
                case 0:
                    Game g = new Game();
                    g.Start();
                    break;
                case 1:
                    Game game = new Game();
                    game.Exit();
                    break;
            }
        }
    }
}