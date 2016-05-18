using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SweetDesert
{
    static void Main()
    {
        checked
        {
            decimal moneyHave = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal bananasPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());


            int dozonsToMake = 0;
            if (guests == 0)
            {
                dozonsToMake = 0;
            }
            else if (guests <= 6 )
            {
                dozonsToMake = 1;
            }
            else if (guests % 6 != 0 && guests > 6 )
            {
                dozonsToMake = guests / 6 + 1 ;
            }
            else if (guests % 6 == 0 )
            {
                dozonsToMake = guests / 6;
            }
            
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

