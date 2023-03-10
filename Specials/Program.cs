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

        }
    }
}
