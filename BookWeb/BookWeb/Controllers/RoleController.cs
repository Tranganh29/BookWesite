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
    public class RoleController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public RoleController(ApplicationDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lấy tất cả danh sách Roles
        /// </summary>
        /// <returns> List Roles</returns>

        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _context.Role.ToList();
        }

        /// <summary>
        /// Lấy Role bằng Id
        /// </summary>
        /// <returns> Get Role By Id</returns>
        [HttpGet("Id")]
         public Role GetById([FromQuery] int Id)
        {
            return _context.Role.FirstOrDefault(role => role.Id == Id);
        }


        /// <summary>
        /// Thêm mới Role
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]
        public Role Post([FromQuery] Role Role)
        {
            _context.Role.Add(Role);
            _context.SaveChanges();
            return Role;
        }

    }
}
