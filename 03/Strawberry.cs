using System;
using System.Collections.Generic;
using System.Linq;

class Strawberry
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 2 * n + 3;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', i*2), new string('-', (width - i*4 - 3)/2));
        }
        for (int i = 0; i < n/2+1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('-',(width - (4*i+1)- 2)/2 ), new string('.', 4*i+1));
        }
        for (int i = 0; i < n+1; i++)
        {
            Console.WriteLine("{0}#{1}#{0}" , new string('-', i), new string('.', width - 2*i - 2));
        }
    }
}

