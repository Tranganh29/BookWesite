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
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public OrderController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _context.Order.ToList();
        }

    }
}
