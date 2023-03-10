using System;

namespace PerguntaValores
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Let's build a cylinder.");
            Console.WriteLine("Please, input it's height:");
            
            double h = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            
        }
    }
}
