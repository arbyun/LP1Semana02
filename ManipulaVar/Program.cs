using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);

            x++;
            Console.WriteLine($"Current value of x: {x}");

            --x;
            Console.WriteLine($"Current value of x: {x}");

        }
    }
}
