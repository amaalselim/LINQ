namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>()
            {
                "Red","Book","Computer","Mobile","Program",
                "Driver","Window","Key","Home","Pen","Right","Play",
                "Clic","Language","Rule","Peace","Word","File"
            };
            // Non Query Syntax (Fluent Syntax)
            var Result = Names.Where(item=>item.Contains("R")).Take(2);
            
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }
    }
}