using Hahn.Software.Domain;

namespace Hahn.Software.Infrastructure;

public interface IBookService
{
    Task<List<Book>> GetAll();
    Task<Book> Insert(Book book);
    Task<Book> Update(Book book);
    Task<bool> Delete(int id);
}