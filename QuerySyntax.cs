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
            //  simple Query Syntax
            var Result = from item in Names
                         select item;

            // add constrain
            Result = from item in Names
                     where item.StartsWith('P')
                     select item;

            // add  more than one Constrain
            Result = from item in Names
                     where item.StartsWith('P') && item.Length==3
                     select item;

            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }
    }
}