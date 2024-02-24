using System.Runtime.InteropServices;

namespace join
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Name = { "Amaal", "Retaj", "Ahmed", "Ali" };

            // First & FirstOrDefault
            Console.WriteLine(Name.First(a=>a.StartsWith('A'))); // Get the first element in array but if array is null => raise error
            Console.WriteLine(Name.FirstOrDefault());// Get the first element in array but if array is null => not raise error
            Console.WriteLine(Name.FirstOrDefault() == null);// True
            Console.WriteLine("----------------------------");

            // Last & LastOrDefault
            Console.WriteLine(Name.Last(a => a.StartsWith('A'))); // Get the last element in array but if array is null => raise error
            Console.WriteLine(Name.LastOrDefault());// Get the first element in array but if array is null => not raise error
            Console.WriteLine("----------------------------");

            // Single & SingleOrDefault
            Console.WriteLine(Name.Single());// Get the single element in array if array has one element else raise error 
            Console.WriteLine(Name.SingleOrDefault()); // Get the single element in array if array has one element but if array is null => not raise error
            Console.WriteLine("----------------------------");


            // ElementAt & ElementAtOrDefault
            Console.WriteLine(Name.ElementAt(3)); // Get the element in array using Index , if index not found => raise error
            Console.WriteLine(Name.ElementAtOrDefault(5));// Get the element in array using Index , if index not found =>  not raise error


        }
    }

}