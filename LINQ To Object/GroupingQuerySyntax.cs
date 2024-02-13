Books[] book =
{
    new Books(){Id=1,Title="C#",Author="Kamal Younes"},
    new Books(){Id=2,Title="Java Tutorials",Author="Ahmed Rochdi"},
    new Books(){Id=3,Title="Perl For Beginners",Author="Amaal Selim"},
    new Books(){Id=4,Title="C#",Author="Amaal Selim"},
    new Books(){Id=5,Title="C++",Author="Ayman Jalal"},
    new Books(){Id=6,Title="PHP",Author="Amaal Selim"},
    new Books(){Id=7,Title="Ruby",Author="Ahmed Rochdi"},

};
// Query Syntax
var List = from item in book group item by item.Author;
foreach(var item in List)
{
    Console.WriteLine("Author: " + item.Key);
    Console.WriteLine("-------------------------------------");
    foreach(var it in item)
    {
        Console.WriteLine("ID:{0}\nTitle:{1}\n ",it.Id,it.Title);
    }
}
class Books
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}
