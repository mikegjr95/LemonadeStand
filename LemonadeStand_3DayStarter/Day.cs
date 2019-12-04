using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public Weather weather;
        public double LemonadePrice;
        public double people;
        public double eodTotal;

        public List<Customer> CustomerList = new List<Customer>();
        Random random = new Random();

     
        
        
        
        
        
        
        public Day()
        {
            weather = new Weather();
        }


        public void RunDay() //all logic for one day to happen
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("********************Lets Sell Lemonade!********************");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("How /n much /n are /n you /n charging /n per /n cup?");
            string input = Console.ReadLine();
            if (input != null)
            {
                LemonadePrice = double.Parse(input);
            }
            else
            {
                RunDay();             
            }
            Console.WriteLine(" Okay each cup will cost ${0}.", LemonadePrice);

        }
        public void CustomerTransaction(Inventory inventory, Player player, Pitcher pitcher)
        {
            int customerWillingnessToBuy = 0;

            foreach (Customer customer in CustomerList)
            {
                if (customer.customerCash >= LemonadePrice && customer.thirst > 1)
                {
                    customerWillingnessToBuy++;
                }
            }

            if (customerWillingnessToBuy == 0)
            {
                Console.WriteLine(" Customers are no longer buying your lemonade. End Day");
            }
            else if (customerWillingnessToBuy != 0 )
            {
                if (inventory.Lemons >= 1 && inventory.SugarCubes >=1 && inventory.IceCubes >=3 && inventory.Cups >= 6 );
                {
                    inventory.UpdateInventory();
                    while (customerWillingnessToBuy >= pitcher.NumberOfCupsPerPitcher);
                    {
                        
                    }
                }
            }
        }

    }
}
