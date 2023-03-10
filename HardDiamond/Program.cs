using System;

namespace HardDiamond
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int userInput = int.Parse(args[0]);
            if (userInput == null) return;
            bool isEven = userInput % 2 == 0;

            if (isEven)
            {
                Console.WriteLine("I only want odd numbers!");
            }
            else
            {
                PrintDiamond(userInput);
            }
        }

        private static void PrintDiamond(int n) 
        { 
            int spaces = n - 1;
            int dots = 1;
  
            for (int i = 0; i < n; i++) 
            { 
                for (int j = 0; j < spaces; j++) 
                {
                    Console.Write(" "); 
                }
  
                for (int j = 0; j <= dots; j++) 
                {
                    Console.Write("."); 
                }
                
                Console.WriteLine();
                spaces--;
                dots += 2;
            } 
  
            spaces = 1;
            dots = 2 * n - 3;
  
            for (int i = n - 1; i > 0; i--) 
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
  
                // Print i stars 
                for (int j = 0; j < dots; j++)
                {
                    Console.Write(".");
                }
  
                Console.WriteLine();
                spaces++;
                dots -= 2;
            } 
        } 
    }
}
