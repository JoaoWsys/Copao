using Application.Commands.Usuarios;
using Data;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CopaoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _db.Users.ToList();
            return Ok(users);
        }

        [HttpPost]
        public async IActionResult Add(CadastraUsuarioCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
