using System.Net.Sockets;

namespace test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Enter your Name: ");
            // string? name = Console.ReadLine();

            // Console.WriteLine($"Hello, {name}");
            bool enabled = false;
            Console.WriteLine($"bool: {enabled}");
            enabled = true;
            Console.WriteLine($"bool: {enabled}");

            char a = 'A';
            Console.WriteLine($"char: {a}");

            int q = 5;
            int r = 6;
            int s = -4;

            Console.WriteLine($"q: {q}, r: {r}, s: {s}");

            int multiply = s * r;
            int divide = r / s;
            int add = q + r;
            int sub = r - s;
            Console.WriteLine($"multiply: {multiply}, divide: {divide}, add: {add}, subtract: {sub}");

            long n = 10203933874;
            Console.WriteLine($"long: {n}");

            float z = 3.5f;
            double x = 7.8d;
            decimal dec = 7.15m;
            Console.WriteLine($"float: {z}, double: {x}, decimal: {dec}");
        }
    }
}
// value types
