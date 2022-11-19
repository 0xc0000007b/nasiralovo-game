using Game.GameCore.Levels;

namespace Game.GameCore.Utils.Dialogues
{
    public class SwitchDialog
    {
        private Menu _menu = new Menu();
        public void SwitchTheDialog()
        {
            string[] questionsAndAnswers = new[] { "hello, you are in Perm", 
                                                    "what are you name?", 
                                                    "Whats the time?", 
                                                    "whats are i am doing in these city?",
                                                    "my name is Alexander",
                                                    "you are come in tran to home",
                                                    "10:23AM",
                                                    "thank you"
            };
            string promt = $"{questionsAndAnswers[0]}";
            string[] options = new[] { $"{questionsAndAnswers[1]}",
                                        $"{questionsAndAnswers[2]}", 
                                        $"{questionsAndAnswers[3]}",
                                        "go away"
            };
            _menu.MainMenu(promt, options);
            _menu.Run();
            int selectItem = _menu.SelectedOpt;
            switch (selectItem)
            {
                case 0:
                    string promtt = $"{questionsAndAnswers[4]}";
                    string[] optionst = new[] {
                        "Hi, Alexander. nice to meet you"};
                    _menu.MainMenu(promtt, optionst);
                    _menu.Run();
                    int selectAns = _menu.SelectedOpt;
                    switch (selectAns)
                    {
                        case 0:
                            SwitchTheDialog();
                            break;
                    }
                    break;
                case 1:
                    string prt = $"{questionsAndAnswers[6]}";
                    string[] optins = { $"{questionsAndAnswers[7]}" };
                    _menu.MainMenu(prt, optins);
                    _menu.Run();
                    int select = _menu.SelectedOpt;
                    switch (select)
                    {
                        case 0: 
                            SwitchTheDialog();
                            break;
                    }
                    break;
                case 2:
                    string prom = $"{questionsAndAnswers[5]}";
                    string[] ops = new[] { $"{questionsAndAnswers[7]}" };
                    _menu.MainMenu(prom, ops);
                    _menu.Run();
                    int selectD = _menu.SelectedOpt;
                    switch (selectD)
                    {
                        case 0: 
                            SwitchTheDialog();
                            break;
                    }
                    break;
                case 3:
                    DialSystem dial = new DialSystem();
                    dial.StartDialog();
                    break;
            }
        }
    }
}