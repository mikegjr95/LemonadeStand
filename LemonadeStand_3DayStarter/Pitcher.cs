using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher
    {
        public int NumberOfCupsPerPitcher = 25;
        public int NumberOfCupsLeft;
        public Pitcher()
        {

        }

        public void MakePitcher(Recipe recipe, Inventory inventory)
        {
            if(CanMakePitcher(recipe, inventory))
            {
                inventory.Lemons.RemoveRange(0, recipe.NumberOfLemons);
                inventory.IceCubes.RemoveRange(0, recipe.NumberOfIceCubes);
                inventory.SugarCubes.RemoveRange(0, recipe.NumberOfSugarCubes);
                inventory.Cups.RemoveRange(0, NumberOfCupsPerPitcher);
                NumberOfCupsLeft = NumberOfCupsPerPitcher;
            }
            else
            {
                Console.WriteLine("You dont have enough ingredients!");
            }
        }

        public bool CanMakePitcher(Recipe recipe, Inventory inventory)
        {
            if(inventory.Lemons.Count >= recipe.NumberOfLemons &&
               inventory.SugarCubes.Count >= recipe.NumberOfSugarCubes &&
               inventory.IceCubes.Count >= recipe.NumberOfIceCubes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
