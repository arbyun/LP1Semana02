using System;

namespace Specials
{
    static class Program
    {
        private static void Main(string[] args)
        {
            double db = double.MaxValue;
            float ft = float.MaxValue;
            int i = int.MaxValue;
            sbyte sb = sbyte.MaxValue;
            short shortish = short.MaxValue;
            long longish = long.MaxValue;
            ushort shorter = ushort.MaxValue;
            byte bt = byte.MaxValue;
            ulong longer = ulong.MaxValue;
            uint ui = uint.MaxValue;
            
            double sdb = double.MinValue;
            float sft = float.MinValue;
            int si = int.MinValue;
            sbyte ssb = sbyte.MinValue;
            short sshortish = short.MinValue;
            long slongish = long.MinValue;
            ushort sshorter = ushort.MinValue;
            byte sbt = byte.MinValue;
            ulong slonger = ulong.MinValue;
            uint sui = uint.MinValue;
            
            Console.WriteLine("Max Values:");
            Console.WriteLine($"Double: {db}");
            Console.WriteLine($"Float: {ft}");
            Console.WriteLine($"Int: {i}");
            Console.WriteLine($"Sbyte: {sb}");
            Console.WriteLine($"Short: {shortish}");
            Console.WriteLine($"Long: {longish}");
            Console.WriteLine($"Ushort: {shorter}");
            Console.WriteLine($"Byte: {bt}");
            Console.WriteLine($"Ulong: {longer}");
            Console.WriteLine($"Uint: {ui}");

            Console.WriteLine("Min Values:");
            Console.WriteLine($"Double: {sdb}");
            Console.WriteLine($"Float: {sft}");
            Console.WriteLine($"Int: {si}");
            Console.WriteLine($"Sbyte: {ssb}");
            Console.WriteLine($"Short: {sshortish}");
            Console.WriteLine($"Long: {slongish}");
            Console.WriteLine($"Ushort: {sshorter}");
            Console.WriteLine($"Byte: {sbt}");
            Console.WriteLine($"Ulong: {slonger}");
            Console.WriteLine($"Uint: {sui}");

            const double d1 = double.NegativeInfinity;
            const double d2 = double.PositiveInfinity;
            const double d3 = double.NaN;

            const float f1 = float.NegativeInfinity;
            const float f2 = float.PositiveInfinity;
            const float f3 = float.NaN;
            
            Console.WriteLine("Double:");
            Console.WriteLine(d1);
            Console.WriteLine(d2);  
            Console.WriteLine(d3);   

            Console.WriteLine("Float:");
            Console.WriteLine(f1);   
            Console.WriteLine(f2);   
            Console.WriteLine(f3);

            int overi = i + 1;
            uint overui = ui + 1;
            
            Console.WriteLine($"Value of int after overflow: {overi}");
            Console.WriteLine($"Value of uint after overflow: {overui}");

            float overft = 2 * ft;
            double overdb = 2 * db;
            
            Console.WriteLine($"Value of float after overflow: {overft}");
            Console.WriteLine($"Value of double after overflow: {overdb}");

            float fin, fit;
            double din, dit;
            
            fin = fit = 10000000000.000003f;
            Console.WriteLine($"Value of float after underflow: {fin == fit + 0.00000000000001}");
            
            din = dit = 10000000000.000003f;
            Console.WriteLine($"Value of double after underflow: {din == dit + 0.00000000000001}");
            
            
        }
    }
}
