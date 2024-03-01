using LINQTut04.Shared;
using System.Linq;
namespace Projection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample3();
            Console.ReadKey();
        }

        private static void RunExample1()
        {
            List<string> word = new() { "I", "Love", "asp.net", "Core" };
            // method syntax
            var result = word.Select(x => x.ToUpper()); 
            // query syntax
            var result2=from w in word
                        select w.ToUpper();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        private static void RunExample2()
        {
            List<int> numbers= new() { 2, 3, 5 ,7 };
            // method syntax
            var result = numbers.Select(x => x*x);


            // query syntax
            /*var result2 = from w in numbers
                          select w * w;*/

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void RunExample3()
        {

            var employees = Repository.LoadEmployees();
            var result = employees.Select(x =>
            {
                return new EmployeeDTO
                {
                    Name = $"{x.FirstName} {x.LastName}",
                    TotalSkills = x.Skills.Count()
                };
            });
            List<int> numbers = new() { 2, 3, 5, 7 };
            // method syntax
           // var result = numbers.Select(x => x * x);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}