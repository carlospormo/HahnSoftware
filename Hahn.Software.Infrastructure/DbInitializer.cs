namespace Hahn.Software.Infrastructure;

public static class DbInitializer
{
    public static void Initialize(BooksDbContext context)
    {
        context.Database.EnsureCreated();
        context.SaveChanges();
    }
}