using LINQTut06.Shared;
using Skip;

namespace Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var page = 1;var size = 10;
            Console.WriteLine("Result per Page:");
            if(int.TryParse(Console.ReadLine(), out int result))
            {
                size= result;
            }

            Console.WriteLine("Page No:");
            if (int.TryParse(Console.ReadLine(), out int PageNo))
            {
                page = PageNo;
            }

            var emps = Repository.LoadEmployees();
            var resultt = emps.pagination(page,size);
            var resultCount = resultt.Count();

            var startRecord = ((page - 1) * size) + 1;

            var endRecord =
                resultCount < size ? startRecord + resultCount - 1
                : size * (page - 1) + size;

            resultt.Print($"Showing employees {startRecord} - {endRecord}");

            Console.ReadKey();


        }
    }
}