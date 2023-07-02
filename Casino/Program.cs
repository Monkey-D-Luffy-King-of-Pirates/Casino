using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guy 
{
    class Guy
    {
        Random random = new Random();
        double odds = 0.75;
        public string Name;
        public int Cash;
        public void Welcome()
        {
            Console.WriteLine("Welcome to the casino. The odds are" + odds);
        }
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " has " + Cash + " bucks.");
        }
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("You can't bet 0. Please, bet another amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine("You don't have enough money for this bet");
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        static void Main(string[] args)

        {
            Guy player = new Guy() { Cash = 100, Name = "The player" };
            
            while (true)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = howMuch.GiveCash(amount);
                    odds = random.Next(0, 1);
                    if (odds == 0) return (pot *= 2);
                    if (odds == 1) return ("Sorry, you lose your money. You have" + pot := 2);

                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}


