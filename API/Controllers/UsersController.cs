using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetAllUsers()
        {
           var users = _context.Users.ToList();
           return users;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<AppUser> GetUserById(int id)
        {
           return _context.Users.Find(id);
        }
    }
}