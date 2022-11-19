using System;
using Game.GameCore.Levels;

namespace Game.GameCore.Utils.Dialogues
{
    public class DialSystem
    {
        private Menu _menu = new Menu();
        public void StartDialog()
        {
            Console.Clear();
            string prompt = "choose the question";
            string[] opts = new[] { "Hello, where am i?", "go away"};
            _menu.MainMenu(prompt,opts);
            _menu.Run();
            int selectQuestion = _menu.SelectedOpt;
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