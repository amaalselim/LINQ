# LINQ
It is a software technology for the purpose of facilitating data processing
- Write Query using C# Language
- Doing CRUD Operations
    - Create
    - Read
    - Update
    - Delete

It has two Types :
- Query Syntax => like (SQL)
- Fluent Syntax => like (Programming Extention Methods)

- Query Syntax
```C#
List<string> Names = new List<string>()
            {
                "Red","Book","Computer","Mobile","Program"
            };
            var Result = from item in Names
                         select item;
            foreach (var item in Result) Console.WriteLine(item);
```
- Fluent Syntax
  ```C#
            List<string> Names = new List<string>()
            {
                "Red","Book","Computer","Mobile","Program"
            };
            var Result = Names.Where(item=>itemContains("R"));
            
            foreach (var item in Result) Console.WriteLine(item);
  ```
