using System.ComponentModel.DataAnnotations;

namespace LinQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>()
            {
                "Red","Book","Computer","Mobile","Program",
                "Driver","Window","Key","Home"
            };
            // Query Syntax
            var Result = from item in Names where item.Length>3 select item;
            
            foreach(var s in Result)
            {
                Console.WriteLine(s);
            }

            // Non-Query Syntax
            var result = Names.Where(item => item.Length > 3);

            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
