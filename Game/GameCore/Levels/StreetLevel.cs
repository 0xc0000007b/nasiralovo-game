using System;
using Game.GameCore.Utils;

namespace Game.GameCore.Levels
{
    public class StreetLevel
    {
        private string Prompt;
        private string[] lvlOpts;
        private int selectedOpts;
        private AsciiArts arts = new AsciiArts();
        private Selector s = new Selector();
        public void StartLevel(string[] opts, string promt)
        {
            Prompt = promt;
            lvlOpts = opts;
            selectedOpts = 0;

        }
        
        private void DisplayLevelOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < lvlOpts.Length; i++)
            {
                string curOpt = lvlOpts[i];
                string prefix;
                if (i == selectedOpts)
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

        public int SelectMenuItem()
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
                    selectedOpts++;
                    if (selectedOpts > 2) selectedOpts = lvlOpts.Length - 1;
                }
                else if (pressed == ConsoleKey.UpArrow)
                {
                    selectedOpts--;
                    if (selectedOpts < 0) selectedOpts = lvlOpts.Length + 1;
                    
                }
                
            } while (pressed != ConsoleKey.Enter);
            return selectedOpts;
        }

        public void GotoStation()
        {
            string[] opts = new[] { "Enter the station", "go away from station" };
            string promt = $"{arts.Station}";
            StationLevel sl = new StationLevel();
             sl.StartLevel(opts, promt);
             int selectedOpt = sl.OptionSelector();
             switch (selectedOpt)
             {
                 case 0:
                     Console.Clear();
                     sl.EnterTheStation();
                     break;
                 case 1:
                     Console.Clear();
                     string[] optss = new[] { "go to city", "go to carriage" };
                     string prompt = $"{arts.Street}";
                     StartLevel(optss,prompt);
                     int sel = SelectMenuItem();
                     
                     switch (sel)
                     {
                         case 0:
                             s.SelectCasrriageMenuItem();
                             break;
                         case 1:
                             s.SelectStreetMenuItem();
                             break;
                         
                     }

                     break;
             }
             
        }
    }
}