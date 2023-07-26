using Hahn.Software.Domain;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Hahn.Software.Infrastructure;

public class BookService:IBookService
{
    private readonly BooksDbContext _ctx;

    public BookService(BooksDbContext ctx)
    {
        _ctx = ctx;
    }

    public async Task<List<Book>> GetAll()
    {
        return await _ctx.Books.ToListAsync();
    }

    public async Task<Book> Insert(Book book)
    {
        _ctx.Books.Add(book);
        await _ctx.SaveChangesAsync();
        return book;
    }

    public async Task<Book> Update(Book book)
    {
        var originalBook = _ctx.Books.FirstOrDefault(x=>x.Id==book.Id);
        book.Adapt(originalBook);
        await _ctx.SaveChangesAsync();
        return book;
    }

    public async Task<bool> Delete(int id)
    {
        var book = _ctx.Books.FirstOrDefault(x=>x.Id==id);
        _ctx.Books.Remove(book!);
        await _ctx.SaveChangesAsync();
        return true;
    }
}
