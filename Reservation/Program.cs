public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
}

public class Author
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class Query
{
    public Book GetBook() =>
        new Book
        {
            Title = "C# in depth.",
            Author = new Author
            {
                FirstName = "Jon",
                LastName = "Skeet"
            }
        };
}

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services
            .AddGraphQLServer()
            .AddQueryType<Query>();

        var app = builder.Build();

        app.MapGraphQL();
        app.Run();
    }
}
