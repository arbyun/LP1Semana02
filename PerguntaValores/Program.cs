using System;

namespace PerguntaValores
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Let's build a cylinder.");
            Console.WriteLine("Please, input its height:");
            
            double h = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Please, input its radius:");
            
            double radius = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        }
    }
}
