using Data;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        private readonly CopaoDbContext _db;
        public UsuarioRepository(CopaoDbContext db)
        {
            _db = db;
        }

        public void Add(Usuario usuario)
        {
            _db.Users.Add(usuario);
        }

        public void Delete(Usuario usuario)
        {
            _db.Users.Update(usuario);
        }

        public Usuario Edit(Usuario usuario)
        {
            _db.Users.Update(usuario);
            return usuario;
        }

        public Usuario Get(int id)
        {
            var usuario = _db.Users.FirstOrDefault(u => u.Id == id);
            if(usuario != null)
            {
                return usuario;
            }
            return new Usuario();
        }

        public IEnumerable<Usuario> GetAll()
        {
            var usuarios = _db.Users.ToList();
            return usuarios;
        }
    }
}
