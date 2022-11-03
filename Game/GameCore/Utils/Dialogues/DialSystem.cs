using System;
using Game.GameCore.Levels;

namespace Game.GameCore.Utils.Dialogues
{
    public class DialSystem
    {
        private Menu menu = new Menu();
        public void StartDialog()
        {
            Console.Clear();
            string prompt = "choose the question";
            string[] opts = new[] { "Hello, where am i?", "go away"};
            menu.MainMenu(prompt,opts);
            menu.Run();
            int selectQuestion = menu.selectedOpt;
            switch (selectQuestion)
            {
                case 0:
                    SwitchDialog sw = new SwitchDialog();
                    sw.SwitchTheDialog();
                    break;
                case 1:
                    StationLevel station = new StationLevel();
                    station.StartLevel();
                    break;
            }
        }
    }
}