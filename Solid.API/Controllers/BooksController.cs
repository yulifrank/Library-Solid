using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.servies.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly    IBookService _bookService;
        private readonly IMapper _mapper;

        public BooksController(IBookService bookService, IMapper mapper)
        {
          _bookService= bookService;  
            _mapper= mapper;    
        }

        // GET: api/<Books>
        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> Get()
        {
            var books = _bookService.GetBooks();
            var bookDtos = _mapper.Map<IEnumerable<BookDto>>(books);

            return Ok(bookDtos);
        }

        // GET api/<Books>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var book = _bookService.GetById(id);
            //var userDto = _mapping.MapToUserDto(user);
            var bookDto = _mapper.Map<BookDto>(book);

            return Ok(bookDto);
        }

        // POST api/<Books>
        [HttpPost]
        public async Task<Book> Post([FromBody] BookPostModel value)
        {
            
            var bookToAdd = new Book {Name = value.Name ,NumberOfPages=value.NumberOfPages };

         return   await  _bookService.AddBookAsync(bookToAdd);
        }
      
        // PUT api/<Books>/5
        [HttpPut("{id}")]
        public async Task<Book> Put(int id, [FromBody] Book updatedBook)
        {
          return await _bookService.UpdateBookAsync(id, updatedBook);    
        }



        // DELETE api/<Books>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
             await _bookService.DeleteBookAsync(id);

        }

      
    }
}
