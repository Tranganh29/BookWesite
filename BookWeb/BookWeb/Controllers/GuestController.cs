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
    public class GuestController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public GuestController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Guest> Get()
        {
            return _context.Guest.ToList();
        }

    }
}
