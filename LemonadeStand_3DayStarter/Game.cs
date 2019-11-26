using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
            List<Day> days;

            public Game()
            {
                days = new List<Day>();
                BuildDays();
            }

            public void BuildDays()
            {
                for (int i = 0; i < 7; i++)
                {
                    Day day = new Day();
                    days.Add(day);
                }
            }
            public void RunGame()
            {
                for (int i = 0; i < 7; i++)
                {
                days[i].RunDay();
                }
            }

    }
}
