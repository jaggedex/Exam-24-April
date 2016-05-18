using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDesertAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyHave = decimal.Parse(Console.ReadLine());
            double guests = double.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());
            int dozensToMake = Math.Ceiling(guests / 6.00);


            int totalBananasNeeded = dozonsToMake * 2;
            int totalEggsNeeded = dozonsToMake * 4;
            decimal totalBerriesNeeded = dozonsToMake * 0.2M;

            decimal totalMoneyNeeded = dozonsToMake * (2 * bananasPrice) + dozonsToMake * (4 * eggsPrice) + dozonsToMake * (0.2M * berriesPrice);

            if (moneyHave >= totalMoneyNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalMoneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", totalMoneyNeeded - moneyHave);
            }
        }
    }
}
