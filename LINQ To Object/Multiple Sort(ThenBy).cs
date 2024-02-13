Book[] books =
{
    new Book(){Id=10,Title="C# Programming",Author="Kamal Younes"},
    new Book(){Id=7,Title="Java Tutorials",Author="Ahmed Rochdi"},
    new Book(){Id=4,Title="Perl For Beginners",Author="Ismael Rachid"},
    new Book(){Id=7,Title="Andriod Programming",Author="Ayman Jalal"}


};
// Query Syntax
var List = from item in books orderby item.Id,item.Title descending select item;

// Fluent Syntax
var list = books.OrderByDescending(item => item.Id).ThenBy(item=>item.Title);

foreach (var item in list)
{
    Console.WriteLine("Id={0},Name={1},Author={2}", item.Id, item.Title, item.Author);
}
class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}
