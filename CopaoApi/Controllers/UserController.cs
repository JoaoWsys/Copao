using Data;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CopaoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private CopaoDbContext _db;

        public UserController(CopaoDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _db.Users.ToList();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Add(Usuario user)
        {
            var users = _db.Users.Add(user);
            return Ok(users.Entity);
        }
    }
}
