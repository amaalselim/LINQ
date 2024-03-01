using ConsoleApp2;
using LINQTut06.Shared;

namespace Take
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps=Repository.LoadEmployees();
            // take
            var q1 = emps.Take(10);
            q1.Print("Skip First 10 employees");

            // take while
            var q2 = emps.TakeWhile(x => x.Salary != 214400);
            q2.Print("skip while salary does not equal 214,400");

            // take last
            var q3 = emps.TakeLast(10);
            q3.Print("skip last 10 elements");

            Console.ReadKey();
        }
    }
}