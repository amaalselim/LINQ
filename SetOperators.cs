using System.Runtime.InteropServices;

namespace join
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] group1 = { "Amaal", "Retaj", "Ahmed", "Ali" };
            string[] group2 = { "Khaled", "Hossam", "Amaal", "Retaj" };

            // Concat => make element in one array
            var ConCatgroup = group1.Concat(group2);

            // Distinct=>Remove Duplicate elements
            var Distinctgroup = group1.Concat(group2).Distinct();

            // Union => make element in one array && Remove Duplicate elements
            var Uniongroup = group1.Union(group2);

            // Intersect=> get the Duplicate elements
            var Intersectgroup = group1.Intersect(group2);

            // Except => only get the items that are in the first array
            var Exceptgroup = group1.Except(group2);



            foreach (var name in ConCatgroup)
            {
                Console.WriteLine($"Name = {name}");
            }
            Console.WriteLine("-------------------------------------------------");
            foreach (var name in Distinctgroup)
            {
                Console.WriteLine($"Name = {name}");
            }
            Console.WriteLine("-------------------------------------------------");

            foreach (var name in Uniongroup)
            {
                Console.WriteLine($"Name = {name}");
            }
            Console.WriteLine("-------------------------------------------------");

            foreach (var name in Intersectgroup)
            {
                Console.WriteLine($"Name = {name}");
            }
            Console.WriteLine("-------------------------------------------------");

            foreach (var name in Exceptgroup)
            {
                Console.WriteLine($"Name = {name}");
            }

        }
    }

}