using Hahn.Software.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hahn.Software.Infrastructure;

public class BooksDbContext : DbContext
{
    public BooksDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Book> Books { get; set; }
}