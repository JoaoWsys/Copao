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
        private CopaoDbContext _db;
        public Task Add(Usuario item)
        {
            _db.Users.Add(item);
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(Usuario item)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
