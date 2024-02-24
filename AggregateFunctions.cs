using System.Runtime.InteropServices;

namespace join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 7, 8, 2 };
            // Count => Count How many number in array
            Console.WriteLine(numbers.Count());

            // Sum => Sum numbers in array
            Console.WriteLine(numbers.Sum());

            // Max => Get maximum number in array
            Console.WriteLine(numbers.Max());

            // Min => Get minimum number in array
            Console.WriteLine(numbers.Min());

            // Count => Get Average of numbers in array
            Console.WriteLine(numbers.Average());

        }
    }

}