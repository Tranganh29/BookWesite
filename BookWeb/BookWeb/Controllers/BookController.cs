using AutoMapper;
using BookWeb.Data;
using BookWeb.DTO;
using BookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BookController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly IMapper _mapper;

        public BookController(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Lấy tất cả Book
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<BookDTO>>> Get()
        {
            try
            {
                var data = await _context.Book
                    .Include(b => b.CreatedUser)
                    .Include(b => b.UpdateUser).ToArrayAsync();
                var model = _mapper.Map<IEnumerable<BookDTO>>(data);
                return new JsonResult(model);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("not good");
            }

        }

        /// <summary>
        /// Thêm mới Book
        /// </summary>
        /// <param name="Book"></param>
        /// <returns></returns>
        [HttpPost]
        public Book Post([FromBody] Book Book)
        {
            var createdUser = _context.User.Find(Book.CreatedUser.Id);
            Book.CreatedUser = createdUser;

            var updateUser = _context.User.Find(Book.UpdateUser.Id);
            Book.UpdateUser = updateUser;

            _context.Book.Add(Book);
            _context.SaveChanges();
            return Book;
        }
        [HttpPut]
        public Book Put([FromBody] Book Book)
        {
            var book = _context.Book.Find(Book.Id);
            if (book == null)
            {
                return Book;
            }
            book.NameBook = Book.NameBook;
            book.Description = Book.Description;
            book.BookImg = Book.BookImg;
            book.Category = Book.Category;
            book.Price = Book.Price;
            book.Discount = Book.Discount;

            var updateUser = _context.User.Find((Book.UpdateUser != null) ? Book.UpdateUser.Id : 1);
            book.UpdateUser = updateUser;
            _context.SaveChanges();
            return Book;

        }

    }
}

