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
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IMapper _mapper;

        public UserController(ApplicationDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
      
        public async Task<ActionResult<IEnumerable<UserDTO>>> Get()
        {
            try
            {
                var data = await _context.User
                    .Include(b => b.Role).ToArrayAsync();
                var model = _mapper.Map<IEnumerable<UserDTO>>(data);
                return new JsonResult(model);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("not good");
            }


        }
    }
}
