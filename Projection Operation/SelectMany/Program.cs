
using LINQTut04.Shared;

namespace SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample02();
            Console.ReadKey();
        }

        private static void RunExample01()
        {
            string[] sentences ={
                "I Love asp.net Core",
                "I like sql server also",
                "in general I love programming Language"
            };

            var result = sentences.SelectMany(x => x.Split(' '));

            foreach (var n in result)
            {
                Console.WriteLine(n);
            }
        }

        private static void RunExample02()
        {

            var employees = Repository.LoadEmployees();

            // method syntax
            var skills = employees.SelectMany(x => x.Skills).Distinct();


            // query syntax
            var result01 = (from employee in employees
                           from skill in employee.Skills
                           select skill).Distinct();

            foreach (var skill in result01)
            {
                Console.WriteLine(skill);
            }
        }
    }
}