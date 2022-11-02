using System;
using System.Data;
using System.Xml;

namespace Game.GameCore.Utils
{
    public class Menu
    {
        private string[] menuOpts;
        private int selectedOpt;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            menuOpts = options;
            selectedOpt = 0;
        }

        private void DispOpts()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < menuOpts.Length; i++)
            {
                string curOpt = menuOpts[i];
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
                    selectedOpt++;
                    if (selectedOpt > 2) selectedOpt = menuOpts.Length - 1;
                }
                else if (pressed == ConsoleKey.UpArrow)
                {
                    selectedOpt--;
                    if (selectedOpt < 0) selectedOpt = menuOpts.Length + 1;
                    
                }
                
            } while (pressed != ConsoleKey.Enter);
            
            return selectedOpt;
        }

        
    }
}