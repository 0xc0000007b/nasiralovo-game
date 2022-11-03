using System;
using Game.GameCore.Levels;

namespace Game.GameCore.Utils
{
    public class Selector
    {
        private AsciiArts arts = new AsciiArts();
        public void SelectCasrriageMenuItem()
        {
            string[] optis = new[] { "go to shop", "go to Carriage" };
            string pront = $"{arts.City}";
            CityLevel cl = new CityLevel();
            cl.StartLevel( optis, pront);
            int select =cl.SelectMenuItem();
            switch (select)
            {
                case 0:
                    Console.WriteLine("you have entered the shop");
                    break;
                case 1:
                    Console.WriteLine("you have returned the carriage");
                    string[] opss = new[] { "sleep", "exit" };
                    string prs = $"{arts.Train}";
                    TrainLevel tlvl = new TrainLevel();
                    tlvl.StartGame(opss, prs);
                    int selit = tlvl.Select();
                    switch (selit)
                    {
                        case 0:
                            tlvl.Sleep();
                            break;
                        case 1:
                            Game g = new Game();
                            g.Exit();
                            break;
                    }
                    break;
            }

        }
            public void SelectStreetMenuItem()
            {
                string[] ops = new[] { "sleep", "exit" };
                string prt = $"{arts.Train}";
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
            }
    }
}