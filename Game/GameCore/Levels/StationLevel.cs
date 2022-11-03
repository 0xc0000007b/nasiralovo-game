using System;
using Game.GameCore.Utils;


namespace Game.GameCore.Levels
{
    public class StationLevel
    {
        
        private AsciiArts arts = new AsciiArts();
        private Menu menu = new Menu();
       
           

        public void StartLevel()
        {
            
            string prompt = $"{arts.Station}";
            string[] opts = new[] { "enter the station", "go away" };
            menu.MainMenu(prompt,opts);
            menu.Run();
            int selOpt = menu.selectedOpt;
            switch (selOpt)
            {
                case 0:
                    Console.Clear();
                    EnterTheStation();
                    break;
                case 1:
                    Console.Clear();
                    StreetLevel street = new StreetLevel();
                    street.StartLevel();
                    break;
                
            }



        }

        
        

        public void EnterTheStation()
        {

            string[] options = new[] { "ask question", "go away" };
                
            string promt = $"{arts.Men}";


            Console.WriteLine("you have enter the station and seeing the men");
            menu.MainMenu(promt, options);
            
            Console.WriteLine("what are you wanna doing?");
            menu.Run();


        }

       

        
    }
}


