using MediatR;

namespace Application.Commands.Usuarios
{
    public class CadastraUsuarioCommand : IRequest<bool>
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Nick { get; set; }
        public string? Elo { get; set; }
        public string? Pix { get; set; }
    }
}
