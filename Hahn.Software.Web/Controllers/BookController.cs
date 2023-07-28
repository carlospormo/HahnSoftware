using Hahn.Software.Domain;
using Hahn.Software.Infrastructure;
using Hahn.Software.Web.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Hahn.Software.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _srv;

        public BookController(ILogger<BookController> logger, IBookService srv)
        {
            _logger = logger;
            _srv = srv;
        }

        [HttpGet]
        public async Task<IEnumerable<BookModel>> Get()
        {
            return (await _srv.GetAll()).Adapt<List<BookModel>>();
        }

        [HttpPost]
        public async Task<Book> Insert(BookModel book)
        {
            return await _srv.Insert(book.Adapt<Book>());
        }

        [HttpPut]
        public async Task<Book> Update(BookModel book)
        {
            return await _srv.Update(book.Adapt<Book>());
        }

        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            return await _srv.Delete(id);
        }
    }
}