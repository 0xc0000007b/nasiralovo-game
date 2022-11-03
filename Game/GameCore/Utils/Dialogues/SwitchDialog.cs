using Game.GameCore.Levels;

namespace Game.GameCore.Utils.Dialogues
{
    public class SwitchDialog
    {
        private Menu menu = new Menu();
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
            menu.MainMenu(promt, options);
            menu.Run();
            int selectItem = menu.selectedOpt;
            switch (selectItem)
            {
                case 0:
                    string promtt = $"{questionsAndAnswers[4]}";
                    string[] optionst = new[] {
                        "Hi, Alexander. nice to meet you"};
                    menu.MainMenu(promtt, optionst);
                    menu.Run();
                    int selectAns = menu.selectedOpt;
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
                    menu.MainMenu(prt, optins);
                    menu.Run();
                    int select = menu.selectedOpt;
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
                    menu.MainMenu(prom, ops);
                    menu.Run();
                    int selectD = menu.selectedOpt;
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