using System;

namespace Triangle
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int a = int.Parse(args[0]);
            char b = char.Parse(args[1]);

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(b);
                }
                
                Console.WriteLine();
            }
        }
    }
}
