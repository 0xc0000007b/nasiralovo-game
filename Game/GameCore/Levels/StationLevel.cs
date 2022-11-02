using System;


namespace Game.GameCore.Levels
{
    public class StationLevel
    {
        private string Prompt;
        private string[] Opts;
        private int selctedOpt;

        public void StartLevel(string[] opts, string prompt)
        {
            Prompt = prompt;
            Opts = opts;
            selctedOpt = 0;
        }

        private void DisplayChoise()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Opts.Length; i++)
            {
                string curOpt = Opts[i];
                string prefix;
                if (i == selctedOpt)
                {
                    prefix = "▷";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ResetColor();
                }

                Console.WriteLine($"{prefix} >> {curOpt}");
            }

            Console.ResetColor();
        }

        public int OptionSelector()
        {
            Console.Clear();
            ConsoleKey pressed;
            do
            {
                DisplayChoise();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                pressed = keyInfo.Key;

                if (pressed == ConsoleKey.DownArrow)
                {
                    selctedOpt++;
                    if (selctedOpt > 2) selctedOpt = Opts.Length - 1;
                }
                else if (pressed == ConsoleKey.UpArrow)
                {
                    selctedOpt--;
                    if (selctedOpt < 0) selctedOpt = Opts.Length + 1;

                }

            } while (pressed != ConsoleKey.Enter);

            return selctedOpt;
        }

        private static string[] choose = new[] { "go to men and ask the question", "go away" };

        public void EnterTheStation()
        {



            Console.WriteLine(@"////\\\\
                              |      |
                             @  O  O  @
                              |  ~   |         \__
                               \ -- /          |\ |
                             ___|  |___        | \|
                            /          \      /|__|
                           /            \    / /
                          /  /| .  . |\  \  / /
                         /  / |      | \  \/ /
                        <  <  |      |  \   /
                         \  \ |  .   |   \_/
                          \  \|______|
                            \_|______|
                              |      |
                              |  |   |
                              |  |   |
                              |__|___|
                              |  |  |
                              (  (  |
                              |  |  |
                              |  |  |
                             _|  |  |
                         cccC_Cccc___)");


            Console.WriteLine("you have enter the station and seeing the men");
            Console.WriteLine("what are you wanna doing?");



            for (int g = 0; g < choose.Length; g++)
            {
                string curOpt = choose[g];
                string prefix;
                if (g == selctedOpt)
                {
                    prefix = "▷";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ResetColor();
                }

                Console.WriteLine($"{prefix} >> {curOpt}");
            }

            Console.ResetColor();

        }

        public int SelectItem()
        {
            ConsoleKey pressed;
            do
            {
                Console.Clear();
                EnterTheStation();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                pressed = keyInfo.Key;

                if (pressed == ConsoleKey.DownArrow)
                {
                    selctedOpt++;
                    if (selctedOpt > 1) selctedOpt = choose.Length + 1;
                }
                else if (pressed == ConsoleKey.UpArrow)
                {
                    selctedOpt--;
                    if (selctedOpt < 0) selctedOpt = choose.Length + 1;

                }

            } while (pressed != ConsoleKey.Enter);

            return selctedOpt;
        }

        public void GoOut()
        {
            
        }
    }
}


