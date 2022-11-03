using System;

namespace Game.GameCore.Levels
{
    public class CityLevel
    {
        private string[] lvlOpts;
        private string Prompt;
        private int selectedOpt;

        public void StartLevel(string[] options, string prompt)
        {
            lvlOpts = options;
            Prompt = prompt;
            selectedOpt = 0;
        }
        
                private void DisplayLevelOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < lvlOpts.Length; i++)
            {
                string curOpt = lvlOpts[i];
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
                    selectedOpt++;
                    if (selectedOpt > 1) selectedOpt = lvlOpts.Length - 1;
                }
                else if (pressed == ConsoleKey.UpArrow)
                {
                    selectedOpt--;
                    if (selectedOpt < 0) selectedOpt = lvlOpts.Length + 1;
                    
                }
                
            } while (pressed != ConsoleKey.Enter);
            return selectedOpt;
        }
        
        

        
    }
}