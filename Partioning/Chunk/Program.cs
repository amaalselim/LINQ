using LINQTut06.Shared;

namespace Chunk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps=Repository.LoadEmployees();
            var chunks=emps.Chunk(10).ToList();
            for (int i = 0; i < chunks.Count; i++)
            {
                chunks[i].Print($"chunks #{i + 1}");
            }
        }
    }
}