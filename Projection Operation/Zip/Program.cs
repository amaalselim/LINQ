using LINQTut04.Shared;

namespace Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunExample01();
            RunExample02();

            Console.ReadKey();
        }

        private static void RunExample01()
        {
            string[] colorName = { "Red", "Green", "Blue" };
            string[] ColorHEX = { "FF0000", "00FF00", "0000FF" };

            var colors = colorName.Zip(ColorHEX, (name, hex) => $"{name} {hex}");

            foreach (var c in colors)
            {
                Console.WriteLine(c);
            }
        }
        private static void RunExample02()
        {

            var employees=Repository.LoadEmployees().ToArray();
            var firstThreeEmp = employees[..3];
            var LastThreeEmp = employees[^3..];

            var teams = firstThreeEmp.Zip(LastThreeEmp,
                (first, last) =>$"{first.FullName} with {last.FullName}");

            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }
        }
    }
}