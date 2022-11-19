using System;
using System.Data;
using System.Xml;

namespace Game.GameCore.Utils
{
    public class Menu
    {
        private string[] menuOpts;
        public int SelectedOpt;
        private string Prompt;

        public void MainMenu(string prompt, string[] options)
        {
            Prompt = prompt;
            menuOpts = options;
            SelectedOpt = 0;
        }

        private void DispOpts()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < menuOpts.Length; i++)
            {
                string curOpt = menuOpts[i];
                string prefix;
                if (i == SelectedOpt)
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

        

        public int Run()
        {
            ConsoleKey pressed;
            do
            {
                Console.Clear();
                DispOpts();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                pressed = keyInfo.Key;

                if (pressed == ConsoleKey.DownArrow)
                {
                    SelectedOpt++;
                    if (SelectedOpt > 2) SelectedOpt = menuOpts.Length - 1;
                }
                else if (pressed == ConsoleKey.UpArrow)
                {
                    SelectedOpt--;
                    if (SelectedOpt < 0) SelectedOpt = menuOpts.Length + 1;
                    
                }
                
            } while (pressed != ConsoleKey.Enter);
            
            return SelectedOpt;
        }

        
    }
}