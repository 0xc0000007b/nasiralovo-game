using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class Home
    {
        private Menu _menu = new Menu();
        private AsciiArts _arts = new AsciiArts();;

        public void StartLevel()
        {
            string[] opts = new[] { "Enter the house", "go to shop" };
            string prompt = $"{arts.House}";
            _menu.MainMenu(prompt, opts);
            _menu.Run();
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
            _menu.MainMenu(prompt, opts);
            _menu.Run();
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
