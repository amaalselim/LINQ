namespace join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher[] teachers =
            {
                new Teacher(){Name="Khalid"},
                new Teacher(){Name="Hossam"},
                new Teacher(){Name="Abeer"},
                new Teacher(){Name="Reda"},
                new Teacher(){Name="Amaal"},
                new Teacher(){Name="Retaj"}
            };
            Student[] students =
            {
                new Student(){Name="Amaal"},
                new Student(){Name="Retaj"},
                new Student(){Name="Khalid"},
                new Student(){Name="Hossam"},
                new Student(){Name="Mohamed"},
                new Student(){Name="Romaysaa"}
            };
            // Query Syntax
            var Joinlist = from Teacher in teachers
                           join student in students
                           on Teacher.Name equals student.Name
                           select Teacher;
            foreach (var name in Joinlist)
            {
                Console.WriteLine($"Name = {name.Name}");
            }

        }
    }
    class Teacher
    {
        public string Name { get; set; }
    }
    class Student
    {
        public string Name { get; set; }
    }

}