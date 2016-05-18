using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GameOfNamesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int playersCount = int.Parse(Console.ReadLine());
            long maxPoints = long.MinValue;
            string winner = string.Empty;


            for (int i = 0; i < playersCount; i++)
            {
                
                string name = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());

                for (int k = 0; k < name.Length; k++)
                {
                    if (name[k] % 2 == 0)
                    {
                        points += name[k];
                    }
                    else
                    {
                        points -= name[k];
                    }
                }
                    if (points > maxPoints)
                    {
                        maxPoints = points;
                        winner = name;
                    }
                
            }
            Console.WriteLine($"The winner is {winner} - {maxPoints} points");
        }
    }
}
