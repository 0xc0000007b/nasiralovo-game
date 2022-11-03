using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class TrainLevel
    {
        private string[] Opts = {"exit the carriage", "back to sleep" };
        private int selectedOpt;
        private string Prompt;
        private AsciiArts arts = new AsciiArts();
            
        public void StartGame(string[] opts, string prmpt)
        {
            selectedOpt = 0;
            Opts = opts;
            Prompt = prmpt;
        }

        private void DisplayLevelOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Opts.Length; i++)
            {
                string curOpt = Opts[i];
                string prefix;
                if (i == selectedOpt)
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

        public int Select()
        {
            ConsoleKey pressed;
            do
            {
                Console.Clear();
                DisplayLevelOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                pressed = keyInfo.Key;

                if (pressed == ConsoleKey.DownArrow)
                {
                    selectedOpt++;
                    if (selectedOpt > 2) selectedOpt = Opts.Length - 1;
                }
                else if (pressed == ConsoleKey.UpArrow)
                {
                    selectedOpt--;
                    if (selectedOpt < 0) selectedOpt = Opts.Length + 1;
                    
                }
                
            } while (pressed != ConsoleKey.Enter);

            return selectedOpt;
        }
        public void ExitTheTrain()
        {
            Console.WriteLine("You have exit from the carriage.");
            string prt = @"~         ~~          __
            _T      .,,.    ~--~ ^^
                    ^^   // \                    ~
                ][O]    ^^      ,-~ ~
                /''-I_I         _II____
            __/_  /   \ ______/ ''   /'\_,__
                | II--'''' \,--:--..,_/,.-{ },
            ; '/__\,.--';|   |[] .-.| O{ _ }
            :' |  | []  -|   ''--:.;[,.'\,/
            '  |[]|,.--'' '',   ''-,.    |
            ..    ..-''    ;       ''. '
            ";
            string[] opts = new[] { "turn to station", "turn away", "return to the carriage" };
            StreetLevel sl = new StreetLevel();
            sl.StartLevel(opts,prt);
            int selectTurnSide = sl.SelectMenuItem();
            switch (selectTurnSide)
            {
                case 0:
                    Console.WriteLine("you have going to hte station");
                    sl.GotoStation();
                        
                    break;
                case 1:
                    Console.WriteLine("you are going away from the train");
                    break; 
               case 2:
                   Console.WriteLine("you have return the carriage");
                   string prompt = $"{arts.Train}";
                   Console.WriteLine("Choose option: ");
                   string[] options = new[] { "sleep", "exit the game" };
                   StartGame( options, prompt);
                   int slectOpt = Select(); 
                   switch (slectOpt)
                   {
                       case 0:
                           Console.Clear();
                           Sleep();
                           break;
                       case 1:
                           Game g = new Game();
                           g.Exit();
                           break;
                   }

                   break;
            }


        }

        public void Sleep()
        {
            Console.WriteLine($"{arts.Sleep}");
            Console.WriteLine("you have fall down snd sleeping");
        }
    }
}