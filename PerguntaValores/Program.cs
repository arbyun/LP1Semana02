using System;

namespace PerguntaValores
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Let's build a cylinder.");
            Console.WriteLine("Please, input its height:");
            
            double height = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Please, input its radius:");
            
            double radius = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            CalculateCylinder(height, radius);
        }

        private static void CalculateCylinder(double h, double r)
        {
            double volume = Math.PI * Math.Pow(r, 2) * h;
            double surfArea = 2 * Math.PI * r * (r + h);

            Console.WriteLine($"Cylinder's volume is: {volume}");
            Console.WriteLine($"Cylinder's surface area is: {surfArea}");
        }
    }
}
