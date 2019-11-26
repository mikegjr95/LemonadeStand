using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        public int ForecastTempurature;
        public int ActualTemp;
        public string Condition;
        public List<string> PossibleConditions;


        public Weather()
        {
            PossibleConditions = new List<string> { "Sunny", "Cloudy", "Rainy" };
            GenerateCondition();
            GenerateTemp();
            ActualTempurature();

        }
        void GenerateTemp()
        {
            Random rng = new Random();
            ForecastTempurature = rng.Next(30, 95);
        }
        void GenerateCondition()
        {
            Random rng = new Random();
            int indexValue = rng.Next(0, PossibleConditions.Count);
            Condition = PossibleConditions[indexValue];
        }
        void ActualTempurature()
        {
            Random rng = new Random();
            ActualTemp = ForecastTempurature + rng.Next(0, 6);
        }
    }
}
