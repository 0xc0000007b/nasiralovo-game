using System;

namespace Game.GameCore.Levels
{
    public class StreetLevel
    {
        private string Prompt;
        private string[] lvlOpts;
        private int selectedOpts;

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
            string promt = @"    .-.
                                 /___\
                                 |___|
                                 |]_[|
                                 / I \
                              JL/  |  \JL
   .-.                    i   ()   |   ()   i                    .-.
   |_|     .^.           /_\  LJ=======LJ  /_\           .^.     |_|
._/___\._./___\_._._._._.L_J_/.-.     .-.\_L_J._._._._._/___\._./___\._._._
       ., |-,-| .,       L_J  |_| [I] |_|  L_J       ., |-,-| .,        ., 
       JL |-O-| JL       L_J%%%%%%%%%%%%%%%L_J       JL |-O-| JL        JL 
IIIIII_HH_'-'-'_HH_IIIIII|_|=======H=======|_|IIIIII_HH_'-'-'_HH_IIIIII_HH_
-------[]-------[]-------[_]----\.=I=./----[_]-------[]-------[]--------[]-
 _/\_  ||\\_I_//||  _/\_ [_] []_/_L_J_\_[] [_] _/\_  ||\\_I_//||  _/\_  ||\
 |__|  ||=/_|_\=||  |__|_|_|   _L_L_J_J_   |_|_|__|  ||=/_|_\=||  |__|  ||-
 |__|  |||__|__|||  |__[___]__--__===__--__[___]__|  |||__|__|||  |__|  |||
IIIIIII[_]IIIII[_]IIIIIL___J__II__|_|__II__L___JIIIII[_]IIIII[_]IIIIIIII[_]
 \_I_/ [_]\_I_/[_] \_I_[_]\II/[]\_\I/_/[]\II/[_]\_I_/ [_]\_I_/[_] \_I_/ [_]
./   \.L_J/   \L_J./   L_JI  I[]/     \[]I  IL_J    \.L_J/   \L_J./   \.L_J
|     |L_J|   |L_J|    L_J|  |[]|     |[]|  |L_J     |L_J|   |L_J|     |L_J
|_____JL_JL___JL_JL____|-||  |[]|     |[]|  ||-|_____JL_JL___JL_JL_____JL_J";
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
                     string prompt = @"~         ~~          __
            _T      .,,.    ~--~ ^^
                    ^^   // \                    ~
                ][O]    ^^      ,-~ ~
                /''-I_I         _II____
            __/_  /   \ ______/ ''   /'\_,__
                | II--'''' \,--:--..,_/,.-{ },
            ; '/__\,.--';|   |[] .-.| O{ _ }
            :' |  | []  -|   ''--:.;[,.'\,/
            '  |[]|,.--'' '',   ''-,.    |
            ..    ..-''    ;       ''. '";
                     StartLevel(optss,prompt);
                     int sel = SelectMenuItem();
                     
                     switch (sel)
                     {
                         case 0:
                             break;
                         case 1:
                             string[] ops = new[] { "sleep", "exit" };
                             string prt = @"____________.._____________,,_______-----__ I  
   //[]|| [][]#######    Amtrak   ###    800__I I  `~~~``~~~``~~~``~~~``~~~
  /  ==||===================================||I I            ,---,,---, I~I
 _|____--_____          ,         ___###I###||I_I_______     `~~~``~~~` I I
 ~/-'()===() `-------------------'--()===()~`-'~`-'O===O`---------------'-'";
                             TrainLevel tl = new TrainLevel();
                             tl.StartGame(ops, prt);
                             Console.WriteLine("you are returned the Carriage.");
                             int s = tl.Select();
                             switch (s)
                             {
                                 case 0: 
                                     Console.Clear();
                                     tl.Sleep();
                                     break;
                                 case 1:
                                     Game g = new Game();
                                     g.Exit();
                                     break;
                             }
                             break;
                         
                     }

                     break;
             }
        }
    }
}