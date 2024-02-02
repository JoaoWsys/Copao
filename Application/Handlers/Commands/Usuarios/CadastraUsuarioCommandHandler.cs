using Application.Commands.Usuarios;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Handlers.Commands.Usuarios
{
    public class CadastraUsuarioCommandHandler : IRequestHandler<CadastraUsuarioCommand, bool>
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public CadastraUsuarioCommandHandler(IRepository<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<bool> Handle(CadastraUsuarioCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
