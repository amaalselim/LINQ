# LINQ
## Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language
- you have to learn a different query language for each type of data source: SQL databases, XML documents, various Web services, and so on.
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
