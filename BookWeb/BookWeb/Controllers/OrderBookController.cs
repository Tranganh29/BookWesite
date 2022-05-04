using BookWeb.Data;
using BookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Controllers
{ 
    [ApiController]
    [Route("[Controller]")]
    public class OrderBookController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public OrderBookController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<OrderBook> Get()
        {
            return _context.OrderBook.ToList();
        }

    }
}
