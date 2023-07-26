using Hahn.Software.Domain;
using Hahn.Software.Infrastructure;
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
        public async Task<IEnumerable<Book>> Get()
        {
            return await _srv.GetAll();
        }
    }
}