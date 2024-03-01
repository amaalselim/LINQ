
using LINQTut06.Shared;

namespace ConsoleApp2
{
    internal class Skip
    {
        static void Main(string[] args)
        {
            var emps=Repository.LoadEmployees();

            // skip 
            var q1 = emps.Skip(10);
            q1.Print("Skip First 10 employees");

            // skip while
            var q2= emps.SkipWhile(x=>x.Salary!=214400);
            q2.Print("skip while salary does not equal 214,400");

            // skip last
            var q3 = emps.SkipLast(10);
            q3.Print("skip last 10 elements");

            Console.ReadKey();
        }
    }
}