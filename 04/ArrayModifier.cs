using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04
{
    class ArrayModifier
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            string line = Console.ReadLine();
            List<long> result = new List<long>();
            while (line != "end")
            {


                var commands = line.Split();
                if (commands[0] == "decrease")
                {

                    for (int i = 0; i < numbers.Count; i++)
                    {

                        result.Add(--numbers[i]);
                    }
                    Console.WriteLine(string.Join(", ", result));

                    numbers.Clear();
                    numbers.AddRange(result);
                    result.Clear();
                }
                else if (commands[0] == "swap")
                {


                    string action = commands[0];
                    int firstIndex = int.Parse(commands[1]);
                    int secondIndex = int.Parse(commands[2]);


                    long firstSwap = numbers[firstIndex];
                    long secondSwap = numbers[secondIndex];
                    result.AddRange(numbers);
                    result.RemoveAt(firstIndex);
                    result.Insert(firstIndex, secondSwap);
                    result.RemoveAt(secondIndex);
                    result.Insert(secondIndex, firstSwap);
                    Console.WriteLine(string.Join(", ", result));

                    numbers.Clear();
                    numbers.AddRange(result);
                    result.Clear();

                }
                else /* (action == "multiply")*/
                {
                    var bigIntList = new List<BigInteger>();

                    int firstIndex = int.Parse(commands[1]);
                    int secondIndex = int.Parse(commands[2]);

                    BigInteger bigBig = new BigInteger();
                    result.AddRange(numbers);
                    bigBig = result[firstIndex] * result[secondIndex];
                    

                    
                    for (int i = 0; i < firstIndex; i++)
                    {
                        Console.Write("{0}, ", result[i]);


                    }
                    Console.Write("{0}, ", bigBig);
                    for (int i = firstIndex + 1; i < result.Count; i++)
                    {
                        if (i != result.Count - 1)
                        {
                            Console.Write("{0}, ", result[i]);
                        }
                        else
                        {
                            Console.WriteLine("{0}", result[i]);
                        }

                    }
                    numbers.Clear();
                    numbers.AddRange(result);
                    result.Clear();
                }
               
                line = Console.ReadLine();
            }
            
        }
    }
}

