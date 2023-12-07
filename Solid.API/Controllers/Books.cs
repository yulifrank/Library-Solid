using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Books : ControllerBase
    {
        private readonly    IBookService _bookService;

        public Books(IBookService bookService)
        {
          _bookService= bookService;  
        }

        // GET: api/<Books>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_bookService.GetBooks());
        }

        // GET api/<Books>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_bookService.GetById(id));
        }

        // POST api/<Books>
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            _bookService.AddBook(value);
        }

        // PUT api/<Books>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book updatedBook)
        {
           _bookService.UpdateBook(id, updatedBook);    
        }



        // DELETE api/<Books>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _bookService.DeleteBook(id);

        }
    }
}
